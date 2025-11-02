using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;
using GrupoC_TP3.CU9_CuentaCorriente;
using System.Net;
using static GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio.Ubicacion;

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

            // nombre provincia -> CodProv (case-insensitive)
            _codProvPorNombre = provincias
                .GroupBy(p => p.Nombre, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.First().CodProv, StringComparer.OrdinalIgnoreCase);

            // CodProv -> lista de Localidades ordenadas
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
















        // Nivel de clase (para que puedas accederlo desde cualquier método del formulario)

        //public long[] listaClientes = new long[] { 123456789, 99999999, 12345678910 };

        public Ubicacion ObtenerUbicacion1()
        {
            var ubicacion = new Ubicacion
            {
                ProvinciasYLocalidades = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase),
                CodigoPostalCentroDistribucion = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            };

            // 1) Provincias desde Provincias.json
            var provincias = ProvinciaAlmacen.provincias ?? new List<ProvinciaEntidad>();

            // 2) Localidades desde Localidades.json
            var localidades = LocalidadAlmacen.localidades ?? new List<LocalidadEntidad>();

            // 3) Armar mapa Provincia -> [Localidades]
            foreach (var p in provincias.OrderBy(p => p.Nombre))
            {
                var locs = localidades
                 .Where(l => l.CodProv == p.CodProv)
                .OrderBy(l => l.Nombre)
                .Select(l => l.Nombre)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

                ubicacion.ProvinciasYLocalidades[p.Nombre] = locs;
            }




            // 4) (opcional pero útil) CP -> Centro de Distribución desde CentrosDistribucion.json
            foreach (var cd in (CentroDistribucionAlmacen.centrosDistribucion ?? new List<CentroDistribucionEntidad>()))
            {
                var cp = cd.CodPostal.ToString("0000"); // el modelo valida CP de 4 dígitos
                if (!ubicacion.CodigoPostalCentroDistribucion.ContainsKey(cp))
                    ubicacion.CodigoPostalCentroDistribucion[cp] = cd.Nombre;
            }

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

            foreach (var c in ClienteAlmacen.clientes)
            {
                if (cliente.CUITCUIL == c.CUITCUIL)
                {
                    MessageBox.Show("Cliente valido", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            
            /*if (!listaClientes.Contains(cliente.CUITCUIL))*/
            /*{
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Cliente valido", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
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
            //A este metodo le tenemos que pasar la cantidad de cajas para uqe genere una guía por caja.
            //encomiendas.NumeroGuia = encomiendas.NumeroGuia;

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

