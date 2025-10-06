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
            razonSocialTxt = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            cuentaCorrienteLstView = new ListView();
            Nro_ClienteHeader = new ColumnHeader();
            FechaHeader = new ColumnHeader();
            TipoDeOperacionHeader = new ColumnHeader();
            MontoHeader = new ColumnHeader();
            SaldoHeader = new ColumnHeader();
            fileSystemWatcher1 = new FileSystemWatcher();
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
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "CUIT/CUIL:";
            label1.Click += label1_Click;
            // 
            // razonSocialTxt
            // 
            razonSocialTxt.Location = new Point(125, 27);
            razonSocialTxt.Margin = new Padding(3, 2, 3, 2);
            razonSocialTxt.Name = "razonSocialTxt";
            razonSocialTxt.Size = new Size(135, 23);
            razonSocialTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(razonSocialTxt);
            groupBox1.Location = new Point(25, 26);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(631, 127);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 92);
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
            label2.Size = new Size(96, 15);
            label2.TabIndex = 12;
            label2.Text = "Incio de Periodo:";
            label2.Click += label2_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(431, 97);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(8, 23);
            dateTimePicker3.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(127, 59);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 10;
            dateTimePicker2.Value = new DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 88);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2025, 10, 2, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(360, 59);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(124, 50);
            button4.TabIndex = 6;
            button4.Text = "Mostrar Cuenta Corriente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(277, 26);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cuentaCorrienteLstView);
            groupBox2.Location = new Point(25, 168);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(631, 163);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuenta Corriente";
            // 
            // cuentaCorrienteLstView
            // 
            cuentaCorrienteLstView.Columns.AddRange(new ColumnHeader[] { Nro_ClienteHeader, FechaHeader, TipoDeOperacionHeader, MontoHeader, SaldoHeader });
            cuentaCorrienteLstView.Location = new Point(19, 32);
            cuentaCorrienteLstView.Margin = new Padding(3, 2, 3, 2);
            cuentaCorrienteLstView.Name = "cuentaCorrienteLstView";
            cuentaCorrienteLstView.Size = new Size(597, 116);
            cuentaCorrienteLstView.TabIndex = 2;
            cuentaCorrienteLstView.UseCompatibleStateImageBehavior = false;
            cuentaCorrienteLstView.View = View.Details;
            // 
            // Nro_ClienteHeader
            // 
            Nro_ClienteHeader.Text = "CUIT/CUIL";
            Nro_ClienteHeader.Width = 150;
            // 
            // FechaHeader
            // 
            FechaHeader.Text = "Fecha";
            FechaHeader.Width = 80;
            // 
            // TipoDeOperacionHeader
            // 
            TipoDeOperacionHeader.Text = "Tipo de Operación";
            TipoDeOperacionHeader.Width = 150;
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
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 340);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Facturas";
            Text = "CU2: Estado de Cuenta Corriente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox razonSocialTxt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private ListView cuentaCorrienteLstView;
        private ColumnHeader Nro_ClienteHeader;
        private ColumnHeader TipoDeOperacionHeader;
        private ColumnHeader MontoHeader;
        private Button button4;
        private Label label2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private FileSystemWatcher fileSystemWatcher1;
        private ColumnHeader FechaHeader;
        private ColumnHeader SaldoHeader;
    }
}