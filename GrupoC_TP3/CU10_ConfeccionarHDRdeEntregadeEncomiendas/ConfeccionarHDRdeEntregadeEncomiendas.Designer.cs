namespace GrupoC_TP3.CU10_ConfeccionarHDRdeEntregadeEncomiendas
{
    partial class ConfeccionarHDRdeEntregadeEncomiendas
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
            listView1 = new ListView();
            NumerodeEncomiendasHDREntrega = new ColumnHeader();
            ClienteHDREntrega = new ColumnHeader();
            OrigenHDREntrega = new ColumnHeader();
            DestinoHDREntrega = new ColumnHeader();
            TelefonoHDREntrega = new ColumnHeader();
            CantidaddePaquetesHDREntrega = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 360);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Confeccionar Hoja de Ruta de Entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 52);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Metodo de entrega";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Entrega en domicilio", "Entrega en CD destino", "Entrega en Agencia" });
            comboBox1.Location = new Point(202, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 101);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Estado";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(202, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumerodeEncomiendasHDREntrega, ClienteHDREntrega, OrigenHDREntrega, DestinoHDREntrega, TelefonoHDREntrega, CantidaddePaquetesHDREntrega });
            listView1.GridLines = true;
            listView1.Location = new Point(6, 151);
            listView1.Name = "listView1";
            listView1.Size = new Size(604, 97);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumerodeEncomiendasHDREntrega
            // 
            NumerodeEncomiendasHDREntrega.Text = "Numero de encomienda";
            NumerodeEncomiendasHDREntrega.Width = 100;
            // 
            // ClienteHDREntrega
            // 
            ClienteHDREntrega.Text = "Cliente";
            ClienteHDREntrega.Width = 100;
            // 
            // OrigenHDREntrega
            // 
            OrigenHDREntrega.Text = "Origen";
            OrigenHDREntrega.Width = 100;
            // 
            // DestinoHDREntrega
            // 
            DestinoHDREntrega.Text = "Destino";
            DestinoHDREntrega.Width = 100;
            // 
            // TelefonoHDREntrega
            // 
            TelefonoHDREntrega.Text = "Telefono";
            TelefonoHDREntrega.Width = 100;
            // 
            // CantidaddePaquetesHDREntrega
            // 
            CantidaddePaquetesHDREntrega.Text = "N° de paquetes";
            CantidaddePaquetesHDREntrega.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(417, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(54, 293);
            button2.Name = "button2";
            button2.Size = new Size(135, 34);
            button2.TabIndex = 6;
            button2.Text = "Generar Hoja de Ruta";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(365, 299);
            button3.Name = "button3";
            button3.Size = new Size(110, 28);
            button3.TabIndex = 7;
            button3.Text = "Imprimir";
            button3.UseVisualStyleBackColor = true;
            // 
            // ConfeccionarHDRdeEntregadeEncomiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "ConfeccionarHDRdeEntregadeEncomiendas";
            Text = "Confeccionar Hoja de Ruta de Entrega de Encomiendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader NumerodeEncomiendasHDREntrega;
        private ColumnHeader ClienteHDREntrega;
        private ColumnHeader OrigenHDREntrega;
        private ColumnHeader DestinoHDREntrega;
        private ColumnHeader TelefonoHDREntrega;
        private ColumnHeader CantidaddePaquetesHDREntrega;
    }
}