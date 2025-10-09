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

namespace GrupoC_TP3.CU8_EmisionFacturas
{
    public partial class EmisionFacturasForm : Form

    {
        //private  EmisionFacturasForm modelo = new();


        private EmisionFacturasModel Facturas = new();


        public EmisionFacturasForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cuentaCorrienteLstView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmisionFacturas_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscarCuilCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCuilCliente.Text))
            {
                MessageBox.Show("Para realizar una busqueda, ingrese un CUIL/CUIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Con esto hacemos que se quede en esta parte
                textBoxCuilCliente.Focus();
                return;
            }
            // Validar que el CUIL/CUIT sea un numero valido
            if (!long.TryParse(textBoxCuilCliente.Text, out long cuilCliente))
            {
                MessageBox.Show("El CUIT/CUIL es un campo numerico, por favor remueva letras y caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Con esto hacemos que se quede en esta parte
                textBoxCuilCliente.Focus();
                return;
            }
            //Validamos que el cuil sea de 11 digitos
            if (textBoxCuilCliente.Text.Length != 11)
            {
                MessageBox.Show("El CUIL/CUIT debe tener 11 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Con esto hacemos que se quede en esta parte
                textBoxCuilCliente.Focus();
                return;
            }

            // Corrección: Iterar sobre la lista de facturas del modelo y mostrarlo en el ListView
            PedidosAFacturarListView.Items.Clear();
            foreach (var factura in Facturas.Fac)
            {
                var listItem = new ListViewItem();
                listItem.Text = factura.NroGuia.ToString();
                listItem.SubItems.Add(factura.SubTotal.ToString("C")); // Formatear como moneda
                PedidosAFacturarListView.Items.Add(listItem);
            }

            //Ahora vamos a sumar los subtotales y mostrar el total en el textbox
            decimal totalFactura = Facturas.Fac.Sum(f => f.SubTotal);
            textBoxTotalFactura.Text = totalFactura.ToString("C"); // Formatear como moneda

        }

        private void buttonEmitirFactura_Click(object sender, EventArgs e)
        {
            //Vamos a emitir la factura si hay items en el listview
            if (PedidosAFacturarListView.Items.Count == 0)
            {
                MessageBox.Show("No hay pedidos para facturar, por favor realice una busqueda valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Factura emitida con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
