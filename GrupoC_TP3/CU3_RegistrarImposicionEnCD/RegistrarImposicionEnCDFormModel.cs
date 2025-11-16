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

        public int CodigoCentroDistribucionActual => CentroDistribucionAlmacen.centroDistribucionActual?.CodCentroDist ?? 0;

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
        }


        internal void CrearEncomienda(Encomienda encomiendas)
        {
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

            int codCentroDistribucionOrigen = CentroDistribucionAlmacen.centroDistribucionActual.CodCentroDist;

            int codCentroDistribucionDestino = CentroDistribucionAlmacen.centrosDistribucion
            .Where(cd => cd.Nombre.Equals(encomiendas.CentroDistribucionDestino, StringComparison.OrdinalIgnoreCase))
            .Select(cd => cd.CodCentroDist)
            .FirstOrDefault();

            decimal cargoAgencia = 0;

            var numerosCreados = new List<int>();

            for (int i = 0; i < encomiendas.CantidadCajas; i++)
            {
                int ultimoNumeroGuia = GuiaAlmacen.guias.LastOrDefault()?.NumeroGuia ?? 0;

                ultimoNumeroGuia += 1;

                string ultimosCincoDigitos = (ultimoNumeroGuia % 100000).ToString("D5");

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

                    cargoAgencia += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                        .Where(a => a.Concepto == Concepto.EntregaAgencia)
                                        .Select(a => a.Monto).Single();

                }

                decimal finalAgencia = cargoAgencia / 2m;

                decimal importe = importeBase;

                decimal cargoFlete = AdicionalesYComisionesAlmacen.adicionalesComisiones
                                    .Where(f => f.Concepto == Concepto.ComisionFleteroPorBulto)
                                    .Select(f => f.Monto).Single();

                GuiaAlmacen.guias.Add(new GuiaEntidad
                {
                    NumeroGuia = int.Parse(codCentroDistribucionOrigen.ToString() + ultimosCincoDigitos),
                    CUITCUIL = encomiendas.Cliente,
                    CodPostalDest = encomiendas.CodigoPostal,
                    MetodoEntrega = encomiendas.MetodoEntrega switch
                    {
                        "Retiro en Agencia" => MetodoEntrega.EntregaEnAgencia,
                        "Entrega en Domicilio" => MetodoEntrega.EntregaEnDomicilio,
                        "Retiro en CD Destino" => MetodoEntrega.EntregaEnCentroDeDistribucion
                    },
                    DomicilioDest = encomiendas.Domicilio,
                    TamañoCaja = encomiendas.TipoCaja switch
                    {
                        "S" => TamañoCaja.S,
                        "M" => TamañoCaja.M,
                        "L" => TamañoCaja.L,
                        "XL" => TamañoCaja.XL
                    },
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
                    CargosAgencia = finalAgencia,
                    CodAgenciaOrigen = 0,
                    CodCentroDistOrigen = codCentroDistribucionOrigen,
                    EstadoEncomienda = EstadoEncomiendaEnum.EntregadoEnCentroDeDistribucion,
                    HistorialEstadosGuia = new List<HistorialEstadoGuia>
                {
                    new HistorialEstadoGuia
                    {
                        EstadoGuia = EstadoEncomiendaEnum.EntregadoEnCentroDeDistribucion,
                        Fecha = DateTime.Now,
                        Descripcion = "Encomienda creada y disponible en Centro de Distribucion."
                    }
                }
                });

                GuiaAlmacen.GuardarGuia();

                numerosCreados.Add(GuiaAlmacen.guias.Last().NumeroGuia);

                MessageBox.Show("La encomienda ha sido creada con exito. El numero de guia es: " + GuiaAlmacen.guias.Last().NumeroGuia.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GenerarHojaDeRutaFleteParaEntrega(encomiendas, numerosCreados);
        }


        internal void GenerarHojaDeRutaFleteParaEntrega(Encomienda encomiendas, List<int> numerosGuiasCreadas)
        {
            if (encomiendas.MetodoEntrega == "Entrega en Domicilio")
            {

                if (numerosGuiasCreadas == null || numerosGuiasCreadas.Count == 0) return;

                // 1) Número de hoja de ruta: último + 1
                int nuevoNumeroHoja = (HojaRutaFleteAlmacen.hojasRutaFletes.LastOrDefault()?.HojaRutaFlete ?? 0) + 1;

                // 2) DNI del fletero por CP de ORIGEN de la encomienda
                int cpDestino = encomiendas.CodigoPostal; // <-- usa el CP de la encomienda
                int dniFletero = FleteroAlmacen.fleteros
                                    .FirstOrDefault(f => f.CodPostalActividad == cpDestino)?.DNIFletero ?? 0;

                // 3) Armar los NumerosGuiaFlete con estado inicial apropiado
                var numerosGuiaFlete = numerosGuiasCreadas
                    .Distinct()
                    .Select(n => new NumeroGuiaFlete
                    {
                        NumeroGuia = n,
                        // Para retiros por domicilio recién creados:
                        EstadoEncomienda = EstadoEncomiendaEnum.ListoParaRetirarEnDomicilio
                    })
                    .ToList();

                // 4) Crear entidad y persistir
                var hoja = new HojaRutaFleteEntidad
                {
                    HojaRutaFlete = nuevoNumeroHoja,
                    NumerosGuiaFlete = numerosGuiaFlete,
                    DNIFletero = dniFletero,                       // puede quedar 0 si no hay fletero para ese CP
                    EstadoHojaRutaFlete = EstadoHojaRutaFlete.PendienteAsignacion,
                    TipoHojaRuta = TipoHojaRuta.Entrega,
                    CodPostal = cpDestino
                };

                HojaRutaFleteAlmacen.hojasRutaFletes.Add(hoja);
                HojaRutaFleteAlmacen.GuardarHojaDeRutaFlete();
            }
        }
    }
}
