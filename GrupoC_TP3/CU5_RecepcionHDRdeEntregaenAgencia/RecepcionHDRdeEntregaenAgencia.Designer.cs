namespace GrupoC_TP3.CU5_RecepcionHDRdeEntregaenAgencia
{
    partial class RecepcionHDRdeEntregaenAgencia
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
            label3 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            NroHojaderuta = new ColumnHeader();
            NrodeGuia = new ColumnHeader();
            Cliente = new ColumnHeader();
            TamañoEncomienda = new ColumnHeader();
            Estado = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 31);
            label3.Name = "label3";
            label3.Size = new Size(342, 20);
            label3.TabIndex = 8;
            label3.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 4);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 7;
            label1.Text = "TUTASA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(26, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 215);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Hoja de ruta y de agencia";
            // 
            // button1
            // 
            button1.Location = new Point(312, 164);
            button1.Name = "button1";
            button1.Size = new Size(96, 35);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 117);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 3;
            label4.Text = "Número de agencia";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 46);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 1;
            label2.Text = "Número de hoja de ruta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(26, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(738, 238);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de encomiendas";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NroHojaderuta, NrodeGuia, Cliente, TamañoEncomienda, Estado });
            listView1.Location = new Point(33, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(675, 182);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NroHojaderuta
            // 
            NroHojaderuta.Text = "Nro Hoja de ruta";
            NroHojaderuta.Width = 130;
            // 
            // NrodeGuia
            // 
            NrodeGuia.Text = "Nro de Guía";
            NrodeGuia.Width = 130;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 130;
            // 
            // TamañoEncomienda
            // 
            TamañoEncomienda.Text = "Tamaño Encomienda";
            TamañoEncomienda.Width = 150;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 130;
            // 
            // button2
            // 
            button2.Location = new Point(738, 603);
            button2.Name = "button2";
            button2.Size = new Size(110, 28);
            button2.TabIndex = 11;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(858, 603);
            button3.Name = "button3";
            button3.Size = new Size(110, 28);
            button3.TabIndex = 12;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // RecepcionHDRdeEntregaenAgencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 643);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "RecepcionHDRdeEntregaenAgencia";
            Text = "Hojas de ruta de entrega";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader NroHojaderuta;
        private ColumnHeader NrodeGuia;
        private ColumnHeader Cliente;
        private ColumnHeader TamañoEncomienda;
        private ColumnHeader Estado;
        private Button button2;
        private Button button3;
    }
}