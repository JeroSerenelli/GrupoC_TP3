namespace GrupoC_TP3
{
    partial class EncomiendasARetirar
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
            textBoxNumeroDeGuia = new TextBox();
            buttonConsultar = new Button();
            listViewEncomiendasARetirarAgencia = new ListView();
            Numero_Guia = new ColumnHeader();
            buttonConfirmar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label17 = new Label();
            label18 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 26);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            label1.Click += label1_Click;
            // 
            // textBoxNumeroDeGuia
            // 
            textBoxNumeroDeGuia.Location = new Point(45, 23);
            textBoxNumeroDeGuia.Name = "textBoxNumeroDeGuia";
            textBoxNumeroDeGuia.Size = new Size(218, 23);
            textBoxNumeroDeGuia.TabIndex = 1;
            textBoxNumeroDeGuia.TextChanged += textBoxNumeroDeGuia_TextChanged;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(182, 61);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(81, 23);
            buttonConsultar.TabIndex = 2;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += button1_Click;
            // 
            // listViewEncomiendasARetirarAgencia
            // 
            listViewEncomiendasARetirarAgencia.CheckBoxes = true;
            listViewEncomiendasARetirarAgencia.Columns.AddRange(new ColumnHeader[] { Numero_Guia });
            listViewEncomiendasARetirarAgencia.FullRowSelect = true;
            listViewEncomiendasARetirarAgencia.GridLines = true;
            listViewEncomiendasARetirarAgencia.Location = new Point(4, 87);
            listViewEncomiendasARetirarAgencia.Name = "listViewEncomiendasARetirarAgencia";
            listViewEncomiendasARetirarAgencia.Size = new Size(354, 162);
            listViewEncomiendasARetirarAgencia.TabIndex = 3;
            listViewEncomiendasARetirarAgencia.UseCompatibleStateImageBehavior = false;
            listViewEncomiendasARetirarAgencia.View = View.Details;
            listViewEncomiendasARetirarAgencia.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Numero_Guia
            // 
            Numero_Guia.Text = "Numero de Guia";
            Numero_Guia.Width = 100;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(236, 255);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(122, 23);
            buttonConfirmar.TabIndex = 5;
            buttonConfirmar.Text = "Confirmar Entrega";
            buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxNumeroDeGuia);
            groupBox1.Controls.Add(buttonConsultar);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 97);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametro de Consulta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(buttonConfirmar);
            groupBox2.Controls.Add(listViewEncomiendasARetirarAgencia);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 284);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Encomiendas a Retirar";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(12, 28);
            label17.Name = "label17";
            label17.Size = new Size(269, 15);
            label17.TabIndex = 68;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(110, 8);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 67;
            label18.Text = "TUTASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 26);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 55);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 55);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 8;
            // 
            // EncomiendasARetirar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 473);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EncomiendasARetirar";
            Text = "Entrega de Encomiendas";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumeroDeGuia;
        private Button buttonConsultar;
        private ListView listViewEncomiendasARetirarAgencia;
        private Button buttonConfirmar;
        private ColumnHeader Numero_Guia;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label17;
        private Label label18;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
    }
}