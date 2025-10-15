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
            PedidosAFacturarListView.Items.Clear();

            if (string.IsNullOrEmpty(textBoxCuilCliente.Text))
            {
                MessageBox.Show("Para realizar una busqueda, ingrese un CUIL/CUIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Con esto hacemos que se quede en esta parte
                textBoxCuilCliente.Focus();
                return;
            }
            if (!long.TryParse(textBoxCuilCliente.Text, out long salida))
            {
                MessageBox.Show("El numero de CUIT/CUIL ingresado es invalido, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Con esto hacemos que se quede en esta parte
                textBoxCuilCliente.Focus();
                return;
            }

            modelo.ValidacionCuil(new Factura
            {
                Cuil = salida,
            });



            //Cualquier NUMERO DE CUIL VALIDO va a traer los mismos datos de prueba
            // Corrección: Iterar sobre la lista de facturas del modelo y mostrarlo en el ListView

            foreach (var CuilValido in modelo.CuilValido)
            {
                if (CuilValido.Cuil == salida)
                {
                    var listItem = new ListViewItem();
                    listItem.Text = CuilValido.NroGuia.ToString();
                    listItem.SubItems.Add(CuilValido.SubTotal.ToString("C")); // Formatear como moneda
                    listItem.Tag = CuilValido; // Guardamos el objeto para usarlo luego
                    PedidosAFacturarListView.Items.Add(listItem);
                }

            }

            //Ahora vamos a sumar los subtotales de los indices que trae, no el total de la lista
            var totalFactura = modelo.CuilValido.Where(f => f.Cuil == salida).Sum(f => f.SubTotal);
            textBoxTotalFactura.Text = totalFactura.ToString("C"); // Formatear como moneda

            /*
            //Ahora vamos a sumar los subtotales y mostrar el total en el textbox
            decimal totalFactura = modelo.CuilValido.Sum(f => f.SubTotal);
            textBoxTotalFactura.Text = totalFactura.ToString("C"); // Formatear como moneda
            */
        }

        private void buttonEmitirFactura_Click(object sender, EventArgs e)
        {
            var seleccionadas = PedidosAFacturarListView.Items.Cast<ListViewItem>().ToList();
            //Vamos a emitir la factura si hay items en el listview
            /*if (PedidosAFacturarListView.Items.Count > 0)
            {
                var GuiasAEmitir = seleccionadas.Select(item => item.Text).ToList();
            }
            */

            if (PedidosAFacturarListView.Items.Count == 0)
            {
                MessageBox.Show("No hay pedidos para facturar, por favor realice una busqueda valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Factura emitida con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Vamos a hacer que se borren los items del listview y el total
            PedidosAFacturarListView.Items.Clear();
            textBoxTotalFactura.Clear();
            textBoxCuilCliente.Clear();
        }

        private void PedidosAFacturarListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
              "Gracias",
              "Gracias por usar el sistema",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
          );

            this.Close();
        }
    }
}
