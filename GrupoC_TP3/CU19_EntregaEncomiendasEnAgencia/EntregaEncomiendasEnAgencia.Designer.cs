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
            DNI_Destinatario = new ColumnHeader();
            Nombre = new ColumnHeader();
            Apellido = new ColumnHeader();
            Destino = new ColumnHeader();
            Recibo_Firmado = new ColumnHeader();
            Estado_Encomienda = new ColumnHeader();
            buttonImprimir = new Button();
            buttonConfirmar = new Button();
            label4 = new Label();
            buttonLimpiar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "N° de Guia:";
            label1.Click += label1_Click;
            // 
            // textBoxNumeroDeGuia
            // 
            textBoxNumeroDeGuia.Location = new Point(82, 23);
            textBoxNumeroDeGuia.Name = "textBoxNumeroDeGuia";
            textBoxNumeroDeGuia.Size = new Size(192, 23);
            textBoxNumeroDeGuia.TabIndex = 1;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(280, 24);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(122, 23);
            buttonConsultar.TabIndex = 2;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += button1_Click;
            // 
            // listViewEncomiendasARetirarAgencia
            // 
            listViewEncomiendasARetirarAgencia.CheckBoxes = true;
            listViewEncomiendasARetirarAgencia.Columns.AddRange(new ColumnHeader[] { Numero_Guia, DNI_Destinatario, Nombre, Apellido, Destino, Recibo_Firmado, Estado_Encomienda });
            listViewEncomiendasARetirarAgencia.FullRowSelect = true;
            listViewEncomiendasARetirarAgencia.GridLines = true;
            listViewEncomiendasARetirarAgencia.Location = new Point(4, 41);
            listViewEncomiendasARetirarAgencia.Name = "listViewEncomiendasARetirarAgencia";
            listViewEncomiendasARetirarAgencia.Size = new Size(598, 97);
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
            // DNI_Destinatario
            // 
            DNI_Destinatario.Text = "DNI Destinatario";
            DNI_Destinatario.Width = 100;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.Text = "Apellido";
            // 
            // Destino
            // 
            Destino.Text = "Destino";
            // 
            // Recibo_Firmado
            // 
            Recibo_Firmado.Text = "Recibo Firmado?";
            Recibo_Firmado.Width = 100;
            // 
            // Estado_Encomienda
            // 
            Estado_Encomienda.Text = "Estado Encomienda";
            Estado_Encomienda.Width = 120;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Location = new Point(4, 144);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(75, 23);
            buttonImprimir.TabIndex = 4;
            buttonImprimir.Text = "Imprimir";
            buttonImprimir.UseVisualStyleBackColor = true;
            buttonImprimir.Click += buttonImprimir_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(85, 144);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(75, 23);
            buttonConfirmar.TabIndex = 5;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(431, 9);
            label4.Name = "label4";
            label4.Size = new Size(187, 30);
            label4.TabIndex = 8;
            label4.Text = "TUTASA Agencias";
            label4.Click += label4_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(408, 24);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(122, 23);
            buttonLimpiar.TabIndex = 9;
            buttonLimpiar.Text = "Nueva Consulta";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLimpiar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxNumeroDeGuia);
            groupBox1.Controls.Add(buttonConsultar);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 73);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametro de Consulta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonConfirmar);
            groupBox2.Controls.Add(buttonImprimir);
            groupBox2.Controls.Add(listViewEncomiendasARetirarAgencia);
            groupBox2.Location = new Point(12, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(608, 219);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Encomiendas a Retirar";
            // 
            // EncomiendasARetirar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 352);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Name = "EncomiendasARetirar";
            Text = "Entrega de Encomiendas";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumeroDeGuia;
        private Button buttonConsultar;
        private ListView listViewEncomiendasARetirarAgencia;
        private Button buttonImprimir;
        private Button buttonConfirmar;
        private ColumnHeader Numero_Guia;
        private ColumnHeader DNI_Destinatario;
        private ColumnHeader Nombre;
        private ColumnHeader Apellido;
        private ColumnHeader Destino;
        private ColumnHeader Recibo_Firmado;
        private ColumnHeader Estado_Encomienda;
        private Label label4;
        private Button buttonLimpiar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}