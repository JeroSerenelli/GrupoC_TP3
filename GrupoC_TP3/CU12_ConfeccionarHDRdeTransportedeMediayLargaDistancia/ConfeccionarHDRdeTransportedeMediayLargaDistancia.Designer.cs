namespace GrupoC_TP3.ConfeccionarHojaDeRuta
{
    partial class ConfeccionarHDRdeTransportedeMediayLargaDistancia
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
            DestinoEntrega1 = new ColumnHeader();
            ChoferesEntrega = new ColumnHeader();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            NumerodeEncomiendaTransporte = new ColumnHeader();
            CDOrigenTransporte = new ColumnHeader();
            CDDestinoTransporte = new ColumnHeader();
            NumeroDePaquetesTransporte = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DestinoEntrega1
            // 
            DestinoEntrega1.Text = "Destino";
            DestinoEntrega1.TextAlign = HorizontalAlignment.Center;
            DestinoEntrega1.Width = 100;
            // 
            // ChoferesEntrega
            // 
            ChoferesEntrega.Text = "Choferes";
            ChoferesEntrega.TextAlign = HorizontalAlignment.Center;
            ChoferesEntrega.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(56, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 475);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Confeccion de Hoja de Ruta de Transporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 85);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 0;
            label1.Text = "Centro de Distribucion de Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 124);
            label2.Name = "label2";
            label2.Size = new Size(185, 15);
            label2.TabIndex = 1;
            label2.Text = "Centro de Distribucion de Destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 165);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumerodeEncomiendaTransporte, CDOrigenTransporte, CDDestinoTransporte, NumeroDePaquetesTransporte });
            listView1.GridLines = true;
            listView1.Location = new Point(73, 228);
            listView1.Name = "listView1";
            listView1.Size = new Size(408, 100);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(305, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(305, 124);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(166, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(305, 165);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(166, 23);
            comboBox3.TabIndex = 6;
            // 
            // NumerodeEncomiendaTransporte
            // 
            NumerodeEncomiendaTransporte.Text = "Numero de encomienda";
            NumerodeEncomiendaTransporte.Width = 100;
            // 
            // CDOrigenTransporte
            // 
            CDOrigenTransporte.Text = "CD Origen";
            CDOrigenTransporte.Width = 100;
            // 
            // CDDestinoTransporte
            // 
            CDDestinoTransporte.Text = "CD Destino";
            CDDestinoTransporte.Width = 100;
            // 
            // NumeroDePaquetesTransporte
            // 
            NumeroDePaquetesTransporte.Text = "N° de paquetes";
            NumeroDePaquetesTransporte.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(73, 404);
            button1.Name = "button1";
            button1.Size = new Size(142, 40);
            button1.TabIndex = 7;
            button1.Text = "Generar Hoja de Ruta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(345, 404);
            button2.Name = "button2";
            button2.Size = new Size(136, 40);
            button2.TabIndex = 8;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(559, 165);
            button3.Name = "button3";
            button3.Size = new Size(91, 28);
            button3.TabIndex = 9;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // ConfeccionarHDRdeTransportedeMediayLargaDistancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 852);
            Controls.Add(groupBox1);
            Name = "ConfeccionarHDRdeTransportedeMediayLargaDistancia";
            Text = "Confeccionar Hoja de Ruta de Transporte de Media y Larga Distancia";
            Load += this.ConfeccionarHDRdeTransportedeMediayLargaDistancia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label Numerodeencomienda;
        private TextBox NumerodeencomeindatextBox1;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private Button Agregar;
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader2;
        private ColumnHeader DestinoEntrega1;
        private Label label9;
        private TextBox textBox1;
        private ColumnHeader ChoferesEntrega;
        private GroupBox groupBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader NumerodeEncomiendaTransporte;
        private ColumnHeader CDOrigenTransporte;
        private ColumnHeader CDDestinoTransporte;
        private ColumnHeader NumeroDePaquetesTransporte;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}