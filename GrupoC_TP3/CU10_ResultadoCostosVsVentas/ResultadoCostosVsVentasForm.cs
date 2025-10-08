using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU10_ResultadoCostosVsVentas
{
    public partial class ResultadoCostosVsVentasForm : Form
    {
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
        }
    }
}
