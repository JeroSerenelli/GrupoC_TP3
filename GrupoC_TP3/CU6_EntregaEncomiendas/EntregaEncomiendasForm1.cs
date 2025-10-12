using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;
using GrupoC_TP3.CU7_ConsultaEstadoGuia;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC_TP3.CU6_EntregaEncomiendas
{
    public partial class EntregaEncomiendasForm1 : Form
    {
        private EntregaEncomiendasModel modelo = new();

        public EntregaEncomiendasForm1()
        {
            InitializeComponent();
            buttonConfirmarEntrega.Enabled = false;

            listViewEncomiendasARetirarAgencia.View = View.Details;
            listViewEncomiendasARetirarAgencia.FullRowSelect = true;
            //listViewEncomiendasARetirarAgencia.MultiSelect = false;
            listViewEncomiendasARetirarAgencia.CheckBoxes = false;

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            listViewEncomiendasARetirarAgencia.Items.Clear();

            if (string.IsNullOrEmpty(textBoxDNI.Text))
            {
                MessageBox.Show("Ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxDNI.Text, out int salida))
            {
                MessageBox.Show("El numero de guia ingresado es invalido, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            modelo.ValidacionCliente(new Encomienda
            {
                Dni = salida,

            });

            buttonConfirmarEntrega.Enabled = true;

            foreach (var Encomiendas in modelo.Encomiendas)
            {
                if (Encomiendas.Dni == salida)
                {
                    var listItem = new ListViewItem();
                    labelNombre.Text = Encomiendas.Nombre;
                    labelApellido.Text = Encomiendas.Apellido;
                    listItem.Text = Encomiendas.NroGuia.ToString();
                    listItem.SubItems.Add(Encomiendas.Estado.ToString());
                    listItem.Tag = Encomiendas; // Guardamos el objeto para usarlo luego
                    listViewEncomiendasARetirarAgencia.Items.Add(listItem);
                }
            }






        }

        private void buttonConfirmarEntrega_Click(object sender, EventArgs e)
        {
            var seleccionadas = listViewEncomiendasARetirarAgencia.Items.Cast<ListViewItem>().ToList();

            if (listViewEncomiendasARetirarAgencia.Items.Count > 0)
            {
                var guiasAEntregar = seleccionadas
                    .Select(item => ((Encomienda)item.Tag).NroGuia)
                    .Distinct() // Opcional: evita duplicados
                    .ToList();

                string mensaje = $"Las encomiendas fueron entregadas: \n\n- {string.Join("\n ", guiasAEntregar)}";
            
                MessageBox.Show(mensaje, "Encomiendas Entregadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            listViewEncomiendasARetirarAgencia.Items.Clear();
            labelNombre.Text = "";
            labelApellido.Text = "";
            textBoxDNI.Text = "";

        }
    }
}
