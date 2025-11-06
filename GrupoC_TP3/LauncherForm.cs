using GrupoC_TP3.Almacenes;
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
        private Panel panel1;
        private ComboBox CdActualCombo;
        private ComboBox AgenciaActualCombo;
        private Label label2;
        private Label label1;
        private Panel panel2;

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
            InitializeComponent();

            Text = "Seleccionar Formulario";
            Width = 550;
            Height = 560;
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

            panel2.Controls.Add(listBox);
            panel2.Controls.Add(panel);

            CdActualCombo.DisplayMember = "Nombre";
            CdActualCombo.Items.AddRange(CentroDistribucionAlmacen.centrosDistribucion.OrderBy(c => c.Nombre).ToArray());

            AgenciaActualCombo.DisplayMember = "CodAgencia";
            AgenciaActualCombo.Items.AddRange(AgenciaAlmacen.agencias.OrderBy(a => a.CodAgencia).ToArray());
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
                MessageBox.Show($"No se encontr� o no se pudo crear el formulario:\n{typeName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            CdActualCombo = new ComboBox();
            AgenciaActualCombo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CdActualCombo);
            panel1.Controls.Add(AgenciaActualCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 80);
            panel1.TabIndex = 0;
            // 
            // CdActualCombo
            // 
            CdActualCombo.FormattingEnabled = true;
            CdActualCombo.Location = new Point(114, 39);
            CdActualCombo.Name = "CdActualCombo";
            CdActualCombo.Size = new Size(368, 23);
            CdActualCombo.TabIndex = 3;
            CdActualCombo.SelectedIndexChanged += CdActualCombo_SelectedIndexChanged;
            // 
            // AgenciaActualCombo
            // 
            AgenciaActualCombo.FormattingEnabled = true;
            AgenciaActualCombo.Location = new Point(114, 10);
            AgenciaActualCombo.Name = "AgenciaActualCombo";
            AgenciaActualCombo.Size = new Size(368, 23);
            AgenciaActualCombo.TabIndex = 2;
            AgenciaActualCombo.SelectedIndexChanged += AgenciaActualCombo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 39);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Cd actual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Agencia actual";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 355);
            panel2.TabIndex = 1;
            // 
            // LauncherForm
            // 
            ClientSize = new Size(494, 435);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LauncherForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

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

        private void AgenciaActualCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgenciaAlmacen.AgenciaActual = AgenciaActualCombo.SelectedItem as AgenciaEntidad;
        }

        private void CdActualCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CentroDistribucionAlmacen.centroDistribucionActual = CdActualCombo.SelectedItem as CentroDistribucionEntidad;
        }
    }
}
