
using GrupoC_TP3.Entrega_de_Encomiendas_en_Agencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU5_GestionCD
{

    public partial class GestionCentroDeDistribucionForm : Form
    {
        private GestionCentroDeDistribucionModel modelo = new();

        public GestionCentroDeDistribucionForm()
        {
            InitializeComponent();

            listViewEncomiendasARecibir.View = View.Details;
            listViewEncomiendasARecibir.FullRowSelect = true;
            listViewEncomiendasARecibir.CheckBoxes = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarMicro_Click(object sender, EventArgs e)
        {
            //VALIDACION 1: Que el campo no esté vacío - mensaje de error "Por favor ingrese un valor en el campo "Patente" para realizar una busqueda".
           
            listViewEncomiendasARecibir.Items.Clear();
            listViewEncomiendasADespachar.Items.Clear();

            if (string.IsNullOrEmpty(textBoxPatente.Text))
            {
                MessageBox.Show("Ingrese una patente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //VALIDACION 2: Que la patente este registrada ".

            modelo.ValidacionPatente(new EncomiendasEnTransporte
            {
                Patente = textBoxPatente.Text.ToUpper(),

            });

            

            foreach (var EncomiendasEnTransporte in modelo.paquetesRecibidos)
            {
                if (EncomiendasEnTransporte.Patente == textBoxPatente.Text.ToUpper())
                {
                    var listItem = new ListViewItem();
                    listItem.Text = EncomiendasEnTransporte.HojaDeRuta.ToString();
                    listItem.SubItems.Add(EncomiendasEnTransporte.NroGuia.ToString());
                    listItem.SubItems.Add(EncomiendasEnTransporte.Estado.ToString());
                    listViewEncomiendasARecibir.Items.Add(listItem);
                }
            }

            foreach (var EncomiendasEnTransporte in modelo.paquetesParaEntregar)
            {
                if (EncomiendasEnTransporte.Patente == textBoxPatente.Text.ToUpper())
                {
                    var listItem = new ListViewItem();
                    listItem.Text = EncomiendasEnTransporte.HojaDeRuta.ToString();
                    listItem.SubItems.Add(EncomiendasEnTransporte.NroGuia.ToString());
                    listItem.SubItems.Add(EncomiendasEnTransporte.Estado.ToString());
                    listViewEncomiendasADespachar.Items.Add(listItem);
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Gracias",
                "Gracias por usar el sistema.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            //VALIDACION 4: Que se haya seleccionado una fila de la lista - mensaje de error "No se ha selecccionado ninguna Hoja de Ruta para ser despachada".

            foreach (ListViewItem item in listViewEncomiendasARecibir.Items)
            {
                item.SubItems[2].Text = "Recibido en CD";
            }

            foreach ( ListViewItem item in listViewEncomiendasADespachar.Items)
            {
                item.SubItems[2].Text = "Entregado. En transporte.";                 
            }

           MessageBox.Show("Actualizado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
