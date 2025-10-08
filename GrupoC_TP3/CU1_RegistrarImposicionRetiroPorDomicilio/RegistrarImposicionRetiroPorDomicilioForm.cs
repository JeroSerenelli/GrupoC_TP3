using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;
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

        private object provinciasLocalidades; // por sugerencia del debugger
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
            cmbBoxProvRetiro.SelectedIndex = -1;
            cmbBoxLocalidadRetiro.SelectedIndex = -1;
            cmbBoxLocalidadRetiro.Enabled = false; // hasata que no elija la provincia de destino




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

            if (!int.TryParse(limpio, out int salida)) // Lvl 1 & 2 - Valido que sean numeros y que contenga 11 digitos
            {
                MessageBox.Show("El valor ingresado no es un numero. Ingrese su CUIT/CUIL (Ej:'23-34512120-6').", "CUIT/CUIL Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (limpio.Length != 11)
            //{
            //    MessageBox.Show("Ingrese un CUIT/CUIL valido. Debe user el formato '23-34512120-6'.", "CUIT/CUIL Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


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


            // Val - Domicilio
            if (string.IsNullOrEmpty(textBoxDomicilioDestinatario.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese el domicilio del destinatario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            // Val - Domicilio de Retiro
            if (string.IsNullOrEmpty(textBoxDomicilioRetiro.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese el domicilio de retiro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Datos Destinatario
            // Val - Nombre
            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese el nombre del destinatario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Apellido
            if (string.IsNullOrEmpty(textBoxApellidoDestinatario.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese el apellido del destinatario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - DNI
            if (string.IsNullOrEmpty(textBoxDNIDestinatario.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            /*FORMULARIO: Valida TIPO y el rango de ser necesario.*/




            //var nuevaEncomienda = new EncomiendasImpuestas
            //{

            //};

            //RegistrarImposicionRetiroPorDomicilioModel.ImponerEncomienda(nuevaEncomienda);

        }



        private void cmbBoxProvDst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string provinciaSeleccionada = cmbBoxProvDst.Text;

            // Limpiar combo de localidad
            cmbBoxLocalidadRetiro.DataSource = null;

            if (ubicacion.ProvinciasYLocalidades.ContainsKey(provinciaSeleccionada))
            {
                cmbBoxLocalidadRetiro.Enabled = true;
                cmbBoxLocalidadRetiro.DataSource = ubicacion.ProvinciasYLocalidades[provinciaSeleccionada];
            }

        }

        private void cmbBoxProvRetiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string provinciaSeleccionada = cmbBoxProvRetiro.Text;

            // Limpiar combo de localidad
            cmbBoxLocalidadRetiro.DataSource = null;

            if (ubicacion.ProvinciasYLocalidades.ContainsKey(provinciaSeleccionada))
            {
                cmbBoxLocalidadRetiro.Enabled = true;
                cmbBoxLocalidadRetiro.DataSource = ubicacion.ProvinciasYLocalidades[provinciaSeleccionada];
            }
        }

        private void textBoxCpRetiro_TextChanged(object sender, EventArgs e)
        {
            //Obtengo CD Origen
            string codigoPostal1 = textBoxCpRetiro.Text.Trim();
            Ubicacion ubicacion1 = new Ubicacion();
            string centro1 = ubicacion.ObtenerCentroDistribucion(codigoPostal1);
            labelCdOrigen.Text = centro1;
        }


        private void textBoxCodPostDestino_TextChanged(object sender, EventArgs e)
        {
            //Obtengo CD Destino
            string codigoPostal = textBoxCpRetiro.Text.Trim();
            Ubicacion ubicacion = new Ubicacion();
            string centro = ubicacion.ObtenerCentroDistribucion(codigoPostal);
            labelCdDestino.Text = centro;


        }



        private void comboBoxMetodoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoEntrega.Text == "Retiro en CD Destino")
            {
                labelDomicilioDestino.Visible = false;
                textBoxDomicilioDestinatario.Visible = false;

            }
            else
            {
                labelDomicilioDestino.Visible = true;
                textBoxDomicilioDestinatario.Visible = true;
            }



        }

        private void ValidarCUIT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text))
            {
                MessageBox.Show("Ingrese un CUIT/CUIL de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxCUITCUIL.Text, out int clienteValido))
            {
                MessageBox.Show("El CUIT/CUIL ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modelo.Clientes(new Clientes
            {
                CUITCUIL = clienteValido,
            });

            buttonGenerarNumeroGuia.Enabled = true;
        }
    }
}
    