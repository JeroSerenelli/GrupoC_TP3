using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.Gestion_de_Centro_de_Distribucion
{
    public partial class GestionCentroDeDistribucionForm : Form
    {
        public GestionCentroDeDistribucionForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarMicro_Click(object sender, EventArgs e)
        {
            //VALIDACION 1: Que el campo no esté vacío - mensaje de error "Por favor ingrese un valor en el campo "Patente" para realizar una busqueda".
            //VALIDACION 2: Que la patente este registrada - mensaje de error "La patente ingresada no se encuentra asociada a ninguna Hoja de Ruta".
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VALIDACION 3: Que se haya seleccionado una fila de la lista - mensaje de error "No se ha selecccionado ninguna Hoja de Ruta para ser finalizada".

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VALIDACION 4: Que se haya seleccionado una fila de la lista - mensaje de error "No se ha selecccionado ninguna Hoja de Ruta para ser despachada".
        }
    }
}
