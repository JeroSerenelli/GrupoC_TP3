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
            razonSocialList = new ListView();
            RazonSocial = new ColumnHeader();
            cuitColumn = new ColumnHeader();
            nombreSolicitante = new ColumnHeader();
            apellidoSolicitante = new ColumnHeader();
            button1 = new Button();
            groupBox2 = new GroupBox();
            cuentaCorrienteLstView = new ListView();
            Nro_ClienteHeader = new ColumnHeader();
            TipoDeOperacionHeader = new ColumnHeader();
            MontoHeader = new ColumnHeader();
            fileSystemWatcher1 = new FileSystemWatcher();
            label4 = new Label();
            FechaHeader = new ColumnHeader();
            SaldoHeader = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Razon Social:";
            label1.Click += label1_Click;
            // 
            // razonSocialTxt
            // 
            razonSocialTxt.Location = new Point(143, 36);
            razonSocialTxt.Name = "razonSocialTxt";
            razonSocialTxt.Size = new Size(154, 27);
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
            groupBox1.Controls.Add(razonSocialList);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(razonSocialTxt);
            groupBox1.Location = new Point(29, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 261);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 233);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 13;
            label3.Text = "Fin de Periodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 194);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 12;
            label2.Text = "Incio de Periodo:";
            label2.Click += label2_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(490, 240);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(8, 27);
            dateTimePicker3.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(143, 189);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 10;
            dateTimePicker2.Value = new DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(143, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2025, 10, 2, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(409, 189);
            button4.Name = "button4";
            button4.Size = new Size(142, 66);
            button4.TabIndex = 6;
            button4.Text = "Mostrar Cuenta Corriente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // razonSocialList
            // 
            razonSocialList.Columns.AddRange(new ColumnHeader[] { RazonSocial, cuitColumn, nombreSolicitante, apellidoSolicitante });
            razonSocialList.Location = new Point(22, 90);
            razonSocialList.Name = "razonSocialList";
            razonSocialList.Size = new Size(682, 81);
            razonSocialList.TabIndex = 5;
            razonSocialList.UseCompatibleStateImageBehavior = false;
            razonSocialList.View = View.Details;
            razonSocialList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // RazonSocial
            // 
            RazonSocial.Text = "Razon Social";
            RazonSocial.Width = 120;
            // 
            // cuitColumn
            // 
            cuitColumn.Text = "CUIT/CUIL";
            cuitColumn.Width = 120;
            // 
            // nombreSolicitante
            // 
            nombreSolicitante.Text = "Nombre Solicitante";
            nombreSolicitante.Width = 160;
            // 
            // apellidoSolicitante
            // 
            apellidoSolicitante.Text = "Apellido Solicitante";
            apellidoSolicitante.Width = 160;
            // 
            // button1
            // 
            button1.Location = new Point(317, 34);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cuentaCorrienteLstView);
            groupBox2.Location = new Point(29, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 217);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuenta Corriente";
            // 
            // cuentaCorrienteLstView
            // 
            cuentaCorrienteLstView.Columns.AddRange(new ColumnHeader[] { Nro_ClienteHeader, FechaHeader, TipoDeOperacionHeader, MontoHeader, SaldoHeader });
            cuentaCorrienteLstView.Location = new Point(22, 42);
            cuentaCorrienteLstView.Name = "cuentaCorrienteLstView";
            cuentaCorrienteLstView.Size = new Size(682, 153);
            cuentaCorrienteLstView.TabIndex = 2;
            cuentaCorrienteLstView.UseCompatibleStateImageBehavior = false;
            cuentaCorrienteLstView.View = View.Details;
            // 
            // Nro_ClienteHeader
            // 
            Nro_ClienteHeader.Text = "Número de Cliente";
            Nro_ClienteHeader.Width = 150;
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
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(493, 12);
            label4.Name = "label4";
            label4.Size = new Size(242, 37);
            label4.TabIndex = 9;
            label4.Text = "TUTASA Agencias";
            // 
            // FechaHeader
            // 
            FechaHeader.Text = "Fecha";
            FechaHeader.Width = 80;
            // 
            // SaldoHeader
            // 
            SaldoHeader.Text = "Saldo";
            SaldoHeader.Width = 140;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 519);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Facturas";
            Text = "CU2: Estado de Cuenta Corriente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ListView razonSocialList;
        private ColumnHeader RazonSocial;
        private ColumnHeader cuitColumn;
        private ColumnHeader nombreSolicitante;
        private Button button4;
        private Label label2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private FileSystemWatcher fileSystemWatcher1;
        private ColumnHeader apellidoSolicitante;
        private Label label4;
        private ColumnHeader FechaHeader;
        private ColumnHeader SaldoHeader;
    }
}