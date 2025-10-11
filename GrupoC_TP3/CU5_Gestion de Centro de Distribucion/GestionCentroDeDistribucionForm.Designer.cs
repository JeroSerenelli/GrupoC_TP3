namespace GrupoC_TP3.Gestion_de_Centro_de_Distribucion
{
    partial class GestionCentroDeDistribucionForm
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
            buttonBuscarMicro = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label17 = new Label();
            label18 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonBuscarMicro);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Unidad";
            // 
            // buttonBuscarMicro
            // 
            buttonBuscarMicro.Location = new Point(459, 38);
            buttonBuscarMicro.Name = "buttonBuscarMicro";
            buttonBuscarMicro.Size = new Size(75, 23);
            buttonBuscarMicro.TabIndex = 2;
            buttonBuscarMicro.Text = "Buscar";
            buttonBuscarMicro.UseVisualStyleBackColor = true;
            buttonBuscarMicro.Click += buttonBuscarMicro_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Patente:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader2 });
            listView1.Location = new Point(8, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(265, 126);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hoja de Ruta";
            columnHeader4.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Numero de Guia";
            columnHeader2.Width = 100;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(133, 29);
            label17.Name = "label17";
            label17.Size = new Size(269, 15);
            label17.TabIndex = 66;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(231, 9);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 65;
            label18.Text = "TUTASA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(19, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 200);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descargar y recibir en CD";
            // 
            // button1
            // 
            button1.Location = new Point(198, 166);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView2);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(318, 186);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(283, 200);
            groupBox3.TabIndex = 68;
            groupBox3.TabStop = false;
            groupBox3.Text = "Despachar desde CD";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3 });
            listView2.Location = new Point(8, 22);
            listView2.Name = "listView2";
            listView2.Size = new Size(269, 126);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Numero de Guia";
            columnHeader3.Width = 100;
            // 
            // button2
            // 
            button2.Location = new Point(202, 168);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GestionCentroDeDistribucionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 402);
            Controls.Add(groupBox3);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "GestionCentroDeDistribucionForm";
            Text = "Gestion de Centro de Distribucion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private Button buttonBuscarMicro;
        private TextBox textBox1;
        private Label label1;
        private ColumnHeader columnHeader4;
        private Label label17;
        private Label label18;
        private GroupBox groupBox2;
        private Button button1;
        private GroupBox groupBox3;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private Button button2;
    }
}