using GrupoC_TP3.CU3_EmisionFacturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrupoC_TP3.CU8_EmisionFacturas.Factura;

namespace GrupoC_TP3.CU8_EmisionFacturas
{
    public partial class EmisionFacturasForm : Form

    {
        private EmisionFacturasModel modelo = new();

         public EmisionFacturasForm()
        {
            InitializeComponent();
            //Preguntar a Jero si es traer las listas
            PedidosAFacturarListView.View = View.Details;
            PedidosAFacturarListView.FullRowSelect = true;
            PedidosAFacturarListView.CheckBoxes = false;
            //el txtbox del total no se puede editar
            textBoxTotalFactura.ReadOnly = true;
        }

        private void buttonBuscarCuilCliente_Click(object sender, EventArgs e)
        {

            //COMENZAMOS QUE LA LISTA ESTA VACIA
            PedidosAFacturarListView.Items.Clear();

            //BUSCAMOS QUE COLOQUEN UN CUIL Y NO QUEDE VACIO
            if (string.IsNullOrEmpty(textBoxCuilCliente.Text))
            {
                MessageBox.Show("Para realizar una busqueda, ingrese un CUIL/CUIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Con esto hacemos que se quede en esta parte
                textBoxCuilCliente.Focus();
                return;
            }
           
            //VALIDAMOS EL CUIL CON LOS PARAMETROS QUE CONSIDERAMOS CORRECTOS
            if (!modelo.ValidacionCuil(textBoxCuilCliente.Text))
            {
                textBoxCuilCliente.Focus();
            }
            //SI ESTA BIEN, ENTONCES VAMOS A SOLICITAR LAS GUIAS VINCULADAS A ESE CUIL
            else
            {
                decimal totalFactura = 0;
                //RECORREMOS LA LISTA DE GUIAS QUE NOS DEVUELVE EL MODELO
                foreach (var guia in modelo.ObtenerGuia(Convert.ToInt64(textBoxCuilCliente.Text)))
                {
                    var listItem = new ListViewItem();
                    listItem.Text = guia.NumeroGuia.ToString();
                    listItem.SubItems.Add(guia.Importe.ToString("C")); // Formatear como moneda
                    listItem.Tag = guia; // Guardamos el objeto para usarlo luego
                    PedidosAFacturarListView.Items.Add(listItem);

                    totalFactura += guia.Importe;
                }

                textBoxTotalFactura.Text = totalFactura.ToString("C"); // Formatear como moneda
            }
        }

        private void buttonEmitirFactura_Click(object sender, EventArgs e)
        {
            //VAMOS A LLAMAR NUEVAMENTE AL METODO PARA VALIDAR EL CUIL, EN CASO QUE SE HAYA CAMBIADO, Y VAMOS A SALIR
            if (!modelo.ValidacionCuil(textBoxCuilCliente.Text))
            {
                return;
            }

            //VERIFICAMOS QUE HAYA PEDIDOS PARA FACTURAR, EN CASO QUE NO, DAMOS UN MENSAJE DE ERROR
            if (PedidosAFacturarListView.Items.Count == 0)
            {
                MessageBox.Show("No hay pedidos para facturar, por favor realice una busqueda valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //VAMOS A CONVERTIR EL IMPORTE EN DECIMAL, SACANDO LOS CARACTERES ESPECIALES COMO EL $ Y EL ESPACIO
            decimal Importe = Convert.ToDecimal(textBoxTotalFactura.Text.Replace("$", ""));

            //AHORA, VAMOS A EMITIR LA FACTURA Y VAMOS A LIMPIAR TODOS LOS CAMPOS
            if (modelo.GenerarFactura(Convert.ToInt64(textBoxCuilCliente.Text), Importe))
            {
                MessageBox.Show("Factura emitida con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Vamos a hacer que se borren los items del listview y el total
                PedidosAFacturarListView.Items.Clear();
                textBoxTotalFactura.Clear();
                textBoxCuilCliente.Clear();
            }
            /* NO ESTA EN EL SECUENCIA, CAPAZ LO PUEDO OMITIR 
             * else
            {
                MessageBox.Show("Error al emitir la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
              "Gracias",
              "Gracias por usar el sistema",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);

            this.Close();
        }
    }
}
