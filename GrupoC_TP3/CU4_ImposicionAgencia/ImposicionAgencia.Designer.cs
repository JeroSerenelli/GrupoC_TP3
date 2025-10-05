namespace GrupoC_TP3
{
    partial class ImposicionAgencia
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
            textBox1 = new TextBox();
            listView1 = new ListView();
            nroGuia = new ColumnHeader();
            origenEncomienda = new ColumnHeader();
            destinoEncomienda = new ColumnHeader();
            estadoEncomienda = new ColumnHeader();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { nroGuia, origenEncomienda, destinoEncomienda, estadoEncomienda });
            listView1.Location = new Point(41, 123);
            listView1.Name = "listView1";
            listView1.Size = new Size(552, 152);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // nroGuia
            // 
            nroGuia.Text = "Nro. de Guía";
            // 
            // origenEncomienda
            // 
            origenEncomienda.Text = "Origen";
            // 
            // destinoEncomienda
            // 
            destinoEncomienda.Text = "Destino";
            // 
            // estadoEncomienda
            // 
            estadoEncomienda.Text = "Estado";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Impuesto", "En transito", "Entregado", "Devuelto" });
            comboBox1.Location = new Point(116, 308);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(288, 308);
            button1.Name = "button1";
            button1.Size = new Size(141, 28);
            button1.TabIndex = 4;
            button1.Text = "Actualizar Estado";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(288, 72);
            button2.Name = "button2";
            button2.Size = new Size(124, 28);
            button2.TabIndex = 5;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 76);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 6;
            label2.Text = "Nro. de Guía:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 310);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 7;
            label1.Text = "Estado:";
            label1.Click += label1_Click;
            // 
            // ImposicionAgencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 356);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Name = "ImposicionAgencia";
            Text = "CU4: Imposicion en Agencia";
            Load += ImposicionAgencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ListView listView1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label1;
        private ColumnHeader nroGuia;
        private ColumnHeader origenEncomienda;
        private ColumnHeader destinoEncomienda;
        private ColumnHeader estadoEncomienda;
    }
}