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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (string.IsNullOrWhiteSpace(textBoxNumeroGuiaConsulta.Text))
            {
                MessageBox.Show("Para realizar una búsqueda, ingrese un número de guía",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(textBoxNumeroGuiaConsulta.Text, out long numeroGuia))
            {
                MessageBox.Show("El número de guía ingresado es inválido.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var historial = modelo.ObtenerHistorialPorNumero(numeroGuia);

                listView1.BeginUpdate();
                foreach (var g in historial) 
                {
                    var item = new ListViewItem(g.EstadoGuia); 
                    item.SubItems.Add(g.UltActualizacion);      
                    listView1.Items.Add(item);
                }
                listView1.EndUpdate();

                if (historial.Count == 0)
                {
                    MessageBox.Show("La guía no tiene historial de estados.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar la guía.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
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
