using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3
{
    public partial class Facturas : Form
    {
        public Facturas()
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
            /*foreach (var cliente in clientes)
            {
                var listItem = new ListViewItem();
                listItem.Text = cliente.RazonSocial;
                listItem.SubItems.Items.add(cliente.CUITCUIL);
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarClienteClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxCuitCuil.Text))
            {
                MessageBox.Show("Debe ingresar o seleccionar un CUIT/CUIL.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                comboBoxCuitCuil.Text.Trim(), @"^\d{2}-\d{8}-\d$"))
            {
                MessageBox.Show("El CUIT/CUIL debe tener el formato XX-XXXXXXXX-X.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePickerFin.Value.Date < dateTimePickerInicio.Value.Date)
            {
                MessageBox.Show("La fecha de fin no puede ser menor que la fecha de inicio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
