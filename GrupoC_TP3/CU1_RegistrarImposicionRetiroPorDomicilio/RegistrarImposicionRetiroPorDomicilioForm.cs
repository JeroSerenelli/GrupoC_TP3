using GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;
using GrupoC_TP3.CU7_ConsultaEstadoGuia;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio
{
    public partial class RegistrarImposicionRetiroPorDomicilioForm : Form
    {
        private RegistrarImposicionRetiroPorDomicilioModel modelo = new();



        public RegistrarImposicionRetiroPorDomicilioForm()
        {
            InitializeComponent();

            //Desactivo la escritura en los combo box
            cmbBoxProvDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxLocalidadDestino.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxMetodoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxTipoCaja.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxProvRetiro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxLocalidadRetiro.DropDownStyle = ComboBoxStyle.DropDownList;


            var ubicacion = modelo.ObtenerUbicacion1();
            cmbBoxProvDestino.DataSource = ubicacion.ProvinciasYLocalidades.Keys.ToList();
            cmbBoxProvDestino.SelectedIndex = -1;
            cmbBoxLocalidadDestino.SelectedIndex = -1;
            cmbBoxLocalidadDestino.Enabled = false; // hasata que no elija la provincia de destino

            cmbBoxProvRetiro.DataSource = ubicacion.ProvinciasYLocalidades.Keys.ToList();
            cmbBoxProvRetiro.SelectedIndex = -1;
            cmbBoxLocalidadRetiro.SelectedIndex = -1;
            cmbBoxLocalidadRetiro.Enabled = false; // hasata que no elija la provincia de destino


            //TODO: Nice-To-Have. ASEGURARSE que esto este bien implementado. Debe estar habilitado solo cuando el DNI ingresado sea valido y la casilla esté completa
            buttonGenerarNumeroGuia.Enabled = false; //Desactivo el boton generar nro de guia hasta que esten las validaciones completadas




        }

        private void buttonGenerarNumeroGuia_Click(object sender, EventArgs e)
        {
            //Validaciones
            // Validacion - CUIT/CUIL
            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un CUIT/CUIL de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string limpio = textBoxCUITCUIL.Text.Replace("-", "");


            if (!long.TryParse(limpio, out long clienteValido)) //Lvl 1
            {
                MessageBox.Show("El CUIT/CUIL ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            buttonGenerarNumeroGuia.Enabled = true;

            //Informacion Destino
            // Val - Provincia
            if (string.IsNullOrEmpty(cmbBoxProvDestino.Text)) //Lvl 0
            {
                MessageBox.Show("Seleccione una provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Val - Localidad
            if (string.IsNullOrEmpty(cmbBoxLocalidadDestino.Text)) //Lvl 0
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
            if (string.IsNullOrEmpty(textBoxCPDestino.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un código postal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxCPDestino.Text, out int cpDestino)) //Lvl 1
            {
                MessageBox.Show("El codigo postal ingresado no es un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var valDestino = modelo.ValidacionDestino(new EncomiendasImpuestas
            {
                CPDestino = cpDestino,
            });

            if(valDestino)
            {
                return;
            }

            if (labelCdDestino.Text == "Centro de distribución no encontrado") //Lvl 2?
            {
                MessageBox.Show("No existe un centro de distribucion para el CP ingresado. Ingrese otro codigo postal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Val - Domicilio
            if (comboBoxMetodoEntrega.Text == "Entrega en Domicilio")
            {
                if (string.IsNullOrEmpty(textBoxDomicilioDestinatario.Text)) //Lvl 0
                {
                    MessageBox.Show("Ingrese el domicilio del destinatario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                MessageBox.Show("Ingrese un valor numérico para indicar la cantidad de cajas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var valDatosEncomiendas = modelo.ValidacionDatosEncomienda(new EncomiendasImpuestas
            {
                CantCajas = cajas,
            });

            if(valDatosEncomiendas)
            {
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


            var valDatosRetiro = modelo.ValidacionesDatosRetiro(new EncomiendasImpuestas
            {
                CPRetiro = cpRetiro,
            });

            if(valDatosRetiro)
            {
                return;
            }

            //Val- CD Destino
            if (labelCdDestino.Text == "Centro de distribución no encontrado") //Lvl 2
            {
                MessageBox.Show("No existe un centro de distribucion para el CP ingresado. Ingrese otro codigo postal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (!int.TryParse(textBoxDNIDestinatario.Text, out int DNI))
            {
                MessageBox.Show("El campo DNI debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBoxDNIDestinatario.Focus();
                return;
            }

             var valDatosDestinatario = modelo.ValidacionDatosDestinatario(new EncomiendasImpuestas
            {
                DNIDestinatario = DNI,

            });

            if (valDatosDestinatario)
            {
                return;
            }


            //TODO: FALTA CREAR LA ENCOMIENDA FINAL Y PRINTEAR 
            modelo.CrearEncomienda(new EncomiendasImpuestas
            {
                CantCajas = cajas
            });

        }



        private void cmbBoxProvDst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string provinciaSeleccionada = cmbBoxProvDestino.Text;

            // Limpiar combo de localidad
            cmbBoxLocalidadRetiro.DataSource = null;

            var ubicacion = modelo.ObtenerUbicacion1();
            if (ubicacion.ProvinciasYLocalidades.ContainsKey(provinciaSeleccionada))
            {
                cmbBoxLocalidadDestino.Enabled = true;
                cmbBoxLocalidadDestino.DataSource = ubicacion.ProvinciasYLocalidades[provinciaSeleccionada];
            }

        }

        private void cmbBoxProvRetiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string provinciaSeleccionada = cmbBoxProvRetiro.Text;

            // Limpiar combo de localidad
            cmbBoxLocalidadRetiro.DataSource = null;
            var ubicacion = modelo.ObtenerUbicacion1();
            if (ubicacion.ProvinciasYLocalidades.ContainsKey(provinciaSeleccionada))
            {
                cmbBoxLocalidadRetiro.Enabled = true;
                cmbBoxLocalidadRetiro.DataSource = ubicacion.ProvinciasYLocalidades[provinciaSeleccionada];
            }
        }

        private void textBoxCpRetiro_TextChanged(object sender, EventArgs e)
        {
            var ubicacion = modelo.ObtenerUbicacion1();

            //Obtengo CD Origen
            string codigoPostal1 = textBoxCpRetiro.Text.Trim();
            string centro1 = ubicacion.ObtenerCentroDistribucion(codigoPostal1);
            labelCdOrigen.Text = centro1;
        }


        private void textBoxCodPostDestino_TextChanged(object sender, EventArgs e)
        {
            //Obtengo CD Destino
            string codigoPostal = textBoxCPDestino.Text.Trim();

            var ubicacion = modelo.ObtenerUbicacion1();
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

        private void ValidarCUIT_Click(object sender, EventArgs e)
        {
            // Validacion - CUIT/CUIL
            // Validacion - CUIT/CUIL
            if (string.IsNullOrEmpty(textBoxCUITCUIL.Text)) //Lvl 0
            {
                MessageBox.Show("Ingrese un CUIT/CUIL de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string limpio = textBoxCUITCUIL.Text.Replace("-", "");

            if (!long.TryParse(limpio, out long clienteValido)) //Lvl 1
            {
                MessageBox.Show("El CUIT/CUIL ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            modelo.ValidacionCliente(new ValidacionClientes
            {
                CUITCUIL = clienteValido,
            });

            buttonGenerarNumeroGuia.Enabled = true;
        }

        private void buttonNuevaSolicitudLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Gracias",
                "Gracias por usar el sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
    }
    
}
    