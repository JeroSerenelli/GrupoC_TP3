using GrupoC_TP3.Almacenes;

namespace GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio
{
    internal class RegistrarImposicionRetiroPorDomicilioModel
    {
        // Índices en memoria (solo del modelo)
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



        internal void ValidacionCliente(ValidacionClientes cliente)
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

            //TODO: no me funciona esta busqueda. 
            /*
            bool ok = false;
            foreach (var c in ClienteAlmacen.clientes)
            {
                if (cliente.CUITCUIL == c.CUITCUIL)
                {
                    ok = true;
                    return;
                }
            }

            if (!ok)
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                MessageBox.Show("El cliente es válido.", "Éxitos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    */

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
            //TODO: NO FUNCIONA
            List<string> nroGuias = new List<string>();
            int contador = 0;

            for (int i = 0; i < encomiendas.CantCajas; i++)
            {

                //var guiaGenerada = "1000" + ((DateTime.Now.Ticks)).ToString())
                string guia = "1000" + contador.ToString();
                nroGuias.Add(guia);
                contador++;
            }
            MessageBox.Show("Guia generada exitosamente: " + String.Join(", ", nroGuias));

        }
    }
}

