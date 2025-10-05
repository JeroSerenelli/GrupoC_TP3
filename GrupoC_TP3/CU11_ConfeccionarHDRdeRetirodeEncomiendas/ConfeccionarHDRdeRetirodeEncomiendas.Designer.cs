namespace GrupoC_TP3.CU11_ConfeccionarHDRdeRetirodeEncomiendas
{
    partial class ConfeccionarHDRdeRetirodeEncomiendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BusquedaRetiroGroupBox = new GroupBox();
            MetodoDeEntregarRetiroLabel = new Label();
            MetodoEntregaRetiroComboBox = new ComboBox();
            EntregaRetiroLabel = new Label();
            EstadoRetiroComboBox = new ComboBox();
            BuscarRetiroButton = new Button();
            ListadoEncomendasEntregalistView = new ListView();
            NumeroDeEncomiendaHDRRetiro = new ColumnHeader();
            ClienteHDRRetiro = new ColumnHeader();
            OrigenHDRRetiro = new ColumnHeader();
            DestinoHDRRetiro = new ColumnHeader();
            TelefonoHDRRetiro = new ColumnHeader();
            GenerarHDRRetirobutton = new Button();
            ImprimirHDRRetiroButton = new Button();
            ListadoRetirogroupBox = new GroupBox();
            FechaRetiroLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            BusquedaRetiroGroupBox.SuspendLayout();
            ListadoRetirogroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // BusquedaRetiroGroupBox
            // 
            BusquedaRetiroGroupBox.Controls.Add(dateTimePicker1);
            BusquedaRetiroGroupBox.Controls.Add(FechaRetiroLabel);
            BusquedaRetiroGroupBox.Controls.Add(BuscarRetiroButton);
            BusquedaRetiroGroupBox.Controls.Add(EstadoRetiroComboBox);
            BusquedaRetiroGroupBox.Controls.Add(EntregaRetiroLabel);
            BusquedaRetiroGroupBox.Controls.Add(MetodoEntregaRetiroComboBox);
            BusquedaRetiroGroupBox.Controls.Add(MetodoDeEntregarRetiroLabel);
            BusquedaRetiroGroupBox.Location = new Point(24, 49);
            BusquedaRetiroGroupBox.Name = "BusquedaRetiroGroupBox";
            BusquedaRetiroGroupBox.Size = new Size(749, 192);
            BusquedaRetiroGroupBox.TabIndex = 0;
            BusquedaRetiroGroupBox.TabStop = false;
            BusquedaRetiroGroupBox.Text = "Buscar Encomiendas";
            // 
            // MetodoDeEntregarRetiroLabel
            // 
            MetodoDeEntregarRetiroLabel.AutoSize = true;
            MetodoDeEntregarRetiroLabel.Location = new Point(52, 57);
            MetodoDeEntregarRetiroLabel.Name = "MetodoDeEntregarRetiroLabel";
            MetodoDeEntregarRetiroLabel.Size = new Size(108, 15);
            MetodoDeEntregarRetiroLabel.TabIndex = 0;
            MetodoDeEntregarRetiroLabel.Text = "Metodo de Entrega";
            // 
            // MetodoEntregaRetiroComboBox
            // 
            MetodoEntregaRetiroComboBox.FormattingEnabled = true;
            MetodoEntregaRetiroComboBox.Location = new Point(183, 54);
            MetodoEntregaRetiroComboBox.Name = "MetodoEntregaRetiroComboBox";
            MetodoEntregaRetiroComboBox.Size = new Size(200, 23);
            MetodoEntregaRetiroComboBox.TabIndex = 1;
            // 
            // EntregaRetiroLabel
            // 
            EntregaRetiroLabel.AutoSize = true;
            EntregaRetiroLabel.Location = new Point(52, 100);
            EntregaRetiroLabel.Name = "EntregaRetiroLabel";
            EntregaRetiroLabel.Size = new Size(42, 15);
            EntregaRetiroLabel.TabIndex = 2;
            EntregaRetiroLabel.Text = "Estado";
            // 
            // EstadoRetiroComboBox
            // 
            EstadoRetiroComboBox.FormattingEnabled = true;
            EstadoRetiroComboBox.Location = new Point(183, 94);
            EstadoRetiroComboBox.Name = "EstadoRetiroComboBox";
            EstadoRetiroComboBox.Size = new Size(200, 23);
            EstadoRetiroComboBox.TabIndex = 3;
            // 
            // BuscarRetiroButton
            // 
            BuscarRetiroButton.Location = new Point(629, 153);
            BuscarRetiroButton.Name = "BuscarRetiroButton";
            BuscarRetiroButton.Size = new Size(112, 33);
            BuscarRetiroButton.TabIndex = 4;
            BuscarRetiroButton.Text = "Buscar";
            BuscarRetiroButton.UseVisualStyleBackColor = true;
            // 
            // ListadoEncomendasEntregalistView
            // 
            ListadoEncomendasEntregalistView.Columns.AddRange(new ColumnHeader[] { NumeroDeEncomiendaHDRRetiro, ClienteHDRRetiro, OrigenHDRRetiro, DestinoHDRRetiro, TelefonoHDRRetiro });
            ListadoEncomendasEntregalistView.GridLines = true;
            ListadoEncomendasEntregalistView.Location = new Point(52, 42);
            ListadoEncomendasEntregalistView.Name = "ListadoEncomendasEntregalistView";
            ListadoEncomendasEntregalistView.Size = new Size(614, 86);
            ListadoEncomendasEntregalistView.TabIndex = 5;
            ListadoEncomendasEntregalistView.UseCompatibleStateImageBehavior = false;
            ListadoEncomendasEntregalistView.View = View.Details;
            // 
            // NumeroDeEncomiendaHDRRetiro
            // 
            NumeroDeEncomiendaHDRRetiro.Text = "Numero de encomienda";
            NumeroDeEncomiendaHDRRetiro.Width = 150;
            // 
            // ClienteHDRRetiro
            // 
            ClienteHDRRetiro.Text = "Cliente";
            ClienteHDRRetiro.Width = 120;
            // 
            // OrigenHDRRetiro
            // 
            OrigenHDRRetiro.Text = "Origen";
            OrigenHDRRetiro.Width = 120;
            // 
            // DestinoHDRRetiro
            // 
            DestinoHDRRetiro.Text = "Destino";
            DestinoHDRRetiro.Width = 120;
            // 
            // TelefonoHDRRetiro
            // 
            TelefonoHDRRetiro.Text = "Telefono";
            TelefonoHDRRetiro.Width = 100;
            // 
            // GenerarHDRRetirobutton
            // 
            GenerarHDRRetirobutton.Location = new Point(467, 163);
            GenerarHDRRetirobutton.Name = "GenerarHDRRetirobutton";
            GenerarHDRRetirobutton.Size = new Size(130, 38);
            GenerarHDRRetirobutton.TabIndex = 6;
            GenerarHDRRetirobutton.Text = "Generar Hoja de Ruta ";
            GenerarHDRRetirobutton.UseVisualStyleBackColor = true;
            GenerarHDRRetirobutton.Click += button2_Click;
            // 
            // ImprimirHDRRetiroButton
            // 
            ImprimirHDRRetiroButton.Location = new Point(644, 163);
            ImprimirHDRRetiroButton.Name = "ImprimirHDRRetiroButton";
            ImprimirHDRRetiroButton.Size = new Size(97, 38);
            ImprimirHDRRetiroButton.TabIndex = 7;
            ImprimirHDRRetiroButton.Text = "Imprimir";
            ImprimirHDRRetiroButton.UseVisualStyleBackColor = true;
            // 
            // ListadoRetirogroupBox
            // 
            ListadoRetirogroupBox.Controls.Add(ImprimirHDRRetiroButton);
            ListadoRetirogroupBox.Controls.Add(ListadoEncomendasEntregalistView);
            ListadoRetirogroupBox.Controls.Add(GenerarHDRRetirobutton);
            ListadoRetirogroupBox.Location = new Point(24, 306);
            ListadoRetirogroupBox.Name = "ListadoRetirogroupBox";
            ListadoRetirogroupBox.Size = new Size(749, 207);
            ListadoRetirogroupBox.TabIndex = 1;
            ListadoRetirogroupBox.TabStop = false;
            ListadoRetirogroupBox.Text = "Generar Hoja de Ruta";
            // 
            // FechaRetiroLabel
            // 
            FechaRetiroLabel.AutoSize = true;
            FechaRetiroLabel.Location = new Point(56, 153);
            FechaRetiroLabel.Name = "FechaRetiroLabel";
            FechaRetiroLabel.Size = new Size(38, 15);
            FechaRetiroLabel.TabIndex = 5;
            FechaRetiroLabel.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(183, 147);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // ConfeccionarHDRdeRetirodeEncomiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 662);
            Controls.Add(ListadoRetirogroupBox);
            Controls.Add(BusquedaRetiroGroupBox);
            Name = "ConfeccionarHDRdeRetirodeEncomiendas";
            Text = "Confeccionar Hoja de Ruta de Retiro de Encomiendas";
            BusquedaRetiroGroupBox.ResumeLayout(false);
            BusquedaRetiroGroupBox.PerformLayout();
            ListadoRetirogroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BusquedaRetiroGroupBox;
        private Button GenerarHDRRetirobutton;
        private ListView ListadoEncomendasEntregalistView;
        private ColumnHeader NumeroDeEncomiendaHDRRetiro;
        private ColumnHeader ClienteHDRRetiro;
        private ColumnHeader OrigenHDRRetiro;
        private ColumnHeader DestinoHDRRetiro;
        private ColumnHeader TelefonoHDRRetiro;
        private Button BuscarRetiroButton;
        private ComboBox EstadoRetiroComboBox;
        private Label EntregaRetiroLabel;
        private ComboBox MetodoEntregaRetiroComboBox;
        private Label MetodoDeEntregarRetiroLabel;
        private Button ImprimirHDRRetiroButton;
        private DateTimePicker dateTimePicker1;
        private Label FechaRetiroLabel;
        private GroupBox ListadoRetirogroupBox;
    }
}