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
            IniciodateTimePicker = new DateTimePicker();
            FindateTimePicker = new DateTimePicker();
            estadoDeResultadosbutton = new Button();
            razonSocialList = new ListView();
            EmpresaDeTransporteHeader = new ColumnHeader();
            cuitColumn = new ColumnHeader();
            button1 = new Button();
            label5 = new Label();
            razonSocialTxt = new TextBox();
            groupBox2 = new GroupBox();
            ingresosPorVentaslabel = new Label();
            totalDeCostoslabel = new Label();
            ResultadoFinallabel = new Label();
            ingresosxVentastextBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ImprimirButton = new Button();
            ExportarXLSbutton = new Button();
            LimpiarButton = new Button();
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
            groupBox1.Controls.Add(IniciodateTimePicker);
            groupBox1.Controls.Add(FindateTimePicker);
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
            // IniciodateTimePicker
            // 
            IniciodateTimePicker.CustomFormat = "MMMM yyyy";
            IniciodateTimePicker.Format = DateTimePickerFormat.Custom;
            IniciodateTimePicker.Location = new Point(143, 189);
            IniciodateTimePicker.Name = "IniciodateTimePicker";
            IniciodateTimePicker.ShowUpDown = true;
            IniciodateTimePicker.Size = new Size(250, 27);
            IniciodateTimePicker.TabIndex = 10;
            IniciodateTimePicker.Value = new DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // FindateTimePicker
            // 
            FindateTimePicker.CustomFormat = "MMMM yyyy";
            FindateTimePicker.Format = DateTimePickerFormat.Custom;
            FindateTimePicker.Location = new Point(143, 228);
            FindateTimePicker.Name = "FindateTimePicker";
            FindateTimePicker.ShowUpDown = true;
            FindateTimePicker.Size = new Size(250, 27);
            FindateTimePicker.TabIndex = 9;
            FindateTimePicker.Value = new DateTime(2025, 10, 2, 0, 0, 0, 0);
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
            EmpresaDeTransporteHeader.Width = 220;
            // 
            // cuitColumn
            // 
            cuitColumn.Text = "CUIT";
            cuitColumn.Width = 220;
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
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(ingresosxVentastextBox);
            groupBox2.Controls.Add(ResultadoFinallabel);
            groupBox2.Controls.Add(totalDeCostoslabel);
            groupBox2.Controls.Add(ingresosPorVentaslabel);
            groupBox2.Location = new Point(29, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 170);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado de Resultados";
            // 
            // ingresosPorVentaslabel
            // 
            ingresosPorVentaslabel.AutoSize = true;
            ingresosPorVentaslabel.Location = new Point(123, 61);
            ingresosPorVentaslabel.Name = "ingresosPorVentaslabel";
            ingresosPorVentaslabel.Size = new Size(141, 20);
            ingresosPorVentaslabel.TabIndex = 0;
            ingresosPorVentaslabel.Text = "Ingresos por Ventas:";
            // 
            // totalDeCostoslabel
            // 
            totalDeCostoslabel.AutoSize = true;
            totalDeCostoslabel.Location = new Point(150, 92);
            totalDeCostoslabel.Name = "totalDeCostoslabel";
            totalDeCostoslabel.Size = new Size(114, 20);
            totalDeCostoslabel.TabIndex = 1;
            totalDeCostoslabel.Text = "Total de Costos:";
            totalDeCostoslabel.Click += label6_Click;
            // 
            // ResultadoFinallabel
            // 
            ResultadoFinallabel.AutoSize = true;
            ResultadoFinallabel.Location = new Point(186, 129);
            ResultadoFinallabel.Name = "ResultadoFinallabel";
            ResultadoFinallabel.Size = new Size(78, 20);
            ResultadoFinallabel.TabIndex = 2;
            ResultadoFinallabel.Text = "Resultado:";
            // 
            // ingresosxVentastextBox
            // 
            ingresosxVentastextBox.BorderStyle = BorderStyle.None;
            ingresosxVentastextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ingresosxVentastextBox.Location = new Point(279, 58);
            ingresosxVentastextBox.Name = "ingresosxVentastextBox";
            ingresosxVentastextBox.ReadOnly = true;
            ingresosxVentastextBox.Size = new Size(125, 27);
            ingresosxVentastextBox.TabIndex = 3;
            ingresosxVentastextBox.Text = "$0.00";
            ingresosxVentastextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(279, 89);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "$0.00";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(279, 122);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "$0.00";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // ImprimirButton
            // 
            ImprimirButton.Location = new Point(569, 478);
            ImprimirButton.Margin = new Padding(3, 4, 3, 4);
            ImprimirButton.Name = "ImprimirButton";
            ImprimirButton.Size = new Size(86, 31);
            ImprimirButton.TabIndex = 13;
            ImprimirButton.Text = "Imprimir";
            ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // ExportarXLSbutton
            // 
            ExportarXLSbutton.Location = new Point(432, 478);
            ExportarXLSbutton.Margin = new Padding(3, 4, 3, 4);
            ExportarXLSbutton.Name = "ExportarXLSbutton";
            ExportarXLSbutton.Size = new Size(130, 31);
            ExportarXLSbutton.TabIndex = 14;
            ExportarXLSbutton.Text = "Exportar a Excel";
            ExportarXLSbutton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(665, 478);
            LimpiarButton.Margin = new Padding(3, 4, 3, 4);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(86, 31);
            LimpiarButton.TabIndex = 15;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // ResultadoCostosVsVentasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 519);
            Controls.Add(LimpiarButton);
            Controls.Add(ExportarXLSbutton);
            Controls.Add(ImprimirButton);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ResultadoCostosVsVentasForm";
            Text = "CU1: Estado de Resultados de Costos Vs Ventas por empresa de servicio de transporte";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private DateTimePicker IniciodateTimePicker;
        private DateTimePicker FindateTimePicker;
        private Button estadoDeResultadosbutton;
        private ListView razonSocialList;
        private ColumnHeader EmpresaDeTransporteHeader;
        private ColumnHeader cuitColumn;
        private Button button1;
        private Label label5;
        private TextBox razonSocialTxt;
        private GroupBox groupBox2;
        private Label ResultadoFinallabel;
        private Label totalDeCostoslabel;
        private Label ingresosPorVentaslabel;
        private TextBox ingresosxVentastextBox;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button ImprimirButton;
        private Button ExportarXLSbutton;
        private Button LimpiarButton;
    }
}