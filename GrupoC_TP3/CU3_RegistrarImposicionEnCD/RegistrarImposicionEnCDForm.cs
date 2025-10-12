using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrupoC_TP3.CU3_RegistrarImposicionEnCD.ProvinciasLocalidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC_TP3.CU3_RegistrarImposicionEnCD
{
    public partial class RegistrarImposicionEnCDForm : Form
    {

        private readonly RegistrarImposicionEnCDFormModel modelo = new();
        private Ubicacion ubicacion;



        public RegistrarImposicionEnCDForm()
        {
            InitializeComponent();
            ubicacion = new Ubicacion();
            cmbBoxProvDst.DataSource = ubicacion.ProvinciasYLocalidades.Keys.ToList();
            cmbBoxProvDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.Enabled = false; // hasata que no elija la provincia de destino
        }







        // ACA HACEMOS QUE EL BOTON VALIDE
        private void buttonValidarCuil_Click_1(object sender, EventArgs e)
        {
            Validar();
        }




        //ACA PODEMOS VER DE AGREGAR LA LISTA Y VINCULARLAS




        //ACA ESTA EL BOTON PARA ACEPTAR LA IMPOSICION 
        private void buttonNuevaSolicitudLimpiar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "Gracias",
                "Gracias por usar el sistema.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        //ACA ESTAN TODAS LAS VALIDACIONES DE LOS CAMPOS
        private void Validar()
        {

            //NIVEL 0= Validamos que el cuil no sea nulo
            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text))
            {
                MessageBox.Show("El campo CUIT/CUIL no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCUITCUIL.Focus();
                return;
            }
            //VALIDAMOS QUE TENGA SOLO NUMEROS
            if (!textBoxCUITCUIL.Text.ToString().All(char.IsDigit))
            {
                MessageBox.Show("El campo CUIT/CUIL debe contener solo numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCUITCUIL.Focus();
                return;
            }

            //var Cuil = long.Parse(textBoxCUITCUIL.Text);
            /* //VALIDAMOS QUE SEA ENTERO Y QUE TENGA 11 DIGITOS
             if (!int.TryParse(textBoxCUITCUIL.Text, out int Cuil))
             {
                 MessageBox.Show("El campo CUIT/CUIL debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }*/
            //VALIDAMOS QUE TENGA 11 DIGITOS
            if (textBoxCUITCUIL.Text.Length != 11)
            {
                MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //VALIDAMOS QUE SEA POSITIVO
            var Cuil = long.Parse(textBoxCUITCUIL.Text);
            if (Cuil <= 0)
            {
                MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MOSTRAMOS UN MENSJAE DE VALIDACION CORRECTA
            //MessageBox.Show("CUIT/CUIL valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void ValidarCodigoPostal() // Queda desafectado
        {
            //Codigo Postal
            if (string.IsNullOrEmpty(textBoxCodPostDestino.Text))
            {
                MessageBox.Show("El campo Codigo Postal no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Para que se mantenga en la celda
                textBoxCodPostDestino.Focus();
                return;

            }
            if (!int.TryParse(textBoxCodPostDestino.Text, out int CodigoPostal))
            {
                MessageBox.Show("El campo Codigo Postal debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCodPostDestino.Focus();
                return;
            }
            //VALIDAMOS QUE TENGA 4 DIGITOS
            if (CodigoPostal.ToString().Length != 4)
            {
                MessageBox.Show("El campo Codigo Postal debe tener 4 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCodPostDestino.Focus();
                return;
            }
            //VALIDAMOS QUE SEA POSITIVO
            if (CodigoPostal <= 0)
            {
                MessageBox.Show("El campo Codigo Postal debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCodPostDestino.Focus();
                return;
            }
            //MOSTRAMOS UN MENSJAE DE VALIDACION CORRECTA
            MessageBox.Show("Codigo Postal valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ValidarDomicilio()
        {
            //Domicilio
            if (string.IsNullOrEmpty(textBoxDomicilioDestinatario.Text))
            {
                MessageBox.Show("El campo Domicilio no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDomicilioDestinatario.Focus();
                return;
            }
            //MOSTRAMOS UN MENSJAE DE VALIDACION CORRECTA
            /*MessageBox.Show("Domicilio valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }
        //Faltaria Validar el Tema cantidad de CAJAS

        private void ValidarNombreDestinanario()
        {
            //Nombre destinatario
            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text))
            {
                MessageBox.Show("El campo Nombre Destinatario no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombreDestinatario.Focus();
                return;
            }
            //VALIDAMOS QUE TENGA SOLO LETRAS
            if (!textBoxNombreDestinatario.Text.ToString().All(char.IsLetter))
            {
                MessageBox.Show("El campo Nombre Destinatario debe contener solo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombreDestinatario.Focus();

                return;
            }
            //MOSTRAMOS UN MENSJAE DE VALIDACION CORRECTA
            // MessageBox.Show("Nombre Destinatario valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ValidarApellidoDestinatario()
        {
            //Apellido destinatario
            if (string.IsNullOrEmpty(textBoxApellidoDestinatario.Text))
            {
                MessageBox.Show("El campo Apellido Destinatario no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxApellidoDestinatario.Focus();
                return;
            }
            //VALIDAMOS QUE TENGA SOLO LETRAS
            if (!textBoxApellidoDestinatario.Text.ToString().All(char.IsLetter))
            {
                MessageBox.Show("El campo Apellido Destinatario debe contener solo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxApellidoDestinatario.Focus();
                return;
            }
            //MOSTRAMOS UN MENSJAE DE VALIDACION CORRECTA
            //MessageBox.Show("Apellido Destinatario valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ValidarDNI()
        {
            //DNI
            //NO SEA NULO
            if (string.IsNullOrEmpty(textBoxDNIDestinatario.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDNIDestinatario.Focus();
                return;
            }
            //SEA UN NUMERO ENTERO
            if (!int.TryParse(textBoxDNIDestinatario.Text, out int DNI))
            {
                MessageBox.Show("El campo DNI debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDNIDestinatario.Focus();
                return;
            }
            //SEA POSITIVO
            if (DNI <= 0)
            {
                MessageBox.Show("El campo DNI debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDNIDestinatario.Focus();
                return;
            }
            //SEA DE 8 DIGITOS
            if (DNI.ToString().Length != 8)
            {
                MessageBox.Show("El campo DNI debe tener 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDNIDestinatario.Focus();
                return;
            }
            //valide el dni con numeros y no con letras
            if (!DNI.ToString().All(char.IsDigit))
            {
                MessageBox.Show("El campo DNI debe contener solo numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDNIDestinatario.Focus();
                return;
            }
            //MOSTRAMOS UN MENSJAE DE VALIDACION CORRECTA
            //MessageBox.Show("DNI valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* private void textBoxCodPostDestino_Leave(object sender, EventArgs e)
         {
             ValidarCodigoPostal();
         }*/


        //HAGO QUE ME VALIDE EL CODIGO POSTAL CUANDO SALGO DE LA CELDA
        private void textBoxCodPostDestino_Leave_1(object sender, EventArgs e)
        {
            //ValidarCodigoPostal();
        }


        //HAGO QUE ME VALIDE EL CD DESTINO CUANDO SALGO DE LA CELDA


        //hAGO QUE ME VALIDE EL DOMICILIO CUANDO SALGO DE LA CELDA 
        private void textBoxDomicilioDestinatario_Leave(object sender, EventArgs e)
        {
            ValidarDomicilio();
        }

        //HAGO QUE ME VALIDE EL NOMBRE DEL DESTINATARIO CUANDO SALGO DE LA CELDA

        private void textBoxNombreDestinatario_Leave(object sender, EventArgs e)
        {
            ValidarNombreDestinanario();
        }

        //HAGO QUE ME VALIDE EL APELLIDO DEL DESTINATARIO CUANDO SALGO DE LA CELDA
        private void textBoxApellidoDestinatario_Leave(object sender, EventArgs e)
        {
            ValidarApellidoDestinatario();
        }

        //HAGO QUE ME VALIDE EL DNI DEL DESTINATARIO CUANDO SALGO DE LA CELDA
        private void textBoxDNIDestinatario_Leave(object sender, EventArgs e)
        {
            ValidarDNI();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBoxMetodoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoEntrega.Text == "Retiro en CD Destino")
            {
                labelDomicilioDestino.Visible = false;
                textBoxDomicilioDestinatario.Visible = false;

            }
            else if (comboBoxMetodoEntrega.Text == "Retiro en Agencia")
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

        private void textBoxCodPostDestino_TextChanged(object sender, EventArgs e)
        {
            //Obtengo CD Destino
            string codigoPostal = textBoxCodPostDestino.Text.Trim();

            Ubicacion ubicacion = new Ubicacion();
            string centro = ubicacion.ObtenerCentroDistribucion(codigoPostal);
            labelCdDestino.Text = centro;
        }

        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {

        }
    }
}
