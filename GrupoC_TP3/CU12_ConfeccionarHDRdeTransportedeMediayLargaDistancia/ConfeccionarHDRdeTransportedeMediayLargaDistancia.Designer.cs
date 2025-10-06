namespace GrupoC_TP3.ConfeccionarHojaDeRuta
{
    partial class ConfeccionarHDRdeTransportedeMediayLargaDistancia
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
            DestinoEntrega1 = new ColumnHeader();
            ChoferesEntrega = new ColumnHeader();
            groupBox1BuscarEncomiendas = new GroupBox();
            CDOrigenTransporteLabel = new Label();
            CDDestinoTransporteLabel = new Label();
            EstadoTransporteLabel = new Label();
            ListaEncomiendasTransportelistView = new ListView();
            CDOrigenTransporteComboBox = new ComboBox();
            CDDestinoTransportecomboBox = new ComboBox();
            EstadoTransporteComboBox = new ComboBox();
            NumerodeEncomiendaTransporte = new ColumnHeader();
            CDOrigenTransporte = new ColumnHeader();
            CDDestinoTransporte = new ColumnHeader();
            ClienteTransporte = new ColumnHeader();
            GenerarHDRButton = new Button();
            ImprimirHDRTransporteButton = new Button();
            BuscarEncomiendasTransporteButton = new Button();
            GenerarHDRGroupBox = new GroupBox();
            FechaTransporteDateTimePicker = new DateTimePicker();
            FechaTransporteLabel = new Label();
            groupBox1BuscarEncomiendas.SuspendLayout();
            GenerarHDRGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DestinoEntrega1
            // 
            DestinoEntrega1.Text = "Destino";
            DestinoEntrega1.TextAlign = HorizontalAlignment.Center;
            DestinoEntrega1.Width = 100;
            // 
            // ChoferesEntrega
            // 
            ChoferesEntrega.Text = "Choferes";
            ChoferesEntrega.TextAlign = HorizontalAlignment.Center;
            ChoferesEntrega.Width = 100;
            // 
            // groupBox1BuscarEncomiendas
            // 
            groupBox1BuscarEncomiendas.Controls.Add(FechaTransporteLabel);
            groupBox1BuscarEncomiendas.Controls.Add(FechaTransporteDateTimePicker);
            groupBox1BuscarEncomiendas.Controls.Add(BuscarEncomiendasTransporteButton);
            groupBox1BuscarEncomiendas.Controls.Add(EstadoTransporteComboBox);
            groupBox1BuscarEncomiendas.Controls.Add(CDDestinoTransportecomboBox);
            groupBox1BuscarEncomiendas.Controls.Add(CDOrigenTransporteComboBox);
            groupBox1BuscarEncomiendas.Controls.Add(EstadoTransporteLabel);
            groupBox1BuscarEncomiendas.Controls.Add(CDDestinoTransporteLabel);
            groupBox1BuscarEncomiendas.Controls.Add(CDOrigenTransporteLabel);
            groupBox1BuscarEncomiendas.Location = new Point(56, 44);
            groupBox1BuscarEncomiendas.Name = "groupBox1BuscarEncomiendas";
            groupBox1BuscarEncomiendas.Size = new Size(669, 253);
            groupBox1BuscarEncomiendas.TabIndex = 0;
            groupBox1BuscarEncomiendas.TabStop = false;
            groupBox1BuscarEncomiendas.Text = "Buscar Encomiendas";
            groupBox1BuscarEncomiendas.Enter += this.groupBox1BuscarEncomiendas_Enter;
            // 
            // CDOrigenTransporteLabel
            // 
            CDOrigenTransporteLabel.AutoSize = true;
            CDOrigenTransporteLabel.Location = new Point(73, 85);
            CDOrigenTransporteLabel.Name = "CDOrigenTransporteLabel";
            CDOrigenTransporteLabel.Size = new Size(181, 15);
            CDOrigenTransporteLabel.TabIndex = 0;
            CDOrigenTransporteLabel.Text = "Centro de Distribucion de Origen";
            // 
            // CDDestinoTransporteLabel
            // 
            CDDestinoTransporteLabel.AutoSize = true;
            CDDestinoTransporteLabel.Location = new Point(73, 124);
            CDDestinoTransporteLabel.Name = "CDDestinoTransporteLabel";
            CDDestinoTransporteLabel.Size = new Size(185, 15);
            CDDestinoTransporteLabel.TabIndex = 1;
            CDDestinoTransporteLabel.Text = "Centro de Distribucion de Destino";
            // 
            // EstadoTransporteLabel
            // 
            EstadoTransporteLabel.AutoSize = true;
            EstadoTransporteLabel.Location = new Point(73, 165);
            EstadoTransporteLabel.Name = "EstadoTransporteLabel";
            EstadoTransporteLabel.Size = new Size(42, 15);
            EstadoTransporteLabel.TabIndex = 2;
            EstadoTransporteLabel.Text = "Estado";
            // 
            // ListaEncomiendasTransportelistView
            // 
            ListaEncomiendasTransportelistView.Columns.AddRange(new ColumnHeader[] { NumerodeEncomiendaTransporte, CDOrigenTransporte, CDDestinoTransporte, ClienteTransporte });
            ListaEncomiendasTransportelistView.GridLines = true;
            ListaEncomiendasTransportelistView.Location = new Point(32, 51);
            ListaEncomiendasTransportelistView.Name = "ListaEncomiendasTransportelistView";
            ListaEncomiendasTransportelistView.Size = new Size(605, 100);
            ListaEncomiendasTransportelistView.TabIndex = 3;
            ListaEncomiendasTransportelistView.UseCompatibleStateImageBehavior = false;
            ListaEncomiendasTransportelistView.View = View.Details;
            // 
            // CDOrigenTransporteComboBox
            // 
            CDOrigenTransporteComboBox.FormattingEnabled = true;
            CDOrigenTransporteComboBox.Location = new Point(305, 77);
            CDOrigenTransporteComboBox.Name = "CDOrigenTransporteComboBox";
            CDOrigenTransporteComboBox.Size = new Size(166, 23);
            CDOrigenTransporteComboBox.TabIndex = 4;
            // 
            // CDDestinoTransportecomboBox
            // 
            CDDestinoTransportecomboBox.FormattingEnabled = true;
            CDDestinoTransportecomboBox.Location = new Point(305, 124);
            CDDestinoTransportecomboBox.Name = "CDDestinoTransportecomboBox";
            CDDestinoTransportecomboBox.Size = new Size(166, 23);
            CDDestinoTransportecomboBox.TabIndex = 5;
            // 
            // EstadoTransporteComboBox
            // 
            EstadoTransporteComboBox.FormattingEnabled = true;
            EstadoTransporteComboBox.Location = new Point(305, 165);
            EstadoTransporteComboBox.Name = "EstadoTransporteComboBox";
            EstadoTransporteComboBox.Size = new Size(166, 23);
            EstadoTransporteComboBox.TabIndex = 6;
            // 
            // NumerodeEncomiendaTransporte
            // 
            NumerodeEncomiendaTransporte.Text = "Numero de encomienda";
            NumerodeEncomiendaTransporte.Width = 150;
            // 
            // CDOrigenTransporte
            // 
            CDOrigenTransporte.Text = "CD Origen";
            CDOrigenTransporte.Width = 150;
            // 
            // CDDestinoTransporte
            // 
            CDDestinoTransporte.Text = "CD Destino";
            CDDestinoTransporte.Width = 150;
            // 
            // ClienteTransporte
            // 
            ClienteTransporte.Text = "Cliente";
            ClienteTransporte.Width = 150;
            // 
            // GenerarHDRButton
            // 
            GenerarHDRButton.Location = new Point(363, 210);
            GenerarHDRButton.Name = "GenerarHDRButton";
            GenerarHDRButton.Size = new Size(131, 40);
            GenerarHDRButton.TabIndex = 7;
            GenerarHDRButton.Text = "Generar Hoja de Ruta";
            GenerarHDRButton.UseVisualStyleBackColor = true;
            GenerarHDRButton.Click += this.button1_Click;
            // 
            // ImprimirHDRTransporteButton
            // 
            ImprimirHDRTransporteButton.Location = new Point(541, 210);
            ImprimirHDRTransporteButton.Name = "ImprimirHDRTransporteButton";
            ImprimirHDRTransporteButton.Size = new Size(109, 40);
            ImprimirHDRTransporteButton.TabIndex = 8;
            ImprimirHDRTransporteButton.Text = "Imprimir";
            ImprimirHDRTransporteButton.UseVisualStyleBackColor = true;
            // 
            // BuscarEncomiendasTransporteButton
            // 
            BuscarEncomiendasTransporteButton.Location = new Point(554, 212);
            BuscarEncomiendasTransporteButton.Name = "BuscarEncomiendasTransporteButton";
            BuscarEncomiendasTransporteButton.Size = new Size(109, 27);
            BuscarEncomiendasTransporteButton.TabIndex = 9;
            BuscarEncomiendasTransporteButton.Text = "Buscar";
            BuscarEncomiendasTransporteButton.UseVisualStyleBackColor = true;
            // 
            // GenerarHDRGroupBox
            // 
            GenerarHDRGroupBox.Controls.Add(GenerarHDRButton);
            GenerarHDRGroupBox.Controls.Add(ListaEncomiendasTransportelistView);
            GenerarHDRGroupBox.Controls.Add(ImprimirHDRTransporteButton);
            GenerarHDRGroupBox.Location = new Point(56, 323);
            GenerarHDRGroupBox.Name = "GenerarHDRGroupBox";
            GenerarHDRGroupBox.Size = new Size(669, 250);
            GenerarHDRGroupBox.TabIndex = 1;
            GenerarHDRGroupBox.TabStop = false;
            GenerarHDRGroupBox.Text = "Generar Hoja de Ruta";
            // 
            // FechaTransporteDateTimePicker
            // 
            FechaTransporteDateTimePicker.Location = new Point(305, 212);
            FechaTransporteDateTimePicker.Name = "FechaTransporteDateTimePicker";
            FechaTransporteDateTimePicker.Size = new Size(200, 23);
            FechaTransporteDateTimePicker.TabIndex = 10;
            // 
            // FechaTransporteLabel
            // 
            FechaTransporteLabel.AutoSize = true;
            FechaTransporteLabel.Location = new Point(77, 212);
            FechaTransporteLabel.Name = "FechaTransporteLabel";
            FechaTransporteLabel.Size = new Size(41, 15);
            FechaTransporteLabel.TabIndex = 12;
            FechaTransporteLabel.Text = "Fecha ";
            // 
            // ConfeccionarHDRdeTransportedeMediayLargaDistancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 852);
            Controls.Add(GenerarHDRGroupBox);
            Controls.Add(groupBox1BuscarEncomiendas);
            Name = "ConfeccionarHDRdeTransportedeMediayLargaDistancia";
            Text = "Confeccionar Hoja de Ruta de Transporte de Media y Larga Distancia";
            Load += this.ConfeccionarHDRdeTransportedeMediayLargaDistancia_Load;
            groupBox1BuscarEncomiendas.ResumeLayout(false);
            groupBox1BuscarEncomiendas.PerformLayout();
            GenerarHDRGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label Numerodeencomienda;
        private TextBox NumerodeencomeindatextBox1;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private Button Agregar;
        private Button GenerarHDRButton;
        private Button ImprimirHDRTransporteButton;
        private ColumnHeader columnHeader2;
        private ColumnHeader DestinoEntrega1;
        private Label label9;
        private TextBox textBox1;
        private ColumnHeader ChoferesEntrega;
        private GroupBox groupBox1BuscarEncomiendas;
        private ComboBox EstadoTransporteComboBox;
        private ComboBox CDDestinoTransportecomboBox;
        private ComboBox CDOrigenTransporteComboBox;
        private ListView ListaEncomiendasTransportelistView;
        private ColumnHeader NumerodeEncomiendaTransporte;
        private ColumnHeader CDOrigenTransporte;
        private ColumnHeader CDDestinoTransporte;
        private ColumnHeader ClienteTransporte;
        private Label EstadoTransporteLabel;
        private Label CDDestinoTransporteLabel;
        private Label CDOrigenTransporteLabel;
        private Button BuscarEncomiendasTransporteButton;
        private GroupBox GenerarHDRGroupBox;
        private Label FechaTransporteLabel;
        private DateTimePicker FechaTransporteDateTimePicker;
    }
}