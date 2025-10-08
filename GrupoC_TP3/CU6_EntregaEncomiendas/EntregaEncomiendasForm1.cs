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
            if(string.IsNullOrEmpty(textBoxNumeroDeGuia.Text))
            {
                //E01
                MessageBox.Show("Ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //E01 
                return;
            };



        }
    }
}
