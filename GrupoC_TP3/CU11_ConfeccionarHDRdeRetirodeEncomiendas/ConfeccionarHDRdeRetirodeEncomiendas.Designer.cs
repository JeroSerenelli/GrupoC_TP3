namespace GrupoC_TP3.CU11_ConfeccionarHDRdeRetirodeEncomiendas
{
    partial class ConfeccionarHDRdeRetirodeEncomiendas
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            listView1 = new ListView();
            NumeroDeEncomiendaHDRRetiro = new ColumnHeader();
            ClienteHDRRetiro = new ColumnHeader();
            OrigenHDRRetiro = new ColumnHeader();
            DestinoHDRRetiro = new ColumnHeader();
            CantidaddePaquetesHDRRetiro = new ColumnHeader();
            TelefonoHDRRetiro = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 337);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Confeccionar Hoja de Ruta de Retiro de Encomiendas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 57);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Metodo de Entrega";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(183, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 100);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Estado";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(183, 94);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(173, 23);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(460, 91);
            button1.Name = "button1";
            button1.Size = new Size(112, 33);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroDeEncomiendaHDRRetiro, ClienteHDRRetiro, OrigenHDRRetiro, DestinoHDRRetiro, CantidaddePaquetesHDRRetiro, TelefonoHDRRetiro });
            listView1.GridLines = true;
            listView1.Location = new Point(35, 155);
            listView1.Name = "listView1";
            listView1.Size = new Size(608, 86);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroDeEncomiendaHDRRetiro
            // 
            NumeroDeEncomiendaHDRRetiro.Text = "Numero de encomienda";
            NumeroDeEncomiendaHDRRetiro.Width = 100;
            // 
            // ClienteHDRRetiro
            // 
            ClienteHDRRetiro.Text = "Cliente";
            ClienteHDRRetiro.Width = 100;
            // 
            // OrigenHDRRetiro
            // 
            OrigenHDRRetiro.Text = "Origen";
            OrigenHDRRetiro.Width = 100;
            // 
            // DestinoHDRRetiro
            // 
            DestinoHDRRetiro.Text = "Destino";
            DestinoHDRRetiro.Width = 100;
            // 
            // CantidaddePaquetesHDRRetiro
            // 
            CantidaddePaquetesHDRRetiro.Text = "N° de paquetes";
            CantidaddePaquetesHDRRetiro.Width = 100;
            // 
            // TelefonoHDRRetiro
            // 
            TelefonoHDRRetiro.Text = "Telefono";
            TelefonoHDRRetiro.Width = 100;
            // 
            // button2
            // 
            button2.Location = new Point(52, 277);
            button2.Name = "button2";
            button2.Size = new Size(130, 38);
            button2.TabIndex = 6;
            button2.Text = "Generar Hoja de Ruta ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(475, 277);
            button3.Name = "button3";
            button3.Size = new Size(97, 38);
            button3.TabIndex = 7;
            button3.Text = "Imprimir";
            button3.UseVisualStyleBackColor = true;
            // 
            // ConfeccionarHDRdeRetirodeEncomiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "ConfeccionarHDRdeRetirodeEncomiendas";
            Text = "Confeccionar Hoja de Ruta de Retiro de Encomiendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private ListView listView1;
        private ColumnHeader NumeroDeEncomiendaHDRRetiro;
        private ColumnHeader ClienteHDRRetiro;
        private ColumnHeader OrigenHDRRetiro;
        private ColumnHeader DestinoHDRRetiro;
        private ColumnHeader CantidaddePaquetesHDRRetiro;
        private ColumnHeader TelefonoHDRRetiro;
        private Button button1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button3;
    }
}