using GrupoC_TP3.CU2_CuentaCorriente;
using GrupoC_TP3.CU4_RegistrarImposicionEnAgencia;
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
            //Validaciones Datos Solicitante 
            //Validaciones Nombre Solicitante
            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text))
            {
                // JFS. Agregar Nro de Alerta (tiene que estar tmb en caso de uso)

                MessageBox.Show("El campo Nombre Solicitante no debe estar vacio. Por favor revise e intente de nuevo.");
                return;
            }
            ;



            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text))
            {
                // JFS. Agregar Nro de Alerta (tiene que estar tmb en caso de uso)

                MessageBox.Show("El campo Nombre Solicitante no debe estar vacio. Por favor revise e intente de nuevo.");
                return;
            }
            ;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreSolicitante_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDomicilioDestinatario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNuevaSolicitudLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
