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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            IniciodateTimePicker = new DateTimePicker();
            FindateTimePicker = new DateTimePicker();
            estadoDeResultadosbutton = new Button();
            button1 = new Button();
            label5 = new Label();
            razonSocialTxt = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ingresosxVentastextBox = new TextBox();
            ResultadoFinallabel = new Label();
            totalDeCostoslabel = new Label();
            ingresosPorVentaslabel = new Label();
            ImprimirButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(IniciodateTimePicker);
            groupBox1.Controls.Add(FindateTimePicker);
            groupBox1.Controls.Add(estadoDeResultadosbutton);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(razonSocialTxt);
            groupBox1.Location = new Point(25, 26);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(506, 196);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empresa de Servicio de Transporte";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 95);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 13;
            label3.Text = "Fin de Periodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 12;
            label2.Text = "Incio de Periodo:";
            // 
            // IniciodateTimePicker
            // 
            IniciodateTimePicker.CustomFormat = "MMMM yyyy";
            IniciodateTimePicker.Format = DateTimePickerFormat.Custom;
            IniciodateTimePicker.Location = new Point(131, 62);
            IniciodateTimePicker.Margin = new Padding(3, 2, 3, 2);
            IniciodateTimePicker.Name = "IniciodateTimePicker";
            IniciodateTimePicker.ShowUpDown = true;
            IniciodateTimePicker.Size = new Size(219, 23);
            IniciodateTimePicker.TabIndex = 10;
            IniciodateTimePicker.Value = new DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // FindateTimePicker
            // 
            FindateTimePicker.CustomFormat = "MMMM yyyy";
            FindateTimePicker.Format = DateTimePickerFormat.Custom;
            FindateTimePicker.Location = new Point(131, 91);
            FindateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FindateTimePicker.Name = "FindateTimePicker";
            FindateTimePicker.ShowUpDown = true;
            FindateTimePicker.Size = new Size(219, 23);
            FindateTimePicker.TabIndex = 9;
            FindateTimePicker.Value = new DateTime(2025, 10, 2, 0, 0, 0, 0);
            // 
            // estadoDeResultadosbutton
            // 
            estadoDeResultadosbutton.Location = new Point(364, 62);
            estadoDeResultadosbutton.Margin = new Padding(3, 2, 3, 2);
            estadoDeResultadosbutton.Name = "estadoDeResultadosbutton";
            estadoDeResultadosbutton.Size = new Size(124, 50);
            estadoDeResultadosbutton.TabIndex = 6;
            estadoDeResultadosbutton.Text = "Generar Estado de Resultados";
            estadoDeResultadosbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(303, 25);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 29);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 0;
            label5.Text = "Empresa de Transporte:";
            // 
            // razonSocialTxt
            // 
            razonSocialTxt.Location = new Point(150, 26);
            razonSocialTxt.Margin = new Padding(3, 2, 3, 2);
            razonSocialTxt.Name = "razonSocialTxt";
            razonSocialTxt.Size = new Size(135, 23);
            razonSocialTxt.TabIndex = 1;
            razonSocialTxt.TextChanged += razonSocialTxt_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(ingresosxVentastextBox);
            groupBox2.Controls.Add(ResultadoFinallabel);
            groupBox2.Controls.Add(totalDeCostoslabel);
            groupBox2.Controls.Add(ingresosPorVentaslabel);
            groupBox2.Location = new Point(25, 226);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(506, 122);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado de Resultados";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(244, 92);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(109, 22);
            textBox2.TabIndex = 5;
            textBox2.Text = "$0.00";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(244, 67);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(109, 22);
            textBox1.TabIndex = 4;
            textBox1.Text = "$0.00";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // ingresosxVentastextBox
            // 
            ingresosxVentastextBox.BorderStyle = BorderStyle.None;
            ingresosxVentastextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ingresosxVentastextBox.Location = new Point(244, 44);
            ingresosxVentastextBox.Margin = new Padding(3, 2, 3, 2);
            ingresosxVentastextBox.Name = "ingresosxVentastextBox";
            ingresosxVentastextBox.ReadOnly = true;
            ingresosxVentastextBox.Size = new Size(109, 22);
            ingresosxVentastextBox.TabIndex = 3;
            ingresosxVentastextBox.Text = "$0.00";
            ingresosxVentastextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // ResultadoFinallabel
            // 
            ResultadoFinallabel.AutoSize = true;
            ResultadoFinallabel.Location = new Point(163, 97);
            ResultadoFinallabel.Name = "ResultadoFinallabel";
            ResultadoFinallabel.Size = new Size(62, 15);
            ResultadoFinallabel.TabIndex = 2;
            ResultadoFinallabel.Text = "Resultado:";
            // 
            // totalDeCostoslabel
            // 
            totalDeCostoslabel.AutoSize = true;
            totalDeCostoslabel.Location = new Point(131, 69);
            totalDeCostoslabel.Name = "totalDeCostoslabel";
            totalDeCostoslabel.Size = new Size(91, 15);
            totalDeCostoslabel.TabIndex = 1;
            totalDeCostoslabel.Text = "Total de Costos:";
            totalDeCostoslabel.Click += label6_Click;
            // 
            // ingresosPorVentaslabel
            // 
            ingresosPorVentaslabel.AutoSize = true;
            ingresosPorVentaslabel.Location = new Point(108, 46);
            ingresosPorVentaslabel.Name = "ingresosPorVentaslabel";
            ingresosPorVentaslabel.Size = new Size(112, 15);
            ingresosPorVentaslabel.TabIndex = 0;
            ingresosPorVentaslabel.Text = "Ingresos por Ventas:";
            // 
            // ImprimirButton
            // 
            ImprimirButton.Location = new Point(456, 354);
            ImprimirButton.Name = "ImprimirButton";
            ImprimirButton.Size = new Size(75, 23);
            ImprimirButton.TabIndex = 13;
            ImprimirButton.Text = "Imprimir";
            ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // ResultadoCostosVsVentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 388);
            Controls.Add(ImprimirButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResultadoCostosVsVentasForm";
            Text = "CU1: Estado de Resultados de Costos Vs Ventas por empresa de servicio de transporte";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private DateTimePicker IniciodateTimePicker;
        private DateTimePicker FindateTimePicker;
        private Button estadoDeResultadosbutton;
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
    }
}