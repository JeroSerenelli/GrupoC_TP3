using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU10_ResultadoCostosVsVentas
{
    public partial class ResultadoCostosVsVentasForm : Form
    {
        private readonly ResultadoCostosVsVentasModel modelo = new();



        public ResultadoCostosVsVentasForm()
        {
            InitializeComponent();
        }

        private void razonSocialTxt_TextChanged(object sender, EventArgs e)
        {

        }



        private void IniciodateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {

            if (dateTimePickerInicio.Value > dateTimePickerFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser superior a la fecha de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DateTime fechaInicio = dateTimePickerInicio.Value.Date;
            DateTime fechaFin = dateTimePickerFin.Value.Date;

            // NECESITO RESOLVER ESTO PARA IMPLEMENTAR EL FILTRO DE FECHAS
            var filtrados = modelo.Resultados1
                .Where(r => r.Fecha >= fechaInicio && r.Fecha <= fechaFin)
                .ToList();

            CargarListView(filtrados);

        }


        // Método para cargar datos en el ListView
        private void CargarListView(List<Resultado> lista)
        {
            listViewResultados.Items.Clear();

            foreach (var r in lista)
            {
                var item = new ListViewItem(r.EmpresaTransporte);
                item.SubItems.Add(r.Venta.ToString());
                item.SubItems.Add(r.Costo.ToString());
                item.SubItems.Add(r.ResultadoCV.ToString());
                listViewResultados.Items.Add(item);
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
    }
}
