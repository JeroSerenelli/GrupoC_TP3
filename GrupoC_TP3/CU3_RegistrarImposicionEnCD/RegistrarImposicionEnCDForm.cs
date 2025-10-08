using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU3_RegistrarImposicionEnCD
{
    public partial class RegistrarImposicionEnCDForm : Form
    {

        private readonly RegistrarImposicionEnCDFormModel modelo = new();


        public RegistrarImposicionEnCDForm()
        {
            InitializeComponent();
        }



        private void Validar()
        {

            //NIVEL 0= Validamos que el cuil no sea nulo
            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text))
            {
                MessageBox.Show("El campo CUIT/CUIL no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Cuil = long.Parse(textBoxCUITCUIL.Text);
            /* //VALIDAMOS QUE SEA ENTERO Y QUE TENGA 11 DIGITOS
             if (!int.TryParse(textBoxCUITCUIL.Text, out int Cuil))
             {
                 MessageBox.Show("El campo CUIT/CUIL debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }*/
            //VALIDAMOS QUE TENGA 11 DIGITOS
            if (Cuil.ToString().Length != 11)
            {
                MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //VALIDAMOS QUE SEA POSITIVO
            if (Cuil <= 0)
            {
                MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //VALIDAMOS QUE TENGA SOLO NUMEROS
            if (!Cuil.ToString().All(char.IsDigit))
            {
                MessageBox.Show("El campo CUIT/CUIL debe contener solo numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MOSTRAMOS UN MENSJAE DE VALIDACION CORRECTA
            MessageBox.Show("CUIT/CUIL valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void buttonValidarCuil_click(object sender, EventArgs e)
        {


        }
        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {


            //Codigo Postal

            if (string.IsNullOrEmpty(textBoxCodPostDestino.Text))
            {
                MessageBox.Show("El campo Codigo Postal no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxCodPostDestino.Text, out int CodigoPostal))
            {
                MessageBox.Show("El campo Codigo Postal debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //CD Destino 
            var CDDestino = textBoxCDDestino.Text;

            if (string.IsNullOrEmpty(CDDestino))
            {
                MessageBox.Show("El campo CD Destino no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Domicilio
            if (string.IsNullOrEmpty(textBoxDomicilioDestinatario.Text))
            {
                MessageBox.Show("El campo Domicilio no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Cantidad de cajas

            //Nombre destinatario
            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text))
            {
                MessageBox.Show("El campo Nombre Destinatario no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Apellido destinatario
            if (string.IsNullOrEmpty(textBoxApellidoDestinatario.Text))
            {
                MessageBox.Show("El campo Apellido Destinatario no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //DNI
            //NO SEA NULO
            if (string.IsNullOrEmpty(textBoxDNIDestinatario.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //SEA UN NUMERO ENTERO
            if (!int.TryParse(textBoxDNIDestinatario.Text, out int DNI))
            {
                MessageBox.Show("El campo DNI debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //SEA POSITIVO
            if (DNI <= 0)
            {
                MessageBox.Show("El campo DNI debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //SEA DE 8 DIGITOS
            if (DNI.ToString().Length != 8)
            {
                MessageBox.Show("El campo DNI debe tener 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //valide el dni con numeros y no con letras
            if (!DNI.ToString().All(char.IsDigit))
            {
                MessageBox.Show("El campo DNI debe contener solo numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void buttonValidarCuil_Click_1(object sender, EventArgs e)
        {
            Validar();
        }

        private void buttonNuevaSolicitudLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarImposicionEnCDForm_Load(object sender, EventArgs e)
        {
            ///carga inicial del form
            comboBox1.Items.Add("Cordoba");
            comboBox1.Items.Add("Mendoza");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            var Eleccion = comboBox1.GetItemText(item: comboBox1.SelectedItem);

            switch
                (Eleccion)
            {
                case "Cordoba":
                    comboBox2.Items.Add("Villa Maria");
                    break;
                case "Mendoza":
                    comboBox2.Items.Add("San Rafael");
                    break;
                case "pedro":
                    textBoxCUITCUIL.Text = "20304050609";
                    break;
                default:
                    break;
            }
        }
    }
}
