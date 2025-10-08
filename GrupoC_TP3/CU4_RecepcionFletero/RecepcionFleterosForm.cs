using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU4_RecepcionFletero
{
    public partial class RecepcionFleterosForm : Form
    {
        public RecepcionFleterosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBuscarFleteroClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxFletero.Text))
            {
                MessageBox.Show("Debe seleccionar o escribir un fletero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void buttonImprimirDetalleClick(object sender, EventArgs e)
        {
            if (listViewHojasDeRutaAsignadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una Hoja de Ruta asignada para imprimir.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void buttonAsignarHojaDeRutaClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxFletero.Text))
            {
                MessageBox.Show("Debe seleccionar un fletero antes de asignar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listViewAsignarHojaDeRuta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una Hoja de Ruta para asignar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void buttonAceptarRecepcionClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxFletero.Text))
            {
                MessageBox.Show("Debe seleccionar un fletero antes de aceptar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listViewHojasDeRutaAsignadas.Items.Count == 0)
            {
                MessageBox.Show("Debe haber al menos una Hoja de Ruta asignada antes de aceptar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
