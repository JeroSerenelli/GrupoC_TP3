namespace GrupoC_TP3.ResultadoCostosVsVentas
{
    partial class ResultadoCostosVsVentasForm
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
            label4 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            estadoDeResultadosbutton = new Button();
            razonSocialList = new ListView();
            EmpresaDeTransporteHeader = new ColumnHeader();
            cuitColumn = new ColumnHeader();
            button1 = new Button();
            label5 = new Label();
            razonSocialTxt = new TextBox();
            groupBox2 = new GroupBox();
            cuentaCorrienteLstView = new ListView();
            Nro_ClienteHeader = new ColumnHeader();
            FechaHeader = new ColumnHeader();
            TipoDeOperacionHeader = new ColumnHeader();
            MontoHeader = new ColumnHeader();
            SaldoHeader = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(493, 12);
            label4.Name = "label4";
            label4.Size = new Size(242, 37);
            label4.TabIndex = 10;
            label4.Text = "TUTASA Agencias";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(estadoDeResultadosbutton);
            groupBox1.Controls.Add(razonSocialList);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(razonSocialTxt);
            groupBox1.Location = new Point(29, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 261);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empresa de Servicio de Transporte";
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
            // 
            // estadoDeResultadosbutton
            // 
            estadoDeResultadosbutton.Location = new Point(409, 189);
            estadoDeResultadosbutton.Name = "estadoDeResultadosbutton";
            estadoDeResultadosbutton.Size = new Size(142, 66);
            estadoDeResultadosbutton.TabIndex = 6;
            estadoDeResultadosbutton.Text = "Generar Estado de Resultados";
            estadoDeResultadosbutton.UseVisualStyleBackColor = true;
            // 
            // razonSocialList
            // 
            razonSocialList.Columns.AddRange(new ColumnHeader[] { EmpresaDeTransporteHeader, cuitColumn });
            razonSocialList.Location = new Point(22, 90);
            razonSocialList.Name = "razonSocialList";
            razonSocialList.Size = new Size(682, 81);
            razonSocialList.TabIndex = 5;
            razonSocialList.UseCompatibleStateImageBehavior = false;
            razonSocialList.View = View.Details;
            // 
            // EmpresaDeTransporteHeader
            // 
            EmpresaDeTransporteHeader.Text = "Nombre de Emprsa";
            EmpresaDeTransporteHeader.Width = 160;
            // 
            // cuitColumn
            // 
            cuitColumn.Text = "CUIT";
            cuitColumn.Width = 120;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 39);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 0;
            label5.Text = "Razon Social:";
            // 
            // razonSocialTxt
            // 
            razonSocialTxt.Location = new Point(143, 36);
            razonSocialTxt.Name = "razonSocialTxt";
            razonSocialTxt.Size = new Size(154, 27);
            razonSocialTxt.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cuentaCorrienteLstView);
            groupBox2.Location = new Point(29, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 217);
            groupBox2.TabIndex = 12;
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
            // ResultadoCostosVsVentasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 519);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ResultadoCostosVsVentasForm";
            Text = "CU1: Estado de Resultados de Costos Vs Ventas por empresa de servicio de transporte";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button estadoDeResultadosbutton;
        private ListView razonSocialList;
        private ColumnHeader EmpresaDeTransporteHeader;
        private ColumnHeader cuitColumn;
        private Button button1;
        private Label label5;
        private TextBox razonSocialTxt;
        private GroupBox groupBox2;
        private ListView cuentaCorrienteLstView;
        private ColumnHeader Nro_ClienteHeader;
        private ColumnHeader FechaHeader;
        private ColumnHeader TipoDeOperacionHeader;
        private ColumnHeader MontoHeader;
        private ColumnHeader SaldoHeader;
    }
}