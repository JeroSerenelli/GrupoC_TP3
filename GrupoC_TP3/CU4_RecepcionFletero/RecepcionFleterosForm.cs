using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC_TP3.CU4_RecepcionFletero
{
    public partial class RecepcionFleterosForm : Form
    {
        private RecepcionFleterosModel modelo = new();

        public HojasdeRutaAsignadas HojasdeRutaAsignadas;

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

        private void buttonBuscarFletero_Click(object sender, EventArgs e)
        {


            listViewHDRAsignadas.Items.Clear();

            if (string.IsNullOrEmpty(comboBoxFletero.Text))
            {
                MessageBox.Show("INgrese fletero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach (var HojasdeRutaAsignadas in modelo.Fleteros)
            {
                if (HojasdeRutaAsignadas.Fletero == comboBoxFletero.Text)
                {
                    var listItem = new ListViewItem();
                    listItem.Text = HojasdeRutaAsignadas.HojaDeRuta.ToString();
                    listItem.SubItems.Add(HojasdeRutaAsignadas.NroGuia.ToString());
                    listItem.SubItems.Add(HojasdeRutaAsignadas.Estado.ToString());
                    listViewHDRAsignadas.Items.Add(listItem);
                }

                /*else
                {
                    MessageBox.Show("El numero de guia ingresado no corresponde a una encomienda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //Cuando busco uno que existe, tambien aparece. 
                }*/
            }
        }

        private void buttonImprimirDetalle_Click(object sender, EventArgs e)
        {
            listViewHDRAsignadas.SelectedItems;
            MessageBox.Show($"Estos son los items seleccionados {}");
        }
    }
}
