using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.RegistrarImposicionEnAgencia
{
    public partial class RegistrarImposicionEnAgenciaForm : Form
    {
        public RegistrarImposicionEnAgenciaForm()
        {
            InitializeComponent();
        }

        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text))
            {
                MessageBox.Show("El campo Nombre Solicitante no debe estar vacio. Por favor revise e intente de nuevo.");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
