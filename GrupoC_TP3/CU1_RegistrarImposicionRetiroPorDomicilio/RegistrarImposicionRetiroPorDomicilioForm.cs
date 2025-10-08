using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.Entrega_de_Encomiendas_en_Agencia;
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
        private RegistrarImposicionRetiroPorDomicilioModel modelo = new();

        //private object provinciasLocalidades; // por sugerencia del debugger
        private Ubicacion ubicacion;


        public RegistrarImposicionRetiroPorDomicilioForm()
        {
            InitializeComponent();

            ubicacion = new Ubicacion();
            cmbBoxProvDst.DataSource = ubicacion.ProvinciasYLocalidades.Keys.ToList();
            cmbBoxProvDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.Enabled = false; // hasata que no elija la provincia de destino

            cmbBoxProvRetiro.DataSource = ubicacion.ProvinciasYLocalidades.Keys.ToList();
            cmbBoxProvRetiro.



            labelCdDestino.Text = "TBD";

            string cpDestino = textBoxCodPostDestino.Text;

            if (CodigoPostalCentroDistribucion.TryGetValue(cpDestino, out string centro))
            {
                labelCdDestino.Text = centro;
            }




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


            //Informacion Destino
            // Val - Provincia
            if (string.IsNullOrEmpty(cmbBoxProvDst.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //E01 
                return;
            }

            // Val - Localidad
            if (string.IsNullOrEmpty(cmbBoxLocalidadDst.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //E01
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

            //Datos Encomienda
            // Val - Cant. Cajas
            ////// Que pasa si estamos mandando varias cajas, es deir 1 de tipo S, 2 tipo M, etc.?? 

            if (string.IsNullOrEmpty(textBoxCantidadCajas.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese la cantidad de cajas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxCantidadCajas.Text, out int cajas)) //Lvl 1
            {
                MessageBox.Show("Debe ingresar un número en el campo 'Cantidad de Cajas'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Val - Tipo de Caja 
            if (string.IsNullOrEmpty(comboBoxTipoCaja.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione el tipo de caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Datos Retiro

            // Val - Provincia
            if (string.IsNullOrEmpty(cmbBoxProvRetiro.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Localidad
            if (string.IsNullOrEmpty(cmbBoxLocalidadRetiro.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Codigo Postal
            if (string.IsNullOrEmpty(textBoxCpRetiro.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un código postal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(textBoxCpRetiro.Text, out int cpRetiro)) //Lvl 1
            {
                MessageBox.Show("El codigo postal ingresado no es un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Val - CD Origen
            if (string.IsNullOrEmpty(textBoxCDOrigen.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un centro de distribucion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Domicilio
            if (string.IsNullOrEmpty(textBoxDomicilioRetiro.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una Provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Codigo Postal
            if (string.IsNullOrEmpty(textBoxDomicilioRetiro.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una Provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            /*FORMULARIO: Valida TIPO y el rango de ser necesario.*/

            var nuevaEncomienda = new EncomiendasImpuestas
            {

            };

            //RegistrarImposicionRetiroPorDomicilioModel.ImponerEncomienda(nuevaEncomienda);

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

        private void cmbBoxProvRetiro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
