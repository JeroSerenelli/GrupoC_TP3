using GrupoC_TP3.Almacenes;
using System.Text.Json;

namespace GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio
{
    internal class RegistrarImposicionRetiroPorDomicilioModel
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

        public void ValidacionCliente(ValidacionClientes cliente)
        {
            //SEA POSITIVO 
            if (cliente.CUITCUIL <= 0) //Lvl 2
            {
                MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBoxDNIDestinatario.Focus();
                return;
            }
            //SEA DE 11 DIGITOS
            if (cliente.CUITCUIL.ToString().Length != 11)
            {
                MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBoxDNIDestinatario.Focus();
                return;
            }

            //Versión corta:
            if (!ClienteAlmacen.clientes.Any(c => c.CUITCUIL == cliente.CUITCUIL))
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El cliente es válido.", "Éxitos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal bool ValidacionDestino(EncomiendasImpuestas infoDestino)
        {
            if (infoDestino.CPDestino.ToString().Length != 4)
            {
                MessageBox.Show("El codigo postal destino debe tener 4 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        internal bool ValidacionDatosEncomienda(EncomiendasImpuestas encomiendas)
        {
            if (encomiendas.CantCajas <= 0) //Lvl 2
            {
                MessageBox.Show("La cantidad de cajas ingresadas es invalido, debe ser al menos 1 caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }

        internal bool ValidacionesDatosRetiro(EncomiendasImpuestas infoRetiro)
        {
            if (infoRetiro.CPRetiro.ToString().Length != 4)
            {
                MessageBox.Show("El codigo postal destino debe tener 4 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        internal bool ValidacionDatosDestinatario(EncomiendasImpuestas datosDestinatario)
        {

            //SEA POSITIVO
            if (datosDestinatario.DNIDestinatario <= 0)
            {
                MessageBox.Show("El campo DNI debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }
            //SEA DE 8 DIGITOS
            if (datosDestinatario.DNIDestinatario.ToString().Length != 8)
            {
                MessageBox.Show("El campo DNI debe tener 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }
            return false;

        }
        internal void CrearEncomienda(EncomiendasImpuestas encomiendas)
        {
            if (encomiendas.CPDestino == encomiendas.CPRetiro)
            {
                MessageBox.Show("El codigo postal de destino no puede ser igual al de retiro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (encomiendas.NroCUITCUIL <= 0) //Lvl 2
            {
                MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //SEA DE 11 DIGITOS
            if (encomiendas.NroCUITCUIL.ToString().Length != 11)
            {
                MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ClienteAlmacen.clientes.Any(c => c.CUITCUIL == encomiendas.NroCUITCUIL))
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codCentroDistribucionOrigen = CentroDistribucionAlmacen.centrosDistribucion
                .Where(x => x.CodPostal == encomiendas.CPRetiro)
                .Select(x => x.CodCentroDist)
                .FirstOrDefault();

            int codCentroDistribucionDestino = CentroDistribucionAlmacen.centrosDistribucion
                .Where(x => x.CodPostal == encomiendas.CPDestino)
                .Select(x => x.CodCentroDist)
                .FirstOrDefault();

            for (int i = 0; i < encomiendas.CantCajas; i++)
            {
                var tamañoSeleccionado = Enum.Parse<TamañoCaja>(encomiendas.TipoCaja?.Trim(), ignoreCase: true);

                decimal importeBase = TarifaAlmacen.tarifas
                         .Where(t => t.TamañoCaja == tamañoSeleccionado
                             && t.CentroDistribucionOrigen == codCentroDistribucionOrigen
                             && t.CentroDistribucionDestino == codCentroDistribucionDestino)
                             .Select(t => t.Importe)
                             .Single();




                decimal importeRetiroDomicilio = importeBase + AdicionalesYComisionesAlmacen.adicionalesComisiones
                                    .Where(a => a.Concepto == Concepto.RetiroDomicilio)
                                    .Select(a => a.Monto)
                                    .Sum();

                decimal cargoAgencia = 0;

                if (encomiendas.MetodoEntrega.Equals("Entrega en Domicilio", StringComparison.OrdinalIgnoreCase))
                {
                    importeRetiroDomicilio += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                        .Where(a => a.Concepto == Concepto.EntregaDomicilio)
                                        .Select(a => a.Monto)
                                        .Sum();
                }

                if (encomiendas.MetodoEntrega.Equals("Retiro en Agencia", StringComparison.OrdinalIgnoreCase))
                {
                    importeRetiroDomicilio += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                        .Where(a => a.Concepto == Concepto.EntregaAgencia)
                                        .Select(a => a.Monto)
                                        .Sum();

                    cargoAgencia += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                        .Where(a => a.Concepto == Concepto.EntregaAgencia)
                                        .Select(a => a.Monto).Single();
                }

                decimal finalAgencia = cargoAgencia / 2m;

                decimal importe = importeRetiroDomicilio;

                decimal cargoFlete = AdicionalesYComisionesAlmacen.adicionalesComisiones
                                    .Where(f => f.Concepto == Concepto.ComisionFleteroPorBulto)
                                    .Select(f => f.Monto).Single();

                GuiaAlmacen.guias.Add(new GuiaEntidad
                {
                    NumeroGuia = int.Parse(codCentroDistribucionOrigen.ToString() + DateTime.Now.Ticks.ToString()[^5..]),
                    CUITCUIL = encomiendas.NroCUITCUIL,
                    CodPostalDest = encomiendas.CdDestino,
                    MetodoEntrega = encomiendas.MetodoEntrega switch
                    {
                        "Entrega en Domicilio" => MetodoEntrega.EntregaEnDomicilio,
                        "Retiro en Agencia" => MetodoEntrega.EntregaEnAgencia,
                        "Retiro en CD Destino" => MetodoEntrega.EntregaEnCentroDeDistribucion,
                        _ => throw new ArgumentException($"Método de entrega inválido: {encomiendas.MetodoEntrega}"),
                    }, 
                    //TODO: no se como convertirlo
                    DomicilioDest = encomiendas.DomicilioDestinatario,
                    //TamañoCaja = encomiendas.TipoCaja, 
                    //TODO: idem, no se trabajar con el enum
                    CodPostalOrig = encomiendas.CPRetiro,
                    DomicilioOrigen = encomiendas.DomicilioRetiro,
                    NombreDestinatario = encomiendas.NombreDestinatario,
                    ApellidoDestinatario = encomiendas.ApellidoDestinatario,
                    DNIDestinatario = encomiendas.DNIDestinatario,
                    Importe = importe,
                    CargosFleteros = cargoFlete,
                    CargosAgencia = finalAgencia,
                    CodAgenciaOrigen = 0, //no lo necesito, es imposicion por telefono
                    CodCentroDistOrigen = codCentroDistribucionOrigen,
                    EstadoEncomienda = EstadoEncomienda.ListoParaRetirarEnDomicilio,
                    HistorialEstadosGuia = new List<HistorialEstadoGuia>
                    {
                        new HistorialEstadoGuia
                        {
                            Fecha = DateTime.Now,
                            EstadoGuiaEnum = EstadoEncomienda.ListoParaRetirarEnDomicilio,
                            Descripcion = "Encomienda creada y lista para ser retirada en domicilio."
                        }
                    }
                });

                MessageBox.Show("La encomienda ha sido creada con exito. El numero de guia es: " + GuiaAlmacen.guias.Last().NumeroGuia.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("El importe a cobrar por la encomienda es: $" + GuiaAlmacen.guias.Last().Importe.ToString("F2"), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); //Queria ver si el numero estaba ok
                MessageBox.Show("Importe base: " + importeBase.ToString());
                MessageBox.Show("El importe a pagar a la agencia es de: $" + GuiaAlmacen.guias.Last().CargosAgencia.ToString("F3"), "Exito");
            }
        }
    }
}

