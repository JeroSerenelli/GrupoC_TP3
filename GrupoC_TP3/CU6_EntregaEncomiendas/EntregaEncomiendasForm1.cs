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
            labelNombre.Text = "";
            labelApellido.Text = "";

            if (string.IsNullOrEmpty(textBoxDNI.Text))
            {
                MessageBox.Show("Ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxDNI.Text, out int salida))
            {
                MessageBox.Show("El DNI ingresado es invalido, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            modelo.ConsultaDNI(new Encomienda
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

        // VIEJO CODIGO DEL BOTON CONFIRMAR, LO COMENTO PARA REMPLAZARLO CON LA LLAMADA AL METODO CONFIRMAR ENTREGA DEL MODELO CON LA LOGICA DE JSON
        /*
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
            */

        private void buttonConfirmarEntrega_Click(object sender, EventArgs e)
        {
            // Verificar que haya encomiendas para entregar. REVISA DIRECTAMENTE EL LISTVIEW, SI NO TIENE ITEMS, NO HAY NADA QUE ENTREGAR Y DIRECTAMENTE RETORNA Y SALTEA EL RESTO
            if (listViewEncomiendasARetirarAgencia.Items.Count == 0)
                return;

            // Números de guía a entregar
            // Esto toma la coleccion de items del listview, los convierte en una lista de objetos de tipo ListViewItem, luego toma el Tag (que es la encomienda), obtiene su NroGuia, lo convierte a int, elimina duplicados y lo convierte a lista
            var numerosGuia = listViewEncomiendasARetirarAgencia.Items
                .Cast<ListViewItem>()
                .Select(item => ((Encomienda)item.Tag).NroGuia)
                .Select(nro => int.Parse(nro))
                .Distinct()
                .ToList();

            // Metodo para actualizar estado e historial en JSON
            modelo.ConfirmarEntrega(numerosGuia);

            string mensaje = $"Las encomiendas fueron entregadas:\n\n- {string.Join("\n- ", numerosGuia)}";
            MessageBox.Show(mensaje, "Encomiendas Entregadas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar pantalla
            listViewEncomiendasARetirarAgencia.Items.Clear();
            labelNombre.Text = "";
            labelApellido.Text = "";
            textBoxDNI.Text = "";
            buttonConfirmarEntrega.Enabled = false;


        }

    }
}
