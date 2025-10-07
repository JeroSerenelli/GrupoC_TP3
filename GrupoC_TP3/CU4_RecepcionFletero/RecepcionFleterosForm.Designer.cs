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
            ListViewItem listViewItem2 = new ListViewItem("");
            groupBox1 = new GroupBox();
            buttonBuscarFletero = new Button();
            comboBoxFletero = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonImprimirDetalle = new Button();
            listView1 = new ListView();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            listView3 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            buttonAsignarHDR = new Button();
            listView4 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button6 = new Button();
            label17 = new Label();
            label18 = new Label();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonBuscarFletero);
            groupBox1.Controls.Add(comboBoxFletero);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Fletero";
            // 
            // buttonBuscarFletero
            // 
            buttonBuscarFletero.Location = new Point(263, 74);
            buttonBuscarFletero.Name = "buttonBuscarFletero";
            buttonBuscarFletero.Size = new Size(75, 23);
            buttonBuscarFletero.TabIndex = 2;
            buttonBuscarFletero.Text = "Buscar";
            buttonBuscarFletero.UseVisualStyleBackColor = true;
            // 
            // comboBoxFletero
            // 
            comboBoxFletero.FormattingEnabled = true;
            comboBoxFletero.Location = new Point(121, 40);
            comboBoxFletero.Name = "comboBoxFletero";
            comboBoxFletero.Size = new Size(217, 23);
            comboBoxFletero.TabIndex = 1;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonImprimirDetalle);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(13, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hojas de Ruta Asignadas";
            // 
            // buttonImprimirDetalle
            // 
            buttonImprimirDetalle.Location = new Point(256, 155);
            buttonImprimirDetalle.Name = "buttonImprimirDetalle";
            buttonImprimirDetalle.Size = new Size(100, 23);
            buttonImprimirDetalle.TabIndex = 2;
            buttonImprimirDetalle.Text = "Imprimir Detalle";
            buttonImprimirDetalle.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listViewItem2.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(8, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(329, 91);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(buttonAsignarHDR);
            groupBox4.Controls.Add(listView4);
            groupBox4.Location = new Point(392, 192);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(333, 184);
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
            // buttonAsignarHDR
            // 
            buttonAsignarHDR.Location = new Point(205, 155);
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
            listView4.Size = new Size(314, 91);
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
            button6.Location = new Point(610, 418);
            button6.Name = "button6";
            button6.Size = new Size(115, 23);
            button6.TabIndex = 4;
            button6.Text = "Aceptar";
            button6.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(241, 37);
            label17.Name = "label17";
            label17.Size = new Size(269, 15);
            label17.TabIndex = 64;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(339, 17);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 63;
            label18.Text = "TUTASA";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Numero de Guia";
            columnHeader2.Width = 120;
            // 
            // RecepcionFleterosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 453);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(button6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RecepcionFleterosForm";
            Text = "Recepcion Fleteros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonBuscarFletero;
        private ComboBox comboBoxFletero;
        private Label label1;
        private GroupBox groupBox2;
        private Button buttonImprimirDetalle;
        private ListView listView1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button button3;
        private Button button4;
        private ListView listView3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button buttonAsignarHDR;
        private ListView listView4;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button button6;
        private Label label17;
        private Label label18;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}