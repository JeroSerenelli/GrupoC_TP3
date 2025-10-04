namespace GrupoC_TP3
{
    partial class EmisionFacturas
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
            domicilioFiscal = new ColumnHeader();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            cuentaCorrienteLstView = new ListView();
            Nro_Cliente = new ColumnHeader();
            Nro_Guia = new ColumnHeader();
            Sub_Total = new ColumnHeader();
            Total = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Razon Social:";
            label1.Click += label1_Click;
            // 
            // razonSocialTxt
            // 
            razonSocialTxt.Location = new Point(125, 31);
            razonSocialTxt.Margin = new Padding(3, 2, 3, 2);
            razonSocialTxt.Name = "razonSocialTxt";
            razonSocialTxt.Size = new Size(135, 23);
            razonSocialTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(razonSocialList);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(razonSocialTxt);
            groupBox1.Location = new Point(25, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(664, 146);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(477, 68);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(103, 46);
            button4.TabIndex = 6;
            button4.Text = "Mostrar Movimientos";
            button4.UseVisualStyleBackColor = true;
            // 
            // razonSocialList
            // 
            razonSocialList.Columns.AddRange(new ColumnHeader[] { RazonSocialColumn, cuitColumn, domicilioFiscal });
            razonSocialList.Location = new Point(19, 68);
            razonSocialList.Margin = new Padding(3, 2, 3, 2);
            razonSocialList.Name = "razonSocialList";
            razonSocialList.Size = new Size(437, 62);
            razonSocialList.TabIndex = 5;
            razonSocialList.UseCompatibleStateImageBehavior = false;
            razonSocialList.View = View.Details;
            razonSocialList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // RazonSocialColumn
            // 
            RazonSocialColumn.Text = "Razon Social";
            RazonSocialColumn.Width = 120;
            // 
            // cuitColumn
            // 
            cuitColumn.Text = "CUIT";
            cuitColumn.Width = 120;
            // 
            // domicilioFiscal
            // 
            domicilioFiscal.Text = "Domicilio Fiscal";
            domicilioFiscal.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(277, 29);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(cuentaCorrienteLstView);
            groupBox2.Location = new Point(25, 170);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(664, 220);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pedidos a Facturar";
            // 
            // button3
            // 
            button3.Location = new Point(220, 176);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(183, 22);
            button3.TabIndex = 4;
            button3.Text = "Descargar Comprobante";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(19, 176);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(183, 22);
            button2.TabIndex = 3;
            button2.Text = "Emitir Factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // cuentaCorrienteLstView
            // 
            cuentaCorrienteLstView.Columns.AddRange(new ColumnHeader[] { Nro_Cliente, Nro_Guia, Sub_Total, Total });
            cuentaCorrienteLstView.Location = new Point(21, 31);
            cuentaCorrienteLstView.Margin = new Padding(3, 2, 3, 2);
            cuentaCorrienteLstView.Name = "cuentaCorrienteLstView";
            cuentaCorrienteLstView.Size = new Size(600, 129);
            cuentaCorrienteLstView.TabIndex = 2;
            cuentaCorrienteLstView.UseCompatibleStateImageBehavior = false;
            cuentaCorrienteLstView.View = View.Details;
            cuentaCorrienteLstView.SelectedIndexChanged += cuentaCorrienteLstView_SelectedIndexChanged;
            // 
            // Nro_Cliente
            // 
            Nro_Cliente.Text = "Numero de Cliente";
            Nro_Cliente.Width = 120;
            // 
            // Nro_Guia
            // 
            Nro_Guia.Text = "Numero de Guia";
            Nro_Guia.Width = 120;
            // 
            // Sub_Total
            // 
            Sub_Total.Text = "Sub Total";
            Sub_Total.Width = 100;
            // 
            // Total
            // 
            Total.Text = "Total";
            // 
            // EmisionFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 402);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmisionFacturas";
            Text = "Emision de Facutras";
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
        private Button button2;
        private ListView razonSocialList;
        private ColumnHeader RazonSocialColumn;
        private ColumnHeader cuitColumn;
        private ColumnHeader domicilioFiscal;
        private Button button4;
    }
}