using GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;
using GrupoC_TP3.CU9_CuentaCorriente;
using System.Net;

namespace GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio
{
    internal class RegistrarImposicionRetiroPorDomicilioModel
    {
        // Nivel de clase (para que puedas accederlo desde cualquier método del formulario)
       
        public long[] listaClientes = new long[] { 123456789, 99999999, 12345678910 };

        public Ubicacion ObtenerUbicacion1()
        {

            var ubicacion1 = new Ubicacion
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

            return ubicacion1;
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

            if (!listaClientes.Contains(cliente.CUITCUIL))
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

        internal void ValidacionDestino(EncomiendasImpuestas infoDestino)
        {
            if (infoDestino.CPDestino.ToString().Length != 4)
            {
                MessageBox.Show("El codigo postal destino debe tener 4 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        internal void ValidacionDatosEncomienda(EncomiendasImpuestas encomiendas)
        {
            if (encomiendas.CantCajas <= 0) //Lvl 2
            {
                MessageBox.Show("La cantidad de cajas ingresadas es invalido, debe ser al menos 1 caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        internal void ValidacionesDatosRetiro(EncomiendasImpuestas infoRetiro)
        {
            if (infoRetiro.CPRetiro.ToString().Length != 4)
            {
                MessageBox.Show("El codigo postal destino debe tener 4 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
        internal void ValidacionDatosDestinatario(EncomiendasImpuestas datosDestinatario)
        {
            //SEA POSITIVO
            if (datosDestinatario.DNIDestinatario <= 0)
            {
                MessageBox.Show("El campo DNI debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBoxDNIDestinatario.Focus();
                return;
            }
            //SEA DE 8 DIGITOS
            if (datosDestinatario.DNIDestinatario.ToString().Length != 8)
            {
                MessageBox.Show("El campo DNI debe tener 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBoxDNIDestinatario.Focus();
                return;
            }
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

