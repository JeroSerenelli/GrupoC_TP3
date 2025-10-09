using GrupoC_TP3.CU2_CuentaCorriente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrupoC_TP3.CU2_RegistrarImposicionEnAgencia.ProvinciaLocalidades;


namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
{
    public partial class RegistrarImposicionEnAgenciaForm : Form
    {
        private readonly RegistrarImposicionEnAgenciaModel modelo = new();
        private Ubicacion ubicacion;

        //private Ubicacion ubicacion;
        public RegistrarImposicionEnAgenciaForm()
        {
            InitializeComponent();

            ubicacion = new Ubicacion();
            cmbBoxProvDst.DataSource = ubicacion.ProvinciasYLocalidades.Keys.ToList();
            cmbBoxProvDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.SelectedIndex = -1;
            cmbBoxLocalidadDst.Enabled = false; // hasata que no elija la provincia de destino

        }


        private void RegistrarImposicionEnAgenciaForm_Load(object sender, EventArgs e)
        {
            buttonGenerarNumeroGuia.Enabled = false;
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

        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBoxLocalidadDst.Text))
            {
                MessageBox.Show("Seleccione una Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cmbBoxProvDst.Text))
            {
                MessageBox.Show("Seleccione una Provincia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxMetodoEntrega.Text))
            {
                MessageBox.Show("Seleccione un metodo de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCodPostDestino.Text))
            {
                MessageBox.Show("Ingrese un Codigo Postal numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDomicilioDestinatario.Text))
            {
                MessageBox.Show("Seleccione un domicilio de destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCantidadCajas.Text))
            {
                MessageBox.Show("Seleccione una cantidad de cajas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxTipoCaja.Text))
            {
                MessageBox.Show("Seleccione un tamaño de caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNombreDestinatario.Text))
            {
                MessageBox.Show("Seleccione el nombre del destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxApellidoDestinatario.Text))
            {
                MessageBox.Show("Seleccione el apellido del destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDNIDestinatario.Text))
            {
                MessageBox.Show("Ingrese el DNI del destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxCodPostDestino.Text, out int codigoPostalDestino))
            {
                MessageBox.Show("El Codigo Postal ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxCantidadCajas.Text, out int cantidadCajas))
            {
                MessageBox.Show("La cantidad de cajas ingresadas es invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidadCajas <= 0)
            {
                MessageBox.Show("La cantidad de cajas ingresadas es invalido, debe ser al menos 1 caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxDNIDestinatario.Text, out int dniDestinatario))
            {
                MessageBox.Show("El DNI del destinatario ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dniDestinatario < 100000 || dniDestinatario > 99999999)
            {
                MessageBox.Show("El DNI del destinatario ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (codigoPostalDestino < 1000)
            {
                MessageBox.Show("El Codigo Postal ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            modelo.CrearEncomienda(new Encomienda
            {
                Provincia = cmbBoxProvDst.Text,
                NumeroGuia = long.Parse(textBoxCodigoAgencia.Text)

            });


        }
        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text))
            {
                MessageBox.Show("Ingrese un CUIT/CUIL de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(textBoxCUITCUIL.Text, out long clienteValido))
            {
                MessageBox.Show("El CUIT/CUIL ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            modelo.ValidarCliente(new ValidarCliente
            {
                CUITCUIL = clienteValido,
            });

            buttonGenerarNumeroGuia.Enabled = true;
        }

        private void textBoxCodPostDestino_TextChanged(object sender, EventArgs e)
        {
            //Obtengo CD Destino
            string codigoPostal = textBoxCodPostDestino.Text.Trim();

            Ubicacion ubicacion = new Ubicacion();
            string centro = ubicacion.ObtenerCentroDistribucion(codigoPostal);
            labelCdDestino.Text = centro;
        }

        private void comboBoxMetodoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoEntrega.Text == "Retiro en CD Destino" )
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
    }

}
