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
        private long[] listaClientes = new long[] { 12345678910, 99999999 };
        /*public List<Cliente> Clientes { get; } = new()
    {
        new Cliente { CUITCUIL = 20378401861},
        new Cliente { CUITCUIL = 7312345653 }
    };*/

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

            if (!listaClientes.Contains(validarCliente.CUITCUIL))
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

            


            for (int i = 0; i < encomiendas.CantidadCajas; i++)
            {
                var listItem = new ListViewItem();
                //Generar numero de guia//
                encomiendas.NumeroGuia = (encomiendas.CodigoAgencia.ToString() + ((DateTime.Now.Ticks)).ToString());
                //Fin generar numero de guia//

                listItem.Text = encomiendas.NumeroGuia;
                listItem.SubItems.Add(encomiendas.Provincia);
                listItem.SubItems.Add(encomiendas.Localidad);
                listItem.SubItems.Add(encomiendas.MetodoEntrega);
                listItem.SubItems.Add(encomiendas.CodigoPostal.ToString());
                listItem.SubItems.Add(encomiendas.CentroDistribucionDestino);
                listItem.SubItems.Add(encomiendas.Domicilio);
                listItem.SubItems.Add(encomiendas.CantidadCajas.ToString());
                listItem.SubItems.Add(encomiendas.TipoCaja);
                listItem.SubItems.Add(encomiendas.NombreDestinatario);
                listItem.SubItems.Add(encomiendas.ApellidoDestinatario);
                listItem.SubItems.Add(encomiendas.DNI.ToString());
                listItem.SubItems.Add(encomiendas.CodigoAgencia.ToString());

                MessageBox.Show("Guia generada exitosamente: " + encomiendas.NumeroGuia);
                return;
                //ListViewItem.Item


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
