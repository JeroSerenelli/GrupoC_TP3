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
            button4 = new Button();
            razonSocialList = new ListView();
            RazonSocialColumn = new ColumnHeader();
            cuitColumn = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button3 = new Button();
            cuentaCorrienteLstView = new ListView();
            Nro_Cliente = new ColumnHeader();
            Nro_Guia = new ColumnHeader();
            Sub_Total = new ColumnHeader();
            Total = new ColumnHeader();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Location = new Point(29, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(759, 261);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
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
            razonSocialList.Columns.AddRange(new ColumnHeader[] { RazonSocialColumn, cuitColumn, columnHeader3, columnHeader4 });
            razonSocialList.Location = new Point(22, 90);
            razonSocialList.Name = "razonSocialList";
            razonSocialList.Size = new Size(682, 81);
            razonSocialList.TabIndex = 5;
            razonSocialList.UseCompatibleStateImageBehavior = false;
            razonSocialList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // RazonSocialColumn
            // 
            RazonSocialColumn.Text = "Razon Social";
            // 
            // cuitColumn
            // 
            cuitColumn.Text = "CUIT";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Domicilio Fiscal";
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
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(cuentaCorrienteLstView);
            groupBox2.Location = new Point(29, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(759, 231);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuenta Corriente";
            // 
            // button3
            // 
            button3.Location = new Point(22, 184);
            button3.Name = "button3";
            button3.Size = new Size(209, 29);
            button3.TabIndex = 4;
            button3.Text = "Descargar Comprobante";
            button3.UseVisualStyleBackColor = true;
            // 
            // cuentaCorrienteLstView
            // 
            cuentaCorrienteLstView.Columns.AddRange(new ColumnHeader[] { Nro_Cliente, Nro_Guia, Sub_Total, Total });
            cuentaCorrienteLstView.Location = new Point(22, 42);
            cuentaCorrienteLstView.Name = "cuentaCorrienteLstView";
            cuentaCorrienteLstView.Size = new Size(682, 118);
            cuentaCorrienteLstView.TabIndex = 2;
            cuentaCorrienteLstView.UseCompatibleStateImageBehavior = false;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(143, 189);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 10;
            dateTimePicker2.Value = new DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(490, 240);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(8, 27);
            dateTimePicker3.TabIndex = 11;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 233);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 13;
            label3.Text = "Fin de Periodo:";
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 548);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Facturas";
            Text = "Estado de Cuenta Corriente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox razonSocialTxt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private ListView cuentaCorrienteLstView;
        private ColumnHeader Nro_Cliente;
        private ColumnHeader Nro_Guia;
        private ColumnHeader Sub_Total;
        private ColumnHeader Total;
        private Button button3;
        private ListView razonSocialList;
        private ColumnHeader RazonSocialColumn;
        private ColumnHeader cuitColumn;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button4;
        private Label label2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}