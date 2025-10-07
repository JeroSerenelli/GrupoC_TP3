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
            label1 = new Label();
            textBox1 = new TextBox();
            buttonBuscarMicro = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            Aceptar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(buttonBuscarMicro);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Unidad";
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
            // textBox1
            // 
            textBox1.Location = new Point(67, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonBuscarMicro
            // 
            buttonBuscarMicro.Location = new Point(185, 35);
            buttonBuscarMicro.Name = "buttonBuscarMicro";
            buttonBuscarMicro.Size = new Size(75, 23);
            buttonBuscarMicro.TabIndex = 2;
            buttonBuscarMicro.Text = "Buscar";
            buttonBuscarMicro.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader4, columnHeader2, columnHeader3 });
            listView1.Location = new Point(6, 93);
            listView1.Name = "listView1";
            listView1.Size = new Size(472, 153);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Patente";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Numero de Guia";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Accion";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hoja de Ruta";
            columnHeader4.Width = 110;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(435, 342);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 1;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            // 
            // GestionCentroDeDistribucionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 377);
            Controls.Add(Aceptar);
            Controls.Add(groupBox1);
            Name = "GestionCentroDeDistribucionForm";
            Text = "GestionCentroDeDistribucionForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button buttonBuscarMicro;
        private TextBox textBox1;
        private Label label1;
        private ColumnHeader columnHeader4;
        private Button Aceptar;
    }
}