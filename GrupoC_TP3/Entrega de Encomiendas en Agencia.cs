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
    public partial class EncomiendasARetirar : Form
    {
        public EncomiendasARetirar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumeroDeGuia.Text))
            {
                MessageBox.Show("ERROR 1");
                return;
            }

            if (!int.TryParse(textBoxNumeroDeGuia.Text, out int numeroGuia))
            {
                MessageBox.Show("ERROR");
                return;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if (listViewEncomiendasARetirarAgencia.SelectedItems.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado una encomienda para imprimir la hoja de retiro. Por favor seleccione una y vuelva a intentar.");
                return;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
    