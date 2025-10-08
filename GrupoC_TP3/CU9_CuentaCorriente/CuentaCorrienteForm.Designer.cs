namespace GrupoC_TP3
{
    partial class Facturas
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBoxCuitCuil = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFin = new DateTimePicker();
            buttonBuscarCliente = new Button();
            groupBox2 = new GroupBox();
            textBoxFin = new TextBox();
            textBoxInicio = new TextBox();
            textBoxCliente = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            listViewCuentaCorriente = new ListView();
            FechaHeader = new ColumnHeader();
            MontoHeader = new ColumnHeader();
            SaldoHeader = new ColumnHeader();
            fileSystemWatcher1 = new FileSystemWatcher();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "CUIT/CUIL:";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxCuitCuil);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePickerInicio);
            groupBox1.Controls.Add(dateTimePickerFin);
            groupBox1.Controls.Add(buttonBuscarCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 58);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(362, 163);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Búsqueda de Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBoxCuitCuil
            // 
            comboBoxCuitCuil.FormattingEnabled = true;
            comboBoxCuitCuil.Location = new Point(127, 26);
            comboBoxCuitCuil.Name = "comboBoxCuitCuil";
            comboBoxCuitCuil.Size = new Size(219, 23);
            comboBoxCuitCuil.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 94);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 13;
            label3.Text = "Fin de Periodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 63);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 12;
            label2.Text = "Inicio de Periodo:";
            label2.Click += label2_Click;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(127, 59);
            dateTimePickerInicio.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(219, 23);
            dateTimePickerInicio.TabIndex = 10;
            dateTimePickerInicio.Value = new DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(127, 88);
            dateTimePickerFin.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(219, 23);
            dateTimePickerFin.TabIndex = 9;
            dateTimePickerFin.Value = new DateTime(2025, 10, 2, 0, 0, 0, 0);
            dateTimePickerFin.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Location = new Point(264, 128);
            buttonBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(82, 22);
            buttonBuscarCliente.TabIndex = 2;
            buttonBuscarCliente.Text = "Buscar";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarClienteClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxFin);
            groupBox2.Controls.Add(textBoxInicio);
            groupBox2.Controls.Add(textBoxCliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(listViewCuentaCorriente);
            groupBox2.Location = new Point(17, 225);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(631, 238);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuenta Corriente";
            // 
            // textBoxFin
            // 
            textBoxFin.Location = new Point(423, 66);
            textBoxFin.Name = "textBoxFin";
            textBoxFin.ReadOnly = true;
            textBoxFin.Size = new Size(180, 23);
            textBoxFin.TabIndex = 19;
            // 
            // textBoxInicio
            // 
            textBoxInicio.Location = new Point(423, 35);
            textBoxInicio.Name = "textBoxInicio";
            textBoxInicio.ReadOnly = true;
            textBoxInicio.Size = new Size(180, 23);
            textBoxInicio.TabIndex = 18;
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(59, 35);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.ReadOnly = true;
            textBoxCliente.Size = new Size(230, 23);
            textBoxCliente.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(318, 69);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 16;
            label7.Text = "Fin de Periodo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 38);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 15;
            label6.Text = "Cliente:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(318, 38);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 15;
            label8.Text = "Inicio de Periodo:";
            // 
            // listViewCuentaCorriente
            // 
            listViewCuentaCorriente.Columns.AddRange(new ColumnHeader[] { FechaHeader, MontoHeader, SaldoHeader });
            listViewCuentaCorriente.Location = new Point(6, 99);
            listViewCuentaCorriente.Margin = new Padding(3, 2, 3, 2);
            listViewCuentaCorriente.Name = "listViewCuentaCorriente";
            listViewCuentaCorriente.Size = new Size(597, 116);
            listViewCuentaCorriente.TabIndex = 2;
            listViewCuentaCorriente.UseCompatibleStateImageBehavior = false;
            listViewCuentaCorriente.View = View.Details;
            // 
            // FechaHeader
            // 
            FechaHeader.Text = "Fecha";
            FechaHeader.Width = 80;
            // 
            // MontoHeader
            // 
            MontoHeader.Text = "Monto";
            MontoHeader.Width = 100;
            // 
            // SaldoHeader
            // 
            SaldoHeader.Text = "Saldo";
            SaldoHeader.Width = 140;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(195, 29);
            label4.Name = "label4";
            label4.Size = new Size(269, 15);
            label4.TabIndex = 10;
            label4.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(289, 9);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "TUTASA";
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 487);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Facturas";
            Text = "Estado de Cuenta Corriente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonBuscarCliente;
        private ListView listViewCuentaCorriente;
        private ColumnHeader MontoHeader;
        private Label label2;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFin;
        private Label label3;
        private FileSystemWatcher fileSystemWatcher1;
        private ColumnHeader FechaHeader;
        private ColumnHeader SaldoHeader;
        private ComboBox comboBoxCuitCuil;
        private Label label4;
        private Label label5;
        private TextBox textBoxFin;
        private TextBox textBoxInicio;
        private TextBox textBoxCliente;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}