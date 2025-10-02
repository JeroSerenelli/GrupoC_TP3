namespace GrupoC_TP3
{
    partial class HojaDeRuta
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
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox4 = new TextBox();
            RegistrarAdmisionEncomiendasBox2 = new GroupBox();
            label6 = new Label();
            NumeroDeEncomienda = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            NumeroEncomiendastextBox = new TextBox();
            RegistrarEncomiendas = new Button();
            textBox3 = new TextBox();
            GuardarRegistroEncomiendaBTN = new Button();
            CancelarRegistroEncomiendaBTN = new Button();
            BorrarRegistroEncomiendaBTN = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            RegistrarAdmisionEncomiendasBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "Buscar";
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(339, 22);
            button1.Name = "button1";
            button1.Size = new Size(74, 29);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AccessibleName = "NumeroDeTramite";
            label3.AutoSize = true;
            label3.Location = new Point(42, 139);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 8);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 10;
            label4.Text = "Tramites";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 158);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Hoja de Ruta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AccessibleName = "NumeroDeTramite";
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 34);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 12;
            label5.Text = "NumeroDeTramite";
            // 
            // textBox4
            // 
            textBox4.AccessibleName = "NumeroDeTramiteTxt";
            textBox4.Location = new Point(161, 28);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 27);
            textBox4.TabIndex = 12;
            // 
            // RegistrarAdmisionEncomiendasBox2
            // 
            RegistrarAdmisionEncomiendasBox2.Controls.Add(BorrarRegistroEncomiendaBTN);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(CancelarRegistroEncomiendaBTN);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(GuardarRegistroEncomiendaBTN);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(textBox3);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(RegistrarEncomiendas);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(NumeroEncomiendastextBox);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(NumeroDeEncomienda);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(label6);
            RegistrarAdmisionEncomiendasBox2.FlatStyle = FlatStyle.System;
            RegistrarAdmisionEncomiendasBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RegistrarAdmisionEncomiendasBox2.Location = new Point(38, 266);
            RegistrarAdmisionEncomiendasBox2.Name = "RegistrarAdmisionEncomiendasBox2";
            RegistrarAdmisionEncomiendasBox2.Size = new Size(516, 224);
            RegistrarAdmisionEncomiendasBox2.TabIndex = 12;
            RegistrarAdmisionEncomiendasBox2.TabStop = false;
            RegistrarAdmisionEncomiendasBox2.Text = "Registrar Encomiendas";
            RegistrarAdmisionEncomiendasBox2.Enter += groupBox2_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 86);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 0;
            label6.Text = "Encomiendas";
            // 
            // NumeroDeEncomienda
            // 
            NumeroDeEncomienda.AutoSize = true;
            NumeroDeEncomienda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumeroDeEncomienda.Location = new Point(27, 39);
            NumeroDeEncomienda.Name = "NumeroDeEncomienda";
            NumeroDeEncomienda.Size = new Size(136, 15);
            NumeroDeEncomienda.TabIndex = 1;
            NumeroDeEncomienda.Text = "Numero de Encomienda";
            // 
            // NumeroEncomiendastextBox
            // 
            NumeroEncomiendastextBox.Location = new Point(218, 32);
            NumeroEncomiendastextBox.Name = "NumeroEncomiendastextBox";
            NumeroEncomiendastextBox.Size = new Size(147, 28);
            NumeroEncomiendastextBox.TabIndex = 2;
            // 
            // RegistrarEncomiendas
            // 
            RegistrarEncomiendas.AccessibleName = "RegistrarEncomiendas";
            RegistrarEncomiendas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrarEncomiendas.Location = new Point(399, 32);
            RegistrarEncomiendas.Name = "RegistrarEncomiendas";
            RegistrarEncomiendas.Size = new Size(85, 27);
            RegistrarEncomiendas.TabIndex = 3;
            RegistrarEncomiendas.Text = "Registrar";
            RegistrarEncomiendas.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(353, 28);
            textBox3.TabIndex = 4;
            textBox3.Text = "Numero ENCOMIENDA Y FECHA ";
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // GuardarRegistroEncomiendaBTN
            // 
            GuardarRegistroEncomiendaBTN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuardarRegistroEncomiendaBTN.Location = new Point(27, 177);
            GuardarRegistroEncomiendaBTN.Name = "GuardarRegistroEncomiendaBTN";
            GuardarRegistroEncomiendaBTN.Size = new Size(82, 30);
            GuardarRegistroEncomiendaBTN.TabIndex = 5;
            GuardarRegistroEncomiendaBTN.Text = "Guardar";
            GuardarRegistroEncomiendaBTN.UseVisualStyleBackColor = true;
            GuardarRegistroEncomiendaBTN.Click += button3_Click;
            // 
            // CancelarRegistroEncomiendaBTN
            // 
            CancelarRegistroEncomiendaBTN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelarRegistroEncomiendaBTN.Location = new Point(399, 177);
            CancelarRegistroEncomiendaBTN.Name = "CancelarRegistroEncomiendaBTN";
            CancelarRegistroEncomiendaBTN.Size = new Size(85, 30);
            CancelarRegistroEncomiendaBTN.TabIndex = 6;
            CancelarRegistroEncomiendaBTN.Text = "Cancelar";
            CancelarRegistroEncomiendaBTN.UseVisualStyleBackColor = true;
            // 
            // BorrarRegistroEncomiendaBTN
            // 
            BorrarRegistroEncomiendaBTN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BorrarRegistroEncomiendaBTN.Location = new Point(207, 177);
            BorrarRegistroEncomiendaBTN.Name = "BorrarRegistroEncomiendaBTN";
            BorrarRegistroEncomiendaBTN.Size = new Size(87, 30);
            BorrarRegistroEncomiendaBTN.TabIndex = 7;
            BorrarRegistroEncomiendaBTN.Text = "Borrar";
            BorrarRegistroEncomiendaBTN.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 38);
            textBox1.TabIndex = 13;
            textBox1.Text = "Aca va el listado que vayamos a agregar";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // HojaDeRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 622);
            Controls.Add(RegistrarAdmisionEncomiendasBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "HojaDeRuta";
            Text = "HojaDeRuta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            RegistrarAdmisionEncomiendasBox2.ResumeLayout(false);
            RegistrarAdmisionEncomiendasBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label5;
        private GroupBox RegistrarAdmisionEncomiendasBox2;
        private Label NumeroDeEncomienda;
        private Label label6;
        private Button RegistrarEncomiendas;
        private TextBox NumeroEncomiendastextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox3;
        private Button GuardarRegistroEncomiendaBTN;
        private Button BorrarRegistroEncomiendaBTN;
        private Button CancelarRegistroEncomiendaBTN;
        private TextBox textBox1;
    }
}