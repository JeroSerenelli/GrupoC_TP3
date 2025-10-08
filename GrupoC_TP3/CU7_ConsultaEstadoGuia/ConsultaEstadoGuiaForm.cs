using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU7_ConsultaEstadoGuia
{
    public partial class ConsultaEstadoGuiaForm : Form
    {
        private ConsultaEstadoGuiaModel modelo = new();

        public Guia guias;

        public ConsultaEstadoGuiaForm()
        {
            InitializeComponent();
        }

        private void ConsultaEstadoGuiaEnCDForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e, Guia guia)
        {
            if (string.IsNullOrEmpty(textBoxNumeroGuiaConsulta.Text))
            {
                MessageBox.Show("Para realizar una busqueda, ingrese un numero de guia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(textBoxNumeroGuiaConsulta.Text, out long numeroGuiaConsulta))
            {
                MessageBox.Show("El numero de guia ingresado es invalido, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var Guias in modelo.Guias) 
            {
                if (Guias.NumeroGuia == numeroGuiaConsulta)
                {
                    var listItem = new ListViewItem();
                    listItem.Text = Guias.NumeroGuia.ToString();
                    listItem.SubItems.Add(Guias.EstadoGuia.ToString());
                    listView1.Items.Add(listItem);
                }

            }
            


        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (string.IsNullOrEmpty(textBoxNumeroGuiaConsulta.Text))
            {
                MessageBox.Show("Para realizar una busqueda, ingrese un numero de guia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(textBoxNumeroGuiaConsulta.Text, out long numeroGuiaConsulta))
            {
                MessageBox.Show("El numero de guia ingresado es invalido, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var Guias in modelo.Guias)
            {
                if (Guias.NumeroGuia == numeroGuiaConsulta)
                {
                    var listItem = new ListViewItem();
                    listItem.Text = Guias.EstadoGuia.ToString();
                    listItem.SubItems.Add(Guias.UltActualizacion.ToString());
                    listView1.Items.Add(listItem);
                }
            }

        }
    }
}
