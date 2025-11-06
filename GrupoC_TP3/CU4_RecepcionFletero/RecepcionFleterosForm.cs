using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrupoC_TP3.CU4_RecepcionFletero;

namespace GrupoC_TP3.CU4_RecepcionFletero
{
    public partial class RecepcionFleterosForm : Form
    {
        private RecepcionFleterosModel modelo;
        // Ya no referenciamos FleteroEntidad
        private int? fleteroDniSeleccionado;
        private string fleteroNombreSeleccionado;

        public RecepcionFleterosForm()
        {
            InitializeComponent();
        }

        private void RecepcionFleterosForm_Load(object sender, EventArgs e)
        {
            modelo = new RecepcionFleterosModel();
            ConfigurarComboBox();
            CargarTodosLosFleteros();
        }

        private void ConfigurarComboBox()
        {
            comboBoxFletero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Carga TODOS los fleteros en el combo al iniciar (usando el modelo, que devuelve DTOs simples)
        /// </summary>
        private void CargarTodosLosFleteros()
        {
            try
            {
                var fleteros = modelo.ObtenerTodosLosFleterosView(); // List<KeyValuePair<int,string>>

                comboBoxFletero.Items.Clear();
                comboBoxFletero.DisplayMember = "Value";

                foreach (var f in fleteros)
                {
                    comboBoxFletero.Items.Add(f);
                }

                comboBoxFletero.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar fleteros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        /// <summary>
        /// BOTÓN "BUSCAR" - Busca HDR asignadas y por asignar del fletero
        /// </summary>
        private void buttonBuscarFletero_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación
                if (comboBoxFletero.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un fletero de la lista.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el fletero seleccionado desde el KeyValuePair (DNI, Nombre)
                var kv = (KeyValuePair<int, string>)comboBoxFletero.SelectedItem;
                fleteroDniSeleccionado = kv.Key;
                fleteroNombreSeleccionado = kv.Value;
                int dniFletero = fleteroDniSeleccionado.Value;

                // Limpiar listas
                listViewHDRAsignadas.Items.Clear();
                listViewAsignarHDR.Items.Clear();

                // 1) Cargar HDR Asignadas (filtrar por DNI)
                var hojasAsignadas = modelo.Fleteros
                    .Where(h => h.DNIFletero == dniFletero)
                    .ToList();

                foreach (var hoja in hojasAsignadas)
                {
                    var item = new ListViewItem(hoja.HojaDeRuta);
                    item.SubItems.Add(hoja.NroGuia);
                    item.SubItems.Add(hoja.Estado);
                    item.Tag = hoja; // Guardar el objeto completo (clase HojasDeRutaAsignadas)
                    listViewHDRAsignadas.Items.Add(item);
                }

                // 2) Cargar HDR Por Asignar (buscar por DNI en el diccionario)
                if (modelo.PorAsignarPorFletero.TryGetValue(dniFletero, out var hojasPorAsignar))
                {
                    foreach (var hoja in hojasPorAsignar)
                    {
                        var item = new ListViewItem(hoja.HojaDeRuta);
                        item.SubItems.Add(hoja.NroGuia);
                        item.Tag = hoja; // Guardar el objeto completo (clase HojasDeRutaPorAsignar)
                        listViewAsignarHDR.Items.Add(item);
                    }
                }

                // Mensaje si no hay encomiendas
                if (!hojasAsignadas.Any() && (hojasPorAsignar == null || !hojasPorAsignar.Any()))
                {
                    MessageBox.Show("El fletero no tiene encomiendas asignadas ni disponibles.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// BOTÓN "IMPRIMIR DETALLE"
        /// </summary>
        private void buttonImprimirDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación: debe haber un fletero seleccionado
                if (fleteroDniSeleccionado == null)
                {
                    MessageBox.Show("Primero debe buscar un fletero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: debe haber items chequeados
                if (listViewHDRAsignadas.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Debe tildar al menos una Hoja de Ruta asignada.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener hojas chequeadas
                var hojasParaImprimir = listViewHDRAsignadas.CheckedItems
                    .Cast<ListViewItem>()
                    .Select(item => (HojasDeRutaAsignadas)item.Tag)
                    .ToList();

                // Obtener los IDs únicos de HDR
                var hdrIds = hojasParaImprimir
                    .Select(h => h.HojaDeRuta)
                    .Distinct()
                    .ToList();

                // Obtener TODAS las guías de esas HDR (no solo las tildadas)
                var todasLasGuiasActualizadas = new List<(string HojaDeRuta, string NroGuia)>();

                foreach (var hdrId in hdrIds)
                {
                    // Buscar todas las guías de esta HDR en el modelo
                    var guiasDeLaHDR = modelo.Fleteros
                        .Where(h => h.HojaDeRuta == hdrId && h.DNIFletero == fleteroDniSeleccionado.Value)
                        .Select(h => (h.HojaDeRuta, h.NroGuia))
                        .ToList();

                    todasLasGuiasActualizadas.AddRange(guiasDeLaHDR);
                }

                // Actualizar en el modelo
                modelo.ImprimirDetalleHDRAsignadas(hojasParaImprimir);

                // Generar y mostrar detalle con TODAS las guías
                var sb = new StringBuilder();
                sb.AppendLine("═══════════════════════════════════════════════════");
                sb.AppendLine("        DETALLE DE RECEPCIÓN DE HOJAS DE RUTA");
                sb.AppendLine("═══════════════════════════════════════════════════");
                sb.AppendLine($"Fletero: {fleteroNombreSeleccionado}");
                sb.AppendLine($"DNI: {fleteroDniSeleccionado.Value}");
                sb.AppendLine("───────────────────────────────────────────────────");
                sb.AppendLine($"{"Hoja de Ruta",-15} {"Nro Guía",-15} {"Estado",-20}");
                sb.AppendLine("───────────────────────────────────────────────────");

                // Mostrar TODAS las guías actualizadas
                foreach (var (hoja, guia) in todasLasGuiasActualizadas)
                {
                    sb.AppendLine($"{hoja,-15} {guia,-15} {"Cumplida",-20}");
                }

                sb.AppendLine("═══════════════════════════════════════════════════");
                sb.AppendLine($"Total recepcionadas: {todasLasGuiasActualizadas.Count} guías");

                MessageBox.Show(sb.ToString(), "Detalle de Recepción",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar la vista
                buttonBuscarFletero_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir detalle: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// BOTÓN "ASIGNAR" - Asigna HDR pendientes al fletero
        /// </summary>
        private void buttonAsignarHDR_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación: debe haber un fletero seleccionado
                if (fleteroDniSeleccionado == null)
                {
                    MessageBox.Show("Primero debe buscar un fletero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: debe haber items seleccionados
                if (listViewAsignarHDR.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos una Hoja de Ruta para asignar.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener hojas seleccionadas
                var hojasParaAsignar = listViewAsignarHDR.SelectedItems
                    .Cast<ListViewItem>()
                    .Select(item => (HojasDeRutaPorAsignar)item.Tag)
                    .ToList();

                // Asignar usando el DNI del fletero seleccionado
                modelo.AsignarHojasDeRutaAFletero(fleteroDniSeleccionado.Value, hojasParaAsignar);

                MessageBox.Show("Hojas de ruta asignadas correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar la vista
                buttonBuscarFletero_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al asignar hojas de ruta: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptarRecepcion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias", "Gracias por usar el sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}