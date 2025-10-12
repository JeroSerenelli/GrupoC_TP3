namespace GrupoC_TP3.CU6_EntregaEncomiendas
{
    partial class EntregaEncomiendasForm1
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
            label17 = new Label();
            label18 = new Label();
            groupBox2 = new GroupBox();
            labelNombre = new Label();
            labelApellido = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonConfirmarEntrega = new Button();
            listViewEncomiendasARetirarAgencia = new ListView();
            nroGuia = new ColumnHeader();
            columnEstado = new ColumnHeader();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBoxDNI = new TextBox();
            buttonConsultar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(38, 50);
            label17.Name = "label17";
            label17.Size = new Size(342, 20);
            label17.TabIndex = 72;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(150, 24);
            label18.Name = "label18";
            label18.Size = new Size(84, 25);
            label18.TabIndex = 71;
            label18.Text = "TUTASA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelNombre);
            groupBox2.Controls.Add(labelApellido);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(buttonConfirmarEntrega);
            groupBox2.Controls.Add(listViewEncomiendasARetirarAgencia);
            groupBox2.Location = new Point(38, 252);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(416, 379);
            groupBox2.TabIndex = 70;
            groupBox2.TabStop = false;
            groupBox2.Text = "Encomiendas a Retirar";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(85, 36);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(0, 20);
            labelNombre.TabIndex = 52;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(85, 74);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(0, 20);
            labelApellido.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 74);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 36);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // buttonConfirmarEntrega
            // 
            buttonConfirmarEntrega.Location = new Point(270, 340);
            buttonConfirmarEntrega.Margin = new Padding(3, 4, 3, 4);
            buttonConfirmarEntrega.Name = "buttonConfirmarEntrega";
            buttonConfirmarEntrega.Size = new Size(139, 31);
            buttonConfirmarEntrega.TabIndex = 5;
            buttonConfirmarEntrega.Text = "Confirmar Entrega";
            buttonConfirmarEntrega.UseVisualStyleBackColor = true;
            buttonConfirmarEntrega.Click += buttonConfirmarEntrega_Click;
            // 
            // listViewEncomiendasARetirarAgencia
            // 
            listViewEncomiendasARetirarAgencia.CheckBoxes = true;
            listViewEncomiendasARetirarAgencia.Columns.AddRange(new ColumnHeader[] { nroGuia, columnEstado });
            listViewEncomiendasARetirarAgencia.FullRowSelect = true;
            listViewEncomiendasARetirarAgencia.GridLines = true;
            listViewEncomiendasARetirarAgencia.Location = new Point(5, 116);
            listViewEncomiendasARetirarAgencia.Margin = new Padding(3, 4, 3, 4);
            listViewEncomiendasARetirarAgencia.Name = "listViewEncomiendasARetirarAgencia";
            listViewEncomiendasARetirarAgencia.Size = new Size(404, 215);
            listViewEncomiendasARetirarAgencia.TabIndex = 3;
            listViewEncomiendasARetirarAgencia.UseCompatibleStateImageBehavior = false;
            listViewEncomiendasARetirarAgencia.View = View.Details;
            // 
            // nroGuia
            // 
            nroGuia.Text = "Numero de Guia";
            nroGuia.Width = 150;
            // 
            // columnEstado
            // 
            columnEstado.Text = "Estado";
            columnEstado.Width = 120;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxDNI);
            groupBox1.Controls.Add(buttonConsultar);
            groupBox1.Location = new Point(38, 101);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(307, 129);
            groupBox1.TabIndex = 69;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametro de Consulta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 36);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(51, 31);
            textBoxDNI.Margin = new Padding(3, 4, 3, 4);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(249, 27);
            textBoxDNI.TabIndex = 1;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(208, 81);
            buttonConsultar.Margin = new Padding(3, 4, 3, 4);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(93, 31);
            buttonConsultar.TabIndex = 2;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // EntregaEncomiendasForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 639);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EntregaEncomiendasForm1";
            Text = "EntregaEncomiendasForm1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private Label label18;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Button buttonConfirmarEntrega;
        private ListView listViewEncomiendasARetirarAgencia;
        private ColumnHeader nroGuia;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxDNI;
        private Button buttonConsultar;
        private Label labelApellido;
        private Label labelNombre;
        private ColumnHeader columnEstado;
    }
}