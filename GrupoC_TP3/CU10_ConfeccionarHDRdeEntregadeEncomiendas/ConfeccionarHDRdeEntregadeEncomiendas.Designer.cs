namespace GrupoC_TP3.CU10_ConfeccionarHDRdeEntregadeEncomiendas
{
    partial class ConfeccionarHDRdeEntregadeEncomiendas
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
            BuscarEncomiendasEntregagroupBox1 = new GroupBox();
            label1 = new Label();
            MetododeEntregaEntregaComboBox = new ComboBox();
            label2 = new Label();
            EstadoEntregaComboBox = new ComboBox();
            ListaHDREntregaListView = new ListView();
            NumerodeEncomiendasHDREntrega = new ColumnHeader();
            ClienteHDREntrega = new ColumnHeader();
            OrigenHDREntrega = new ColumnHeader();
            DestinoHDREntrega = new ColumnHeader();
            TelefonoHDREntrega = new ColumnHeader();
            CantidaddePaquetesHDREntrega = new ColumnHeader();
            BuscarEncomiendaEntregaButton = new Button();
            GenerarHDREntregaButton = new Button();
            ImprimirHDREntregaButton = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            FechaEntregaLabel = new Label();
            FechaEntregaDateTimePicker1 = new DateTimePicker();
            BuscarEncomiendasEntregagroupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // BuscarEncomiendasEntregagroupBox1
            // 
            BuscarEncomiendasEntregagroupBox1.Controls.Add(FechaEntregaDateTimePicker1);
            BuscarEncomiendasEntregagroupBox1.Controls.Add(FechaEntregaLabel);
            BuscarEncomiendasEntregagroupBox1.Controls.Add(BuscarEncomiendaEntregaButton);
            BuscarEncomiendasEntregagroupBox1.Controls.Add(EstadoEntregaComboBox);
            BuscarEncomiendasEntregagroupBox1.Controls.Add(label2);
            BuscarEncomiendasEntregagroupBox1.Controls.Add(MetododeEntregaEntregaComboBox);
            BuscarEncomiendasEntregagroupBox1.Controls.Add(label1);
            BuscarEncomiendasEntregagroupBox1.Location = new Point(40, 30);
            BuscarEncomiendasEntregagroupBox1.Name = "BuscarEncomiendasEntregagroupBox1";
            BuscarEncomiendasEntregagroupBox1.Size = new Size(653, 181);
            BuscarEncomiendasEntregagroupBox1.TabIndex = 0;
            BuscarEncomiendasEntregagroupBox1.TabStop = false;
            BuscarEncomiendasEntregagroupBox1.Text = "Buscar Encomiendas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 60);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Metodo de entrega";
            // 
            // MetododeEntregaEntregaComboBox
            // 
            MetododeEntregaEntregaComboBox.FormattingEnabled = true;
            MetododeEntregaEntregaComboBox.Items.AddRange(new object[] { "Entrega en domicilio", "Entrega en CD destino", "Entrega en Agencia" });
            MetododeEntregaEntregaComboBox.Location = new Point(202, 57);
            MetododeEntregaEntregaComboBox.Name = "MetododeEntregaEntregaComboBox";
            MetododeEntregaEntregaComboBox.Size = new Size(231, 23);
            MetododeEntregaEntregaComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 101);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Estado";
            // 
            // EstadoEntregaComboBox
            // 
            EstadoEntregaComboBox.FormattingEnabled = true;
            EstadoEntregaComboBox.Location = new Point(202, 98);
            EstadoEntregaComboBox.Name = "EstadoEntregaComboBox";
            EstadoEntregaComboBox.Size = new Size(231, 23);
            EstadoEntregaComboBox.TabIndex = 3;
            // 
            // ListaHDREntregaListView
            // 
            ListaHDREntregaListView.Columns.AddRange(new ColumnHeader[] { NumerodeEncomiendasHDREntrega, ClienteHDREntrega, OrigenHDREntrega, DestinoHDREntrega, TelefonoHDREntrega, CantidaddePaquetesHDREntrega });
            ListaHDREntregaListView.GridLines = true;
            ListaHDREntregaListView.Location = new Point(24, 22);
            ListaHDREntregaListView.Name = "ListaHDREntregaListView";
            ListaHDREntregaListView.Size = new Size(604, 97);
            ListaHDREntregaListView.TabIndex = 4;
            ListaHDREntregaListView.UseCompatibleStateImageBehavior = false;
            ListaHDREntregaListView.View = View.Details;
            // 
            // NumerodeEncomiendasHDREntrega
            // 
            NumerodeEncomiendasHDREntrega.Text = "Numero de encomienda";
            NumerodeEncomiendasHDREntrega.Width = 100;
            // 
            // ClienteHDREntrega
            // 
            ClienteHDREntrega.Text = "Cliente";
            ClienteHDREntrega.Width = 100;
            // 
            // OrigenHDREntrega
            // 
            OrigenHDREntrega.Text = "Origen";
            OrigenHDREntrega.Width = 100;
            // 
            // DestinoHDREntrega
            // 
            DestinoHDREntrega.Text = "Destino";
            DestinoHDREntrega.Width = 100;
            // 
            // TelefonoHDREntrega
            // 
            TelefonoHDREntrega.Text = "Telefono";
            TelefonoHDREntrega.Width = 100;
            // 
            // CantidaddePaquetesHDREntrega
            // 
            CantidaddePaquetesHDREntrega.Text = "N° de paquetes";
            CantidaddePaquetesHDREntrega.Width = 100;
            // 
            // BuscarEncomiendaEntregaButton
            // 
            BuscarEncomiendaEntregaButton.Location = new Point(517, 126);
            BuscarEncomiendaEntregaButton.Name = "BuscarEncomiendaEntregaButton";
            BuscarEncomiendaEntregaButton.Size = new Size(110, 37);
            BuscarEncomiendaEntregaButton.TabIndex = 5;
            BuscarEncomiendaEntregaButton.Text = "Buscar";
            BuscarEncomiendaEntregaButton.UseVisualStyleBackColor = true;
            // 
            // GenerarHDREntregaButton
            // 
            GenerarHDREntregaButton.Location = new Point(342, 159);
            GenerarHDREntregaButton.Name = "GenerarHDREntregaButton";
            GenerarHDREntregaButton.Size = new Size(131, 34);
            GenerarHDREntregaButton.TabIndex = 6;
            GenerarHDREntregaButton.Text = "Generar Hoja de Ruta";
            GenerarHDREntregaButton.UseVisualStyleBackColor = true;
            // 
            // ImprimirHDREntregaButton
            // 
            ImprimirHDREntregaButton.Location = new Point(518, 159);
            ImprimirHDREntregaButton.Name = "ImprimirHDREntregaButton";
            ImprimirHDREntregaButton.Size = new Size(110, 34);
            ImprimirHDREntregaButton.TabIndex = 7;
            ImprimirHDREntregaButton.Text = "Imprimir";
            ImprimirHDREntregaButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(464, 514);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(8, 8);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ImprimirHDREntregaButton);
            groupBox3.Controls.Add(ListaHDREntregaListView);
            groupBox3.Controls.Add(GenerarHDREntregaButton);
            groupBox3.Location = new Point(39, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(654, 199);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Generar Hoja de Ruta ";
            // 
            // FechaEntregaLabel
            // 
            FechaEntregaLabel.AutoSize = true;
            FechaEntregaLabel.Location = new Point(61, 138);
            FechaEntregaLabel.Name = "FechaEntregaLabel";
            FechaEntregaLabel.Size = new Size(38, 15);
            FechaEntregaLabel.TabIndex = 6;
            FechaEntregaLabel.Text = "Fecha";
            // 
            // FechaEntregaDateTimePicker1
            // 
            FechaEntregaDateTimePicker1.Location = new Point(202, 138);
            FechaEntregaDateTimePicker1.Name = "FechaEntregaDateTimePicker1";
            FechaEntregaDateTimePicker1.Size = new Size(231, 23);
            FechaEntregaDateTimePicker1.TabIndex = 7;
            // 
            // ConfeccionarHDRdeEntregadeEncomiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 501);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(BuscarEncomiendasEntregagroupBox1);
            Name = "ConfeccionarHDRdeEntregadeEncomiendas";
            Text = "Confeccionar Hoja de Ruta de Entrega de Encomiendas";
            BuscarEncomiendasEntregagroupBox1.ResumeLayout(false);
            BuscarEncomiendasEntregagroupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BuscarEncomiendasEntregagroupBox1;
        private ComboBox EstadoEntregaComboBox;
        private Label label2;
        private ComboBox MetododeEntregaEntregaComboBox;
        private Label label1;
        private Button ImprimirHDREntregaButton;
        private Button GenerarHDREntregaButton;
        private Button BuscarEncomiendaEntregaButton;
        private ListView ListaHDREntregaListView;
        private ColumnHeader NumerodeEncomiendasHDREntrega;
        private ColumnHeader ClienteHDREntrega;
        private ColumnHeader OrigenHDREntrega;
        private ColumnHeader DestinoHDREntrega;
        private ColumnHeader TelefonoHDREntrega;
        private ColumnHeader CantidaddePaquetesHDREntrega;
        private DateTimePicker FechaEntregaDateTimePicker1;
        private Label FechaEntregaLabel;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}