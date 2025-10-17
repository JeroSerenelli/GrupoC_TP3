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
            listViewHDRAsignadas.CheckBoxes = true;

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

            foreach (var h in modelo.Fleteros.Where(x => x.Fletero == fletero && !string.Equals(x.Estado, "Cumplida", StringComparison.OrdinalIgnoreCase)))
            {
                var it = new ListViewItem(h.HojaDeRuta);
                it.SubItems.Add(h.NroGuia);
                it.SubItems.Add(h.Estado ?? "No Cumplida");
                it.Tag = h;
                listViewHDRAsignadas.Items.Add(it);
            }
           
            List<HojasDeRutaPorAsignar> pool = null;

            if (!modelo.PorAsignarPorFletero.TryGetValue(fletero, out pool) || pool == null)
            {
                var kv = modelo.PorAsignarPorFletero
                    .FirstOrDefault(kvp => string.Equals(kvp.Key, fletero, StringComparison.OrdinalIgnoreCase));
                pool = kv.Value;
            }

            if (pool != null)
            {
                foreach (var p in pool)
                {
                    var it = new ListViewItem(p.HojaDeRuta);
                    it.SubItems.Add(p.NroGuia);
                    it.SubItems.Add("No Cumplida");
                    it.Tag = p;
                    listViewAsignarHDR.Items.Add(it);
                }
            }
        }


        public RecepcionFleterosForm()
        {
            InitializeComponent();
            InicializarListViewsSiHaceFalta();

            comboBoxFletero.DropDownStyle = ComboBoxStyle.DropDownList;

            ConstruirFleterosValidos();
            PoblarComboFletero();

            comboBoxFletero.SelectedIndexChanged += (s, e) =>
            {
                listViewHDRAsignadas.Items.Clear();
                listViewAsignarHDR.Items.Clear();
            };
        }
        private HashSet<string> _fleterosValidos = new();

        private void ConstruirFleterosValidos()
        {
            _fleterosValidos = new HashSet<string>(
                modelo.Fleteros.Select(f => f.Fletero)
                .Concat(modelo.PorAsignarPorFletero.Keys),
                StringComparer.OrdinalIgnoreCase
            );
        }

        private void PoblarComboFletero()
        {
            comboBoxFletero.Items.Clear();
            foreach (var nombre in _fleterosValidos.OrderBy(x => x))
                comboBoxFletero.Items.Add(nombre);

            comboBoxFletero.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void buttonBuscarFletero_Click(object sender, EventArgs e)
        {
            if (comboBoxFletero.SelectedItem is null)
            {
                MessageBox.Show("Seleccione un fletero de la lista.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fletero = comboBoxFletero.SelectedItem.ToString();

            if (_fleterosValidos == null || _fleterosValidos.Count == 0)
                ConstruirFleterosValidos();

            if (!_fleterosValidos.Contains(fletero))
            {
                MessageBox.Show("El fletero seleccionado no es válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarParaFletero(fletero);
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

            var chequeadas = listViewHDRAsignadas.CheckedItems
                .Cast<ListViewItem>()
                .ToList();

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

            foreach (var it in chequeadas)
            {
                string hdr = it.SubItems.Count > 0 ? (it.SubItems[0].Text ?? "").Trim() : (it.Text ?? "").Trim();
                string guia = it.SubItems.Count > 1 ? (it.SubItems[1].Text ?? "").Trim() : "";

                string linea = $"{hdr} | {guia} | Cumplida";
                sb.AppendLine(linea);

                listViewHDRAsignadas.Items.Remove(it);
            }

            MessageBox.Show(
                sb.ToString(),
                "Detalle de HDR asignadas",
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

            if (!modelo.PorAsignarPorFletero.TryGetValue(fletero, out var pool) || pool == null)
            {
                MessageBox.Show("No hay hojas de ruta por asignar para este fletero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                var idx = pool.FindIndex(t => t.HojaDeRuta == hdr && t.NroGuia == guia);
                if (idx >= 0) pool.RemoveAt(idx);

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
                dst.SubItems.Add("No Cumplida");
                listViewHDRAsignadas.Items.Add(dst);
            }

            MessageBox.Show("Hojas de ruta asignadas correctamente.", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAceptarRecepcion_Click(object sender, EventArgs e)
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




