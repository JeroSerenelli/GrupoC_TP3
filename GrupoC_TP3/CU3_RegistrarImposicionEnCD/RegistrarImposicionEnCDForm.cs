using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC_TP3.CU3_RegistrarImposicionEnCD
{
    public partial class RegistrarImposicionEnCDForm : Form
    {
        private readonly RegistrarImposicionEnCDFormModel modelo = new();

        //private Ubicacion ubicacion;
        public RegistrarImposicionEnCDForm()
        {
            InitializeComponent();

            //Desactivo la escritura en los combo box
            cmbBoxProvDst.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxLocalidadDst.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxMetodoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxTipoCaja.DropDownStyle = ComboBoxStyle.DropDownList;

            var ubicacion = modelo.ObtenerUbicacion();
            cmbBoxProvDst.DataSource = ubicacion.ProvinciasYLocalidades.Keys.ToList();
            cmbBoxProvDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.Enabled = false; // hasata que no elija la provincia de destino
            cmbBoxLocalidadDst.DropDownStyle = ComboBoxStyle.DropDownList;
            //aca voy a bloquear el combo de provincia para que no se pueda escribir
            cmbBoxProvDst.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMetodoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoCaja.DropDownStyle = ComboBoxStyle.DropDownList;


        }


        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {
            buttonGenerarNumeroGuia.Enabled = false;

            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un CUIT/CUIL de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string limpio = textBoxCUITCUIL.Text.Replace("-", "");

            if (!long.TryParse(limpio, out long validarCliente)) //Lvl 1
            {
                MessageBox.Show("El CUIT/CUIL ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCUITCUIL.Focus();
                return;
            }

            buttonGenerarNumeroGuia.Enabled = true;

            
            if (string.IsNullOrEmpty(cmbBoxProvDst.Text))
            {
                MessageBox.Show("Seleccione una Provincia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBoxProvDst.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbBoxLocalidadDst.Text))
            {
                MessageBox.Show("Seleccione una Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBoxLocalidadDst.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(comboBoxMetodoEntrega.Text))
            {
                MessageBox.Show("Seleccione un metodo de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxMetodoEntrega.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxCodPostDestino.Text))
            {
                MessageBox.Show("Ingrese un Codigo Postal numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCodPostDestino.Focus();
                return;
            }

            if (comboBoxMetodoEntrega.Text == "Entrega en Domicilio")
            {
                if (string.IsNullOrEmpty(textBoxDomicilioDestinatario.Text))
                {
                    MessageBox.Show("Seleccione un domicilio de destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxDomicilioDestinatario.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(textBoxCantidadCajas.Text))
            {
                MessageBox.Show("Seleccione una cantidad de cajas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantidadCajas.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comboBoxTipoCaja.Text))
            {
                MessageBox.Show("Seleccione un tipo de caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxTipoCaja.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text))
            {
                MessageBox.Show("Seleccione el nombre del destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombreDestinatario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxApellidoDestinatario.Text))
            {
                MessageBox.Show("Seleccione el apellido del destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxApellidoDestinatario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxDNIDestinatario.Text))
            {
                MessageBox.Show("Ingrese el DNI del destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDNIDestinatario.Focus();
                return;
            }

            if (!int.TryParse(textBoxCodPostDestino.Text, out int codigoPostalDestino))
            {
                MessageBox.Show("El Codigo Postal ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCodPostDestino.Focus();
                return;
            }
            if (labelCdDestino.Text == "Centro de distribución no encontrado") //Lvl 2?
            {
                MessageBox.Show("No existe un centro de distribucion para el CP ingresado. Ingrese otro codigo postal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelCdDestino.Focus();
                return;
            }
            if (!int.TryParse(textBoxCantidadCajas.Text, out int cantidadCajas))
            {
                MessageBox.Show("La cantidad de cajas ingresadas es invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantidadCajas.Focus();
                return;
            }

            if (cantidadCajas <= 0)
            {
                MessageBox.Show("La cantidad de cajas ingresadas es invalida, debe ser al menos 1 caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantidadCajas.Focus();   
                return;
            }

            if (!int.TryParse(textBoxDNIDestinatario.Text, out int dniDestinatario))
            {
                MessageBox.Show("El DNI del destinatario ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDNIDestinatario.Focus(); 
                return;
            }

        

            modelo.CrearEncomienda(new Encomienda
            {
                Cliente = validarCliente,
                Provincia = cmbBoxProvDst.Text,
                Localidad = cmbBoxLocalidadDst.Text,
                MetodoEntrega = comboBoxMetodoEntrega.Text,
                CodigoPostal = codigoPostalDestino,
                CentroDistribucionDestino = labelCdDestino.Text,
                Domicilio = textBoxDomicilioDestinatario.Text,
                CantidadCajas = cantidadCajas,
                TipoCaja = comboBoxTipoCaja.Text,
                NombreDestinatario = textBoxNombreDestinatario.Text,
                ApellidoDestinatario = textBoxApellidoDestinatario.Text,
                DNI = dniDestinatario,
                CodigoAgencia = int.Parse(textBoxCodigoAgencia.Text),
                
            });


        }


        private void textBoxCodPostDestino_TextChanged(object sender, EventArgs e)
        {
            //Obtengo CD Destino
            string codigoPostal = textBoxCodPostDestino.Text.Trim();
            // textBoxCodPostDestino
            var ubicacion = modelo.ObtenerUbicacion();
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

     

        private void buttonValidarCuil_Click(object sender, EventArgs e)
        {
            // Validacion - CUIT/CUIL
            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un CUIT/CUIL de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string limpio = textBoxCUITCUIL.Text.Replace("-", "");

            if (!long.TryParse(limpio, out long validarCliente)) //Lvl 1
            {
                MessageBox.Show("El CUIT/CUIL ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCUITCUIL.Focus();
                return;
            }

            modelo.ValidarCl(new ClienteImposicionCD
            {
                CUITCUIL = validarCliente,
            });

            buttonGenerarNumeroGuia.Enabled = true;
        }

        private void cmbBoxProvDst_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string provinciaSeleccionada = cmbBoxProvDst.Text;

            // Limpiar combo de localidad
            cmbBoxLocalidadDst.DataSource = null;

            var ubicacion = modelo.ObtenerUbicacion();
            if (ubicacion.ProvinciasYLocalidades.ContainsKey(provinciaSeleccionada))
            {
                cmbBoxLocalidadDst.Enabled = true;
                cmbBoxLocalidadDst.DataSource = ubicacion.ProvinciasYLocalidades[provinciaSeleccionada];
            }
        }

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
    }
}
