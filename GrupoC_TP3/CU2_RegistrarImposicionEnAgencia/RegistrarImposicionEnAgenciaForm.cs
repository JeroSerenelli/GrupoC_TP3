using GrupoC_TP3.CU2_CuentaCorriente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
{
    public partial class RegistrarImposicionEnAgenciaForm : Form
    {
        private readonly RegistrarImposicionEnAgenciaModel modelo = new();
        public RegistrarImposicionEnAgenciaForm()
        {
            InitializeComponent();
        }


        /*private void RegistrarImposicionEnAgenciaForm_Load(object sender, EventArgs e)
        {
            foreach(var cliente in modelo.GenerarClientes)
            {
                Client
            }
        }*/

        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {
            modelo.CrearEncomienda(new Encomienda
            {
                Provincia = comboBoxProvincia.Text,
                NumeroGuia = long.Parse(textBoxCodigoAgencia.Text),

            });


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreSolicitante_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(textBoxCUITCUIL.Text, out long val))
            {
                MessageBox.Show("Ingreso invalido");
                return;
            }

            modelo.ValidarCliente(new ValidarCliente
            {
                CUITCUIL = val,

            });



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

        private void textBoxCUITCUIL_TextChanged_1(object sender, EventArgs e)
        {
            //string CUITCUIL = textBoxCUITCUIL.Text;

        }
    }

    }
