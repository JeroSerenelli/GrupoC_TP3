using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using GrupoC_TP3.Entrega_de_Encomiendas_en_Agencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC_TP3.CU6_EntregaEncomiendas
{
    public partial class EntregaEncomiendasForm1 : Form
    {
        private EntregaEncomiendasModel modelo = new();

        public EntregaEncomiendasForm1()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            listViewEncomiendasARetirarAgencia.Items.Clear();

            if (string.IsNullOrEmpty(textBoxDNI.Text))
            {
                MessageBox.Show("Ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxDNI.Text, out int salida))
            {
                MessageBox.Show("El numero de guia ingresado es invalido, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var Encomiendas in modelo.Encomiendas)
            {
                if (Encomiendas.Dni == salida)
                {
                    var listItem = new ListViewItem();
                    labelNombre.Text = Encomiendas.Nombre;
                    labelApellido.Text = Encomiendas.Apellido;
                    listItem.Text = Encomiendas.NroGuia.ToString();
                    listItem.SubItems.Add(Encomiendas.Estado.ToString());
                    listViewEncomiendasARetirarAgencia.Items.Add(listItem);
                }
            }



        }
    }
}
