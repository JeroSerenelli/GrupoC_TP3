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

        Resultado resultados;
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

            if (IniciodateTimePicker.Value > FindateTimePicker.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser superior a la fecha de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var Resultado in modelo.Resultados)
            {
                var listItem = new ListViewItem();
                listItem.Text = Resultado.EmpresaTransporte;
                listItem.SubItems.Add(Resultado.Venta.ToString());
                listItem.SubItems.Add(Resultado.Costo.ToString());
                listItem.SubItems.Add(Resultado.ResultadoCV.ToString());
                listView1.Items.Add(listItem);



                /*else
                {
                    MessageBox.Show("El numero de guia ingresado no corresponde a una encomienda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //Cuando busco uno que existe, tambien aparece. 
                }*/
            }
        }
    }
}
