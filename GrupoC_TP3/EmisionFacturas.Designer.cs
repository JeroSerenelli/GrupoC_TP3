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
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
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
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Razon Social:";
            label1.Click += label1_Click;
            // 
            // razonSocialTxt
            // 
            razonSocialTxt.Location = new Point(143, 41);
            razonSocialTxt.Name = "razonSocialTxt";
            razonSocialTxt.Size = new Size(154, 27);
            razonSocialTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(razonSocialList);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(razonSocialTxt);
            groupBox1.Location = new Point(29, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(759, 195);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(545, 90);
            button4.Name = "button4";
            button4.Size = new Size(118, 61);
            button4.TabIndex = 6;
            button4.Text = "Mostrar Movimientos";
            button4.UseVisualStyleBackColor = true;
            // 
            // razonSocialList
            // 
            razonSocialList.Columns.AddRange(new ColumnHeader[] { RazonSocialColumn, cuitColumn, columnHeader3, columnHeader4 });
            razonSocialList.Location = new Point(22, 90);
            razonSocialList.Name = "razonSocialList";
            razonSocialList.Size = new Size(499, 81);
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
            button1.Location = new Point(317, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(cuentaCorrienteLstView);
            groupBox2.Location = new Point(29, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(759, 294);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuenta Corriente";
            // 
            // button3
            // 
            button3.Location = new Point(251, 234);
            button3.Name = "button3";
            button3.Size = new Size(209, 29);
            button3.TabIndex = 4;
            button3.Text = "Descargar Comprobante";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(22, 234);
            button2.Name = "button2";
            button2.Size = new Size(209, 29);
            button2.TabIndex = 3;
            button2.Text = "Emitir Factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // cuentaCorrienteLstView
            // 
            cuentaCorrienteLstView.Columns.AddRange(new ColumnHeader[] { Nro_Cliente, Nro_Guia, Sub_Total, Total });
            cuentaCorrienteLstView.Location = new Point(24, 41);
            cuentaCorrienteLstView.Name = "cuentaCorrienteLstView";
            cuentaCorrienteLstView.Size = new Size(685, 171);
            cuentaCorrienteLstView.TabIndex = 2;
            cuentaCorrienteLstView.UseCompatibleStateImageBehavior = false;
            // 
            // EmisionFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 548);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button4;
    }
}