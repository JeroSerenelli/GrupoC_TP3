using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU9_RegistrarImposicionEnCD
{
    public partial class RegistrarImposicionEnCDForm : Form
    {
        public RegistrarImposicionEnCDForm()
        {
            InitializeComponent();
        }

        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text));
            {
                MessageBox.Show("El campo" + textBoxNombreDestinatario.Text + " no debe estar vacio. Por favor revise e intente de nuevo.");
                return;
            }
        }
    }
}
