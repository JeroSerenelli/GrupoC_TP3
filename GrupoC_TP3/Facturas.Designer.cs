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
            nroClienteTxt = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            cuentaCorrienteLstView = new ListView();
            Nro_Cliente = new ColumnHeader();
            Nro_Guia = new ColumnHeader();
            Sub_Total = new ColumnHeader();
            Total = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Nro. de Cliente: ";
            // 
            // nroClienteTxt
            // 
            nroClienteTxt.Location = new Point(143, 41);
            nroClienteTxt.Name = "nroClienteTxt";
            nroClienteTxt.Size = new Size(154, 27);
            nroClienteTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nroClienteTxt);
            groupBox1.Location = new Point(29, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 99);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(cuentaCorrienteLstView);
            groupBox2.Location = new Point(29, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(759, 293);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuenta Corriente";
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
            // cuentaCorrienteLstView
            // 
            cuentaCorrienteLstView.Columns.AddRange(new ColumnHeader[] { Nro_Cliente, Nro_Guia, Sub_Total, Total });
            cuentaCorrienteLstView.Location = new Point(24, 41);
            cuentaCorrienteLstView.Name = "cuentaCorrienteLstView";
            cuentaCorrienteLstView.Size = new Size(685, 135);
            cuentaCorrienteLstView.TabIndex = 2;
            cuentaCorrienteLstView.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(24, 200);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 3;
            button2.Text = "Generar Factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(24, 249);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 4;
            button3.Text = "Descargar Factura";
            button3.UseVisualStyleBackColor = true;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Facturas";
            Text = "Facturas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox nroClienteTxt;
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
    }
}