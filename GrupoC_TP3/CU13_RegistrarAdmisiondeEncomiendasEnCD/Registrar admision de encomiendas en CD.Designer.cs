namespace GrupoC_TP3
{
    partial class RegistrarEncomiendas
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            BuscarEncomiendaTransporteButton = new Button();
            NumeroEncomiendaAdmisionTextBox = new TextBox();
            NumeroEncomiendaTransporteLabel = new Label();
            ListaEncomiendasListView = new ListView();
            NumeroEncomiendasAdmision = new ColumnHeader();
            ClienteAdmision = new ColumnHeader();
            TamañoAdmision = new ColumnHeader();
            PesoAdmision = new ColumnHeader();
            EstadoAdmision = new ColumnHeader();
            groupBox2 = new GroupBox();
            MofigicarEstadoTransporteButton = new Button();
            ValidarAdmisionComboBox = new ComboBox();
            label4 = new Label();
            ConfirmarAdmisionButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "TUTASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 49);
            label2.Name = "label2";
            label2.Size = new Size(249, 15);
            label2.TabIndex = 3;
            label2.Text = "Transportes Urbanos Terrestres Argentinos S.A";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BuscarEncomiendaTransporteButton);
            groupBox1.Controls.Add(NumeroEncomiendaAdmisionTextBox);
            groupBox1.Controls.Add(NumeroEncomiendaTransporteLabel);
            groupBox1.Location = new Point(32, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 87);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // BuscarEncomiendaTransporteButton
            // 
            BuscarEncomiendaTransporteButton.Location = new Point(591, 39);
            BuscarEncomiendaTransporteButton.Name = "BuscarEncomiendaTransporteButton";
            BuscarEncomiendaTransporteButton.Size = new Size(75, 23);
            BuscarEncomiendaTransporteButton.TabIndex = 3;
            BuscarEncomiendaTransporteButton.Text = "Buscar";
            BuscarEncomiendaTransporteButton.UseVisualStyleBackColor = true;
            // 
            // NumeroEncomiendaAdmisionTextBox
            // 
            NumeroEncomiendaAdmisionTextBox.Location = new Point(223, 31);
            NumeroEncomiendaAdmisionTextBox.Name = "NumeroEncomiendaAdmisionTextBox";
            NumeroEncomiendaAdmisionTextBox.Size = new Size(188, 23);
            NumeroEncomiendaAdmisionTextBox.TabIndex = 1;
            // 
            // NumeroEncomiendaTransporteLabel
            // 
            NumeroEncomiendaTransporteLabel.AutoSize = true;
            NumeroEncomiendaTransporteLabel.Location = new Point(26, 39);
            NumeroEncomiendaTransporteLabel.Name = "NumeroEncomiendaTransporteLabel";
            NumeroEncomiendaTransporteLabel.Size = new Size(148, 15);
            NumeroEncomiendaTransporteLabel.TabIndex = 0;
            NumeroEncomiendaTransporteLabel.Text = "Numero de la encomienda";
            // 
            // ListaEncomiendasListView
            // 
            ListaEncomiendasListView.Columns.AddRange(new ColumnHeader[] { NumeroEncomiendasAdmision, ClienteAdmision, TamañoAdmision, PesoAdmision, EstadoAdmision });
            ListaEncomiendasListView.GridLines = true;
            ListaEncomiendasListView.Location = new Point(52, 31);
            ListaEncomiendasListView.Name = "ListaEncomiendasListView";
            ListaEncomiendasListView.Size = new Size(542, 100);
            ListaEncomiendasListView.TabIndex = 2;
            ListaEncomiendasListView.UseCompatibleStateImageBehavior = false;
            ListaEncomiendasListView.View = View.Details;
            // 
            // NumeroEncomiendasAdmision
            // 
            NumeroEncomiendasAdmision.Text = "Numero de Encomiendas";
            NumeroEncomiendasAdmision.Width = 120;
            // 
            // ClienteAdmision
            // 
            ClienteAdmision.Text = "Cliente";
            ClienteAdmision.Width = 120;
            // 
            // TamañoAdmision
            // 
            TamañoAdmision.Text = "Tamaño";
            TamañoAdmision.Width = 100;
            // 
            // PesoAdmision
            // 
            PesoAdmision.Text = "Peso";
            PesoAdmision.Width = 100;
            // 
            // EstadoAdmision
            // 
            EstadoAdmision.Text = "Estado";
            EstadoAdmision.Width = 100;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MofigicarEstadoTransporteButton);
            groupBox2.Controls.Add(ValidarAdmisionComboBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(ListaEncomiendasListView);
            groupBox2.Location = new Point(32, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(686, 203);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // MofigicarEstadoTransporteButton
            // 
            MofigicarEstadoTransporteButton.Location = new Point(591, 161);
            MofigicarEstadoTransporteButton.Name = "MofigicarEstadoTransporteButton";
            MofigicarEstadoTransporteButton.Size = new Size(75, 23);
            MofigicarEstadoTransporteButton.TabIndex = 5;
            MofigicarEstadoTransporteButton.Text = "Modificar";
            MofigicarEstadoTransporteButton.UseVisualStyleBackColor = true;
            // 
            // ValidarAdmisionComboBox
            // 
            ValidarAdmisionComboBox.FormattingEnabled = true;
            ValidarAdmisionComboBox.Items.AddRange(new object[] { "Aprobar", "Modificar" });
            ValidarAdmisionComboBox.Location = new Point(123, 161);
            ValidarAdmisionComboBox.Name = "ValidarAdmisionComboBox";
            ValidarAdmisionComboBox.Size = new Size(121, 23);
            ValidarAdmisionComboBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 164);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Validar";
            // 
            // ConfirmarAdmisionButton
            // 
            ConfirmarAdmisionButton.Location = new Point(623, 455);
            ConfirmarAdmisionButton.Name = "ConfirmarAdmisionButton";
            ConfirmarAdmisionButton.Size = new Size(75, 26);
            ConfirmarAdmisionButton.TabIndex = 6;
            ConfirmarAdmisionButton.Text = "Confirmar";
            ConfirmarAdmisionButton.UseVisualStyleBackColor = true;
            // 
            // RegistrarEncomiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 502);
            Controls.Add(ConfirmarAdmisionButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarEncomiendas";
            Text = "Registrar Admision de Encomiendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label NumeroEncomiendaTransporteLabel;
        private Button BuscarEncomiendaTransporteButton;
        private TextBox NumeroEncomiendaAdmisionTextBox;
        private ListView ListaEncomiendasListView;
        private ColumnHeader NumeroEncomiendasAdmision;
        private ColumnHeader ClienteAdmision;
        private ColumnHeader TamañoAdmision;
        private ColumnHeader PesoAdmision;
        private ColumnHeader EstadoAdmision;
        private GroupBox groupBox2;
        private Button MofigicarEstadoTransporteButton;
        private ComboBox ValidarAdmisionComboBox;
        private Label label4;
        private Button ConfirmarAdmisionButton;
    }
}