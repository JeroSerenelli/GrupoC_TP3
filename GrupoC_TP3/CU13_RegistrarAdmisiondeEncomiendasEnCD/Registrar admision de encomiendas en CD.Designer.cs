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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            listView1 = new ListView();
            NumeroEncomiendasAdmision = new ColumnHeader();
            ClienteAdmision = new ColumnHeader();
            TamañoAdmision = new ColumnHeader();
            PesoAdmision = new ColumnHeader();
            EstadoAdmision = new ColumnHeader();
            groupBox2 = new GroupBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "TUTASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 49);
            label2.Name = "label2";
            label2.Size = new Size(249, 15);
            label2.TabIndex = 3;
            label2.Text = "Transportes Urbanos Terrestres Argentinos S.A";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(32, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 87);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(591, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 39);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 0;
            label3.Text = "Numero de la encomienda";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroEncomiendasAdmision, ClienteAdmision, TamañoAdmision, PesoAdmision, EstadoAdmision });
            listView1.GridLines = true;
            listView1.Location = new Point(52, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(542, 100);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroEncomiendasAdmision
            // 
            NumeroEncomiendasAdmision.Text = "Numero de Encomiendas";
            NumeroEncomiendasAdmision.Width = 120;
            // 
            // ClienteAdmision
            // 
            ClienteAdmision.Text = "Cliente";
            ClienteAdmision.Width = 120;
            // 
            // TamañoAdmision
            // 
            TamañoAdmision.Text = "Tamaño";
            TamañoAdmision.Width = 100;
            // 
            // PesoAdmision
            // 
            PesoAdmision.Text = "Peso";
            PesoAdmision.Width = 100;
            // 
            // EstadoAdmision
            // 
            EstadoAdmision.Text = "Estado";
            EstadoAdmision.Width = 100;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(32, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(686, 203);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(574, 160);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aprobar", "Modificar" });
            comboBox1.Location = new Point(123, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 164);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Validar";
            // 
            // button3
            // 
            button3.Location = new Point(523, 438);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 6;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(634, 438);
            button4.Name = "button4";
            button4.Size = new Size(84, 36);
            button4.TabIndex = 7;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // RegistrarEncomiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 609);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader NumeroEncomiendasAdmision;
        private ColumnHeader ClienteAdmision;
        private ColumnHeader TamañoAdmision;
        private ColumnHeader PesoAdmision;
        private ColumnHeader EstadoAdmision;
        private GroupBox groupBox2;
        private Button button2;
        private ComboBox comboBox1;
        private Label label4;
        private Button button3;
        private Button button4;
    }
}