namespace GrupoC_TP3.RecepcionFletero
{
    partial class RecepcionFleterosForm
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
            comboBoxFletero = new ComboBox();
            buttonBuscarFletero = new Button();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            NumeroHDR = new ColumnHeader();
            GuiaAsociada = new ColumnHeader();
            EstadoHDR = new ColumnHeader();
            buttonCumplir = new Button();
            buttonImprimirDetalle = new Button();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            listView3 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button5 = new Button();
            buttonAsignarHDR = new Button();
            listView4 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button6 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonBuscarFletero);
            groupBox1.Controls.Add(comboBoxFletero);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Fletero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Fletero:";
            // 
            // comboBoxFletero
            // 
            comboBoxFletero.FormattingEnabled = true;
            comboBoxFletero.Location = new Point(121, 40);
            comboBoxFletero.Name = "comboBoxFletero";
            comboBoxFletero.Size = new Size(121, 23);
            comboBoxFletero.TabIndex = 1;
            // 
            // buttonBuscarFletero
            // 
            buttonBuscarFletero.Location = new Point(263, 39);
            buttonBuscarFletero.Name = "buttonBuscarFletero";
            buttonBuscarFletero.Size = new Size(75, 23);
            buttonBuscarFletero.TabIndex = 2;
            buttonBuscarFletero.Text = "Buscar";
            buttonBuscarFletero.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(buttonImprimirDetalle);
            groupBox2.Controls.Add(buttonCumplir);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(13, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hojas de Ruta Asignadas";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroHDR, GuiaAsociada, EstadoHDR });
            listView1.Location = new Point(8, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(329, 91);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroHDR
            // 
            NumeroHDR.Text = "Hoja de Ruta";
            NumeroHDR.Width = 100;
            // 
            // GuiaAsociada
            // 
            GuiaAsociada.Text = "Numero Guia";
            GuiaAsociada.Width = 100;
            // 
            // EstadoHDR
            // 
            EstadoHDR.Text = "Estado Hoja de Ruta";
            EstadoHDR.Width = 120;
            // 
            // buttonCumplir
            // 
            buttonCumplir.Location = new Point(116, 155);
            buttonCumplir.Name = "buttonCumplir";
            buttonCumplir.Size = new Size(115, 23);
            buttonCumplir.TabIndex = 1;
            buttonCumplir.Text = "Marcar Cumplida";
            buttonCumplir.UseVisualStyleBackColor = true;
            buttonCumplir.Click += button1_Click;
            // 
            // buttonImprimirDetalle
            // 
            buttonImprimirDetalle.Location = new Point(237, 155);
            buttonImprimirDetalle.Name = "buttonImprimirDetalle";
            buttonImprimirDetalle.Size = new Size(100, 23);
            buttonImprimirDetalle.TabIndex = 2;
            buttonImprimirDetalle.Text = "Imprimir Detalle";
            buttonImprimirDetalle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(listView2);
            groupBox3.Location = new Point(6, 184);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(393, 184);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hojas de Ruta Asignadas";
            // 
            // button1
            // 
            button1.Location = new Point(287, 155);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "Imprimir Detalle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(166, 155);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 1;
            button2.Text = "Marcar Cumplida";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView2.Location = new Point(8, 22);
            listView2.Name = "listView2";
            listView2.Size = new Size(379, 91);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Numero Guia";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado Hoja de Ruta";
            columnHeader3.Width = 120;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(buttonAsignarHDR);
            groupBox4.Controls.Add(listView4);
            groupBox4.Location = new Point(392, 138);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(419, 184);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Asignar Hoja de Ruta";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button3);
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(listView3);
            groupBox5.Location = new Point(6, 184);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(393, 184);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Hojas de Ruta Asignadas";
            // 
            // button3
            // 
            button3.Location = new Point(287, 155);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 2;
            button3.Text = "Imprimir Detalle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(166, 155);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 1;
            button4.Text = "Marcar Cumplida";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView3.Location = new Point(8, 22);
            listView3.Name = "listView3";
            listView3.Size = new Size(379, 91);
            listView3.TabIndex = 0;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hoja de Ruta";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Numero Guia";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Estado Hoja de Ruta";
            columnHeader6.Width = 120;
            // 
            // button5
            // 
            button5.Location = new Point(287, 155);
            button5.Name = "button5";
            button5.Size = new Size(100, 23);
            button5.TabIndex = 2;
            button5.Text = "Imprimir Detalle";
            button5.UseVisualStyleBackColor = true;
            // 
            // buttonAsignarHDR
            // 
            buttonAsignarHDR.Location = new Point(166, 155);
            buttonAsignarHDR.Name = "buttonAsignarHDR";
            buttonAsignarHDR.Size = new Size(115, 23);
            buttonAsignarHDR.TabIndex = 1;
            buttonAsignarHDR.Text = "Asignar";
            buttonAsignarHDR.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8 });
            listView4.Location = new Point(6, 22);
            listView4.Name = "listView4";
            listView4.Size = new Size(207, 91);
            listView4.TabIndex = 0;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Hoja de Ruta";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Numero Guia";
            columnHeader8.Width = 100;
            // 
            // button6
            // 
            button6.Location = new Point(702, 385);
            button6.Name = "button6";
            button6.Size = new Size(115, 23);
            button6.TabIndex = 4;
            button6.Text = "Aceptar";
            button6.UseVisualStyleBackColor = true;
            // 
            // RecepcionFleterosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 414);
            Controls.Add(button6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RecepcionFleterosForm";
            Text = "Recepcion Fleteros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonBuscarFletero;
        private ComboBox comboBoxFletero;
        private Label label1;
        private GroupBox groupBox2;
        private Button buttonImprimirDetalle;
        private Button buttonCumplir;
        private ListView listView1;
        private ColumnHeader NumeroHDR;
        private ColumnHeader GuiaAsociada;
        private ColumnHeader EstadoHDR;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button button3;
        private Button button4;
        private ListView listView3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button5;
        private Button buttonAsignarHDR;
        private ListView listView4;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button button6;
    }
}