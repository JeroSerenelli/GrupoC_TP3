namespace GrupoC_TP3
{
    partial class RegistrarEncomiendas
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(41, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 397);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Solicitante";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(397, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 397);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Encomienda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "TUTASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 50);
            label2.Name = "label2";
            label2.Size = new Size(249, 15);
            label2.TabIndex = 3;
            label2.Text = "Transportes Urbanos Terrestres Argentinos S.A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 0;
            label3.Text = "Nombre del Solicitante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 1;
            label4.Text = "Apellido del Solicitante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 175);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 2;
            label5.Text = "Razon Social";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 217);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 3;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 50);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 0;
            label7.Text = "Cantidad de Cajas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 76);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 1;
            label8.Text = "Tipo de cajas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 111);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 2;
            label9.Text = "Centro Distribucion de origen";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 138);
            label10.Name = "label10";
            label10.Size = new Size(185, 15);
            label10.TabIndex = 3;
            label10.Text = "Centro de Distribucion de Destino";
            // 
            // RegistrarEncomiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 606);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegistrarEncomiendas";
            Text = "Registrar Admision de Encomiendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}