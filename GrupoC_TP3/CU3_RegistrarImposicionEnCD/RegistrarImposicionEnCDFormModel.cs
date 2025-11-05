using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU3_RegistrarImposicionEnCD
{
    internal class RegistrarImposicionEnCDFormModel
    {
        private long[] listaClientes = new long[] { 12345678910, 12345678911 };

        private Dictionary<int, List<LocalidadEntidad>> _localidadesPorCodProv;
        private Dictionary<string, int> _codProvPorNombre;
        private bool _indicesConstruidos;

        private void ConstruirIndicesProvinciasYLocalidades()
        {
            if (_indicesConstruidos) return;

            var provincias = ProvinciaAlmacen.provincias ?? new List<ProvinciaEntidad>();
            var localidades = LocalidadAlmacen.localidades ?? new List<LocalidadEntidad>();

            _codProvPorNombre = provincias
                .GroupBy(p => p.Nombre, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.First().CodProv, StringComparer.OrdinalIgnoreCase);

            _localidadesPorCodProv = localidades
                .GroupBy(l => l.CodProv)
                .ToDictionary(
                    g => g.Key,
                    g => g.OrderBy(l => l.Nombre).ToList()
                );

            _indicesConstruidos = true;
        }

        public List<string> LocalidadesDeProvincia(string nombreProvincia)
        {
            ConstruirIndicesProvinciasYLocalidades();

            if (string.IsNullOrWhiteSpace(nombreProvincia))
                return new List<string>();

            if (!_codProvPorNombre.TryGetValue(nombreProvincia, out var codProv))
                return new List<string>();

            if (!_localidadesPorCodProv.TryGetValue(codProv, out var locs))
                return new List<string>();

            return locs.Select(l => l.Nombre)
                       .Distinct(StringComparer.OrdinalIgnoreCase)
                       .OrderBy(n => n, StringComparer.OrdinalIgnoreCase)
                       .ToList();
        }

        public Ubicacion ObtenerUbicacion1()
        {
            var ubicacion = new Ubicacion
        {
            ProvinciasYLocalidades = ProvinciaAlmacen.provincias.Select(p => new
            {
                p.Nombre,
                Localidades = LocalidadAlmacen.localidades.Where(l => l.CodProv == p.CodProv)
                                                          .Select(l => l.Nombre)
                                                          .OrderBy(n => n)
                                                          .ToList()
            }).ToDictionary(p => p.Nombre, v => v.Localidades),

            CodigoPostalCentroDistribucion = CentroDistribucionAlmacen.centrosDistribucion
                                                                      .ToDictionary(cd => cd.CodPostal.ToString("0000"), cd => cd.Nombre)
            };

            return ubicacion;
            
        }

        internal void ValidarCl(ClienteImposicionCD validarCliente)
        {
            if (validarCliente.CUITCUIL <= 0)
            {
                MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (validarCliente.CUITCUIL.ToString().Length != 11)
            {
                MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if(validarCliente.CUITCUIL.ToString().Any(ch => !char.IsDigit(ch)))
            {
               MessageBox.Show("El CUIT/CUIL no debe contener caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!ClienteAlmacen.clientes.Any(c => c.CUITCUIL == validarCliente.CUITCUIL))
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Cliente valido", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            /*if (!listaClientes.Contains(validarCliente.CUITCUIL))
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Cliente valido", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
        }


        internal void CrearEncomienda(Encomienda encomiendas)
        {
            //A este metodo le tenemos que pasar la cantidad de cajas para uqe genere una guía por caja.
            //encomiendas.NumeroGuia = encomiendas.NumeroGuia;


            if (encomiendas.DNI < 100000 || encomiendas.DNI > 99999999)
            {
                MessageBox.Show("El DNI del destinatario ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //que no escriba LETRAS en el DNI
            if (encomiendas.DNI.ToString().Any(ch => !char.IsDigit(ch)))
            {
                MessageBox.Show("El DNI es un valor numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (encomiendas.CodigoPostal < 1000)
            {
                MessageBox.Show("El Codigo Postal ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (encomiendas.CodigoPostal.ToString().Any(ch => !char.IsDigit(ch)))
            {
                MessageBox.Show("El Codigo Postal es un valor numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
               
            }

            if (encomiendas.Cliente <= 0)
            {
                MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (encomiendas.Cliente.ToString().Length != 11)
            {
                MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if(!ClienteAlmacen.clientes.Any(c => c.CUITCUIL == encomiendas.Cliente))
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codCentroDistribucionOrigen = 1006;

            int codCentroDistribucionDestino = CentroDistribucionAlmacen.centrosDistribucion
            .Where(cd => cd.Nombre.Equals(encomiendas.CentroDistribucionDestino, StringComparison.OrdinalIgnoreCase))
            .Select(cd => cd.CodCentroDist)
            .FirstOrDefault();


            for (int i = 0; i < encomiendas.CantidadCajas; i++)
            {
                var tamañoSeleccionado = Enum.Parse<TamañoCaja>(encomiendas.TipoCaja?.Trim(), ignoreCase: true);

                decimal importeBase = TarifaAlmacen.tarifas
                             .Where(t => t.TamañoCaja == tamañoSeleccionado
                                 && t.CentroDistribucionOrigen == codCentroDistribucionOrigen
                                 && t.CentroDistribucionDestino == codCentroDistribucionDestino)
                                 .Select(t => t.Importe)
                                 .Single();

                if (encomiendas.MetodoEntrega.Equals("Entrega en Domicilio", StringComparison.OrdinalIgnoreCase))
                {
                    importeBase += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                        .Where(a => a.Concepto == Concepto.EntregaDomicilio)
                                        .Select(a => a.Monto)
                                        .Sum();
                }

                if (encomiendas.MetodoEntrega.Equals("Retiro en Agencia", StringComparison.OrdinalIgnoreCase))
                {
                    importeBase += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                        .Where(a => a.Concepto == Concepto.EntregaAgencia)
                                        .Select(a => a.Monto)
                                        .Sum();
                }

                decimal importe = importeBase;

                decimal cargoFlete = AdicionalesYComisionesAlmacen.adicionalesComisiones
                                    .Where(f => f.Concepto == Concepto.ComisionFleteroPorBulto)
                                    .Select(f => f.Monto).Single();

                GuiaAlmacen.guias.Add(new GuiaEntidad
                {
                    NumeroGuia = int.Parse(codCentroDistribucionOrigen.ToString() + ((DateTime.Now.Ticks)).ToString()[^5..]),
                    CUITCUIL = encomiendas.Cliente,
                    CodPostalDest = encomiendas.CodigoPostal,

                    DomicilioDest = encomiendas.Domicilio,
                    CodPostalOrig = CentroDistribucionAlmacen.centrosDistribucion
                                    .Where(a => a.CodCentroDist == codCentroDistribucionOrigen)
                                    .Select(a => a.CodPostal)
                                    .FirstOrDefault(),
                    DomicilioOrigen = "Imposicion en CD",
                    NombreDestinatario = encomiendas.NombreDestinatario,
                    ApellidoDestinatario = encomiendas.ApellidoDestinatario,
                    DNIDestinatario = encomiendas.DNI,
                    Importe = importe,
                    CargosFleteros = cargoFlete,
                    CargosAgencia = 0,
                    CodAgenciaOrigen = 0,
                    CodCentroDistOrigen = codCentroDistribucionOrigen,
                    EstadoEncomienda = EstadoEncomienda.EntregadoEnCentroDeDistribucion,
                    HistorialEstadosGuia = new List<HistorialEstadoGuia>
                {
                    new HistorialEstadoGuia
                    {
                        EstadoGuiaEnum = EstadoEncomienda.EntregadoEnCentroDeDistribucion,
                        Fecha = DateTime.Now,
                        Descripcion = "Encomienda creada y disponible en Centro de Distribucion."
                    }
                }
                });

                MessageBox.Show("La encomienda ha sido creada con exito. El numero de guia es: " + GuiaAlmacen.guias.Last().NumeroGuia.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("El importe a cobrar por la encomienda es: $" + GuiaAlmacen.guias.Last().Importe.ToString("F2"), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); //Queria ver si el numero estaba ok
            }
        }


        public Ubicacion ObtenerUbicacion()
        {

            var ubicacion = new Ubicacion
            {
                ProvinciasYLocalidades = new Dictionary<string, List<string>>
            {
                { "Buenos Aires", new List<string> { "La Plata", "Mar del Plata", "Bahía Blanca" } },
                { "Córdoba", new List<string> { "Córdoba Capital", "Villa María", "Río Cuarto" } },
                { "Santa Fe", new List<string> { "Rosario", "Santa Fe Capital", "Rafaela" } },

            },

                CodigoPostalCentroDistribucion = new Dictionary<string, string>
            {
                { "1900", "Centro La Plata" },
                { "7600", "Centro Mar del Plata" },
                { "8000", "Centro Bahía Blanca" },
                { "5000", "Centro Córdoba Capital" },
                { "5900", "Centro Villa María" },
                { "5800", "Centro Río Cuarto" },
                { "2000", "Centro Rosario" },
                { "3000", "Centro Santa Fe Capital" },
                { "2300", "Centro Rafaela" }
            }
            };

            return ubicacion;
        }

    }
}
