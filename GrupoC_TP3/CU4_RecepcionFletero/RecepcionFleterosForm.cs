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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GrupoC_TP3.CU4_RecepcionFletero
{
    public partial class RecepcionFleterosForm : Form
    {
        private RecepcionFleterosModel modelo = new();

        public HojasDeRutaAsignadas HojasdeRutaAsignadas;

        private bool _listasInicializadas = false;
        private void InicializarListViewsSiHaceFalta()
        {
            if (_listasInicializadas) return;

            listViewHDRAsignadas.View = View.Details;
            listViewHDRAsignadas.FullRowSelect = true;
            listViewHDRAsignadas.MultiSelect = true;
            listViewHDRAsignadas.CheckBoxes = true;

            if (listViewHDRAsignadas.Columns.Count == 0)
            {
                listViewHDRAsignadas.Columns.Add("Hoja de Ruta", 110);
                listViewHDRAsignadas.Columns.Add("Nro Guía", 110);
                listViewHDRAsignadas.Columns.Add("Estado", 120);
            }

            listViewAsignarHDR.View = View.Details;
            listViewAsignarHDR.FullRowSelect = true;
            listViewAsignarHDR.MultiSelect = true;

            if (listViewAsignarHDR.Columns.Count == 0)
            {
                listViewAsignarHDR.Columns.Add("Hoja de Ruta", 110);
                listViewAsignarHDR.Columns.Add("Nro Guía", 110);
                listViewAsignarHDR.Columns.Add("Estado", 120);
            }

            _listasInicializadas = true;
        }

        private void CargarParaFletero(string fletero)
        {
            InicializarListViewsSiHaceFalta();

            listViewHDRAsignadas.Items.Clear();
            listViewAsignarHDR.Items.Clear();

            if (string.IsNullOrWhiteSpace(fletero)) return;

            foreach (var h in modelo.Fleteros.Where(x => x.Fletero == fletero))
            {
                var it = new ListViewItem(h.HojaDeRuta);
                it.SubItems.Add(h.NroGuia);
                it.SubItems.Add(h.Estado ?? "");
                it.Tag = h;
                listViewHDRAsignadas.Items.Add(it);
            }

            foreach (var p in modelo.Transportistas.Where(x => string.IsNullOrWhiteSpace(x.Fletero)))
            {
                var it = new ListViewItem(p.HojaDeRuta);
                it.SubItems.Add(p.NroGuia);
                it.SubItems.Add("Pendiente");
                it.Tag = p;
                listViewAsignarHDR.Items.Add(it);
            }
        }

        public RecepcionFleterosForm()
        {
            InitializeComponent();
            InicializarListViewsSiHaceFalta();

            comboBoxFletero.SelectedIndexChanged += (s, e) => CargarParaFletero(comboBoxFletero.Text?.Trim());
        }

        private void button1_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void buttonBuscarFletero_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxFletero.Text))
            {
                MessageBox.Show("Ingrese fletero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fletero = comboBoxFletero.Text.Trim();
            CargarParaFletero(fletero);

            // comboBoxFletero.Enabled = false;
        }
        private void buttonImprimirDetalle_Click(object sender, EventArgs e)
        {
            if (listViewHDRAsignadas.CheckedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe tildar al menos una Hoja de Ruta asignada.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var sb = new StringBuilder();

            if (listViewHDRAsignadas.Columns.Count > 0)
            {
                var header = string.Join(" | ",
                    listViewHDRAsignadas.Columns
                        .Cast<ColumnHeader>()
                        .Select(ch => (ch.Text ?? "").Trim()));
                sb.AppendLine(header);
                sb.AppendLine(new string('-', Math.Max(20, header.Length)));
            }

            foreach (ListViewItem it in listViewHDRAsignadas.CheckedItems)
            {
                if (it.SubItems.Count > 1)
                {
                    var celdas = it.SubItems
                        .Cast<ListViewItem.ListViewSubItem>()
                        .Select(si => (si.Text ?? "").Trim());
                    sb.AppendLine(string.Join(" | ", celdas));
                }
                else
                {
                    sb.AppendLine((it.Text ?? "").Trim());
                }
            }

            MessageBox.Show(
                sb.ToString(),
                "Detalle de HDR tildadas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void buttonAsignarHDR_Click(object sender, EventArgs e)
        {
            var fletero = comboBoxFletero.Text?.Trim();
            if (string.IsNullOrWhiteSpace(fletero))
            {
                MessageBox.Show("Debe seleccionar un fletero antes de asignar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listViewAsignarHDR.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una Hoja de Ruta para asignar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var seleccionadas = listViewAsignarHDR.SelectedItems.Cast<ListViewItem>().ToList();

            var clavesAsignadas = new HashSet<string>(
                modelo.Fleteros
                    .Where(f => f.Fletero == fletero)
                    .Select(f => $"{f.HojaDeRuta}|{f.NroGuia}")
            );

            foreach (var src in seleccionadas)
            {
                string hdr = src.SubItems[0].Text;
                string guia = src.SubItems[1].Text;
                string clave = $"{hdr}|{guia}";

                modelo.Transportistas.RemoveAll(t => t.HojaDeRuta == hdr && t.NroGuia == guia);

                if (!clavesAsignadas.Contains(clave))
                {
                    modelo.Fleteros.Add(new HojasDeRutaAsignadas
                    {
                        Fletero = fletero,
                        HojaDeRuta = hdr,
                        NroGuia = guia,
                        Estado = "Pendiente"
                    });
                    clavesAsignadas.Add(clave);
                }

                listViewAsignarHDR.Items.Remove(src);

                var dst = new ListViewItem(hdr);
                dst.SubItems.Add(guia);
                dst.SubItems.Add("Pendiente");
                listViewHDRAsignadas.Items.Add(dst);
            }

            MessageBox.Show("Hojas de ruta asignadas correctamente.", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonAceptarRecepcion_Click(object sender, EventArgs e)
        {
        
            MessageBox.Show(
                "Datos cargados correctamente.",
                "Gracias por usar el sistema.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
    }
}


