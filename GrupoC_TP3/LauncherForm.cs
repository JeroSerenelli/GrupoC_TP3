using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GrupoC_TP3
{
    internal class LauncherForm : Form
    {
        private ListBox listBox;
        private Button runButton;
        private Button cancelarButton;

        // Display name -> full type name (namespace + type)
        private readonly Dictionary<string, string> formMap = new()
        {
            { "CU1 - RegistrarImposicionRetiroPorDomicilio", "GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio.RegistrarImposicionRetiroPorDomicilioForm" },
            { "CU2 - RegistrarImposicionEnAgencia", "GrupoC_TP3.CU2_RegistrarImposicionEnAgencia.RegistrarImposicionEnAgenciaForm" },
            { "CU3 - RegistrarImposicionEnCD", "GrupoC_TP3.CU3_RegistrarImposicionEnCD.RegistrarImposicionEnCDForm" },
            { "CU4 - RecepcionFletero", "GrupoC_TP3.CU4_RecepcionFletero.RecepcionFleterosForm" },
            { "CU5 - GestionCD", "GrupoC_TP3.CU5_GestionCD.GestionCentroDeDistribucionForm" },
            { "CU6 - EntregaEncomiendas", "GrupoC_TP3.CU6_EntregaEncomiendas.EntregaEncomiendasForm1" },
            { "CU7 - ConsultaEstadoGuia", "GrupoC_TP3.CU7_ConsultaEstadoGuia.ConsultaEstadoGuiaForm" },
            { "CU8 - EmisionFacturas", "GrupoC_TP3.CU8_EmisionFacturas.EmisionFacturasForm" },
            { "CU9 - CuentaCorriente", "GrupoC_TP3.CU9_CuentaCorriente.CuentaCorrienteForm" },
            { "CU10 - ResultadoCostosVsVentas", "GrupoC_TP3.CU10_ResultadoCostosVsVentas.ResultadoCostosVsVentasForm" }
        };

        public LauncherForm()
        {
            Text = "Seleccionar Formulario";
            Width = 480;
            Height = 360;
            StartPosition = FormStartPosition.CenterScreen;

            listBox = new ListBox { Dock = DockStyle.Top, Height = 240 };
            listBox.Items.AddRange(formMap.Keys.ToArray());
            listBox.SelectedIndex = 0;
            listBox.DoubleClick += RunSelectedForm;

            runButton = new Button { Text = "Abrir", Dock = DockStyle.Left, Width = 100 };
            runButton.Click += RunSelectedForm;

            cancelarButton = new Button { Text = "Salir", Dock = DockStyle.Right, Width = 100 };
            cancelarButton.Click += (s, e) => Close();

            var panel = new Panel { Dock = DockStyle.Bottom, Height = 48 };
            panel.Controls.Add(runButton);
            panel.Controls.Add(cancelarButton);

            Controls.Add(listBox);
            Controls.Add(panel);
        }

        private void RunSelectedForm(object? sender, EventArgs e)
        {
            if (listBox.SelectedItem is not string key) return;

            if (!formMap.TryGetValue(key, out var typeName))
            {
                MessageBox.Show("Formulario no mapeado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = CreateFormInstance(typeName);
            if (form == null)
            {
                MessageBox.Show($"No se encontró o no se pudo crear el formulario:\n{typeName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show selected form modally so launcher remains available after closing it.
            Hide();
            try
            {
                // Ensure the form appears with its designed size and centered on the screen.
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
            finally
            {
                Show();
                form.Dispose();
            }
        }

        private Form? CreateFormInstance(string typeFullName)
        {
            // Try to locate the type in loaded assemblies
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Type? t = null;
            foreach (var a in assemblies)
            {
                t = a.GetType(typeFullName, throwOnError: false, ignoreCase: false);
                if (t != null) break;
            }

            // If type not found, try loading executing assembly explicitly
            if (t == null)
            {
                var exec = Assembly.GetExecutingAssembly();
                t = exec.GetType(typeFullName, throwOnError: false, ignoreCase: false);
            }

            if (t == null) return null;
            if (!typeof(Form).IsAssignableFrom(t)) return null;

            try
            {
                var instance = Activator.CreateInstance(t);
                return instance as Form;
            }
            catch
            {
                return null;
            }
        }
    }
}
