using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio.ProvinciaLocalidades;

namespace GrupoC_TP3.RegistrarImposicionRetiroPorDomicilio
{
    public partial class RegistrarImposicionRetiroPorDomicilioForm : Form
    {
        //private object provinciasLocalidades; // por sugerencia del debugger
        private Ubicacion ubicacion;

        public RegistrarImposicionRetiroPorDomicilioForm()
        {
            InitializeComponent();

            ubicacion = new Ubicacion();
            cmbBoxProvDst.DataSource = ubicacion.ProvinciasYLocalidades.Keys.ToList();
            cmbBoxProvDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.Enabled = false; // hasata que no elija la provincia
            //cmbBoxProvDst.SelectedIndexChanged += cmbBoxLocalidadDst_SelectedIndexChanged;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDestinoEncomienda_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonNuevaSolicitudLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {
            //Validaciones
            // CUIT/CUIL

            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text)) //Lvl 0
            {
                MessageBox.Show("El campo CUIT/CUIL no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string limpio = textBoxCUITCUIL.Text.Replace("-", "");

            if (limpio.Length != 11 || limpio.All(char.IsDigit)) // Lvl 1 & 2 - Valido que sean numeros y que contenga 11 digitos
            {
                MessageBox.Show("Ingrese un CUIT/CUIL valido. Debe user el formato '23-34512120-6'.", "CUIT/CUIL Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Provincia
            if (string.IsNullOrEmpty(cmbBoxProvDst.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Localidad
            if (string.IsNullOrEmpty(cmbBoxLocalidadDst.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Metodo Entrega
            if (string.IsNullOrEmpty(comboBoxMetodoEntrega.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione un método de entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Codigo Postal
            if (string.IsNullOrEmpty(textBoxCodPostDestino.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un código postal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(textBoxCodPostDestino.Text, out int cpDestino)) //Lvl 1
            {
                MessageBox.Show("El codigo postal ingresado no es un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Val - Domicilio
            if (string.IsNullOrEmpty(textBoxDomicilioDestinatario.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una Provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Codigo Postal
            if (string.IsNullOrEmpty(textBoxDomicilioDestinatario.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una Provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Cant. Cajas
            // Que pasa si estamos mandando varias cajas, es deir 1 de tipo S, 2 tipo M, etc.?? 

            if (string.IsNullOrEmpty(textBoxCantidadCajas.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese la cantidad de cajas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





        }

        

        private void cmbBoxProvDst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string provinciaSeleccionada = cmbBoxProvDst.Text;

            // Limpiar combo de localidad
            cmbBoxLocalidadDst.DataSource = null;

            if (ubicacion.ProvinciasYLocalidades.ContainsKey(provinciaSeleccionada))
            {
                cmbBoxLocalidadDst.Enabled = true;
                cmbBoxLocalidadDst.DataSource = ubicacion.ProvinciasYLocalidades[provinciaSeleccionada];
            }

        }
    }
}
