namespace GrupoC_TP3.CU4_RecepcionFletero
{
    partial class RecepcionFleterosForm : Form
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
            ListViewItem listViewItem1 = new ListViewItem("");
            groupBox1 = new GroupBox();
            buttonBuscarFletero = new Button();
            comboBoxFletero = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonImprimirDetalle = new Button();
            listViewHDRAsignadas = new ListView();
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
            buttonAsignarHDR = new Button();
            listView4 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button6 = new Button();
            label17 = new Label();
            label18 = new Label();
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
            groupBox1.Location = new Point(14, 101);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(398, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Búsqueda de Fletero";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonBuscarFletero
            // 
            buttonBuscarFletero.Location = new Point(301, 99);
            buttonBuscarFletero.Margin = new Padding(3, 4, 3, 4);
            buttonBuscarFletero.Name = "buttonBuscarFletero";
            buttonBuscarFletero.Size = new Size(86, 31);
            buttonBuscarFletero.TabIndex = 2;
            buttonBuscarFletero.Text = "Buscar";
            buttonBuscarFletero.UseVisualStyleBackColor = true;
            buttonBuscarFletero.Click += buttonBuscarFletero_Click;
            // 
            // comboBoxFletero
            // 
            comboBoxFletero.FormattingEnabled = true;
            comboBoxFletero.Items.AddRange(new object[] { "Juan", "Osvaldo" });
            comboBoxFletero.Location = new Point(138, 53);
            comboBoxFletero.Margin = new Padding(3, 4, 3, 4);
            comboBoxFletero.Name = "comboBoxFletero";
            comboBoxFletero.Size = new Size(247, 28);
            comboBoxFletero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Fletero:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonImprimirDetalle);
            groupBox2.Controls.Add(listViewHDRAsignadas);
            groupBox2.Location = new Point(15, 256);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(414, 245);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hojas de Ruta Asignadas";
            // 
            // buttonImprimirDetalle
            // 
            buttonImprimirDetalle.Location = new Point(293, 207);
            buttonImprimirDetalle.Margin = new Padding(3, 4, 3, 4);
            buttonImprimirDetalle.Name = "buttonImprimirDetalle";
            buttonImprimirDetalle.Size = new Size(114, 31);
            buttonImprimirDetalle.TabIndex = 2;
            buttonImprimirDetalle.Text = "Imprimir Detalle";
            buttonImprimirDetalle.UseVisualStyleBackColor = true;
            buttonImprimirDetalle.Click += buttonImprimirDetalle_Click;
            // 
            // listViewHDRAsignadas
            // 
            listViewHDRAsignadas.CheckBoxes = true;
            listViewHDRAsignadas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewHDRAsignadas.FullRowSelect = true;
            listViewItem1.StateImageIndex = 0;
            listViewHDRAsignadas.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewHDRAsignadas.Location = new Point(9, 29);
            listViewHDRAsignadas.Margin = new Padding(3, 4, 3, 4);
            listViewHDRAsignadas.Name = "listViewHDRAsignadas";
            listViewHDRAsignadas.Size = new Size(375, 120);
            listViewHDRAsignadas.TabIndex = 0;
            listViewHDRAsignadas.UseCompatibleStateImageBehavior = false;
            listViewHDRAsignadas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Número de Guía";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(buttonAsignarHDR);
            groupBox4.Controls.Add(listView4);
            groupBox4.Location = new Point(448, 256);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(381, 245);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Asignar Hoja de Ruta";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button3);
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(listView3);
            groupBox5.Location = new Point(7, 245);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(449, 245);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Hojas de Ruta Asignadas";
            // 
            // button3
            // 
            button3.Location = new Point(328, 207);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(114, 31);
            button3.TabIndex = 2;
            button3.Text = "Imprimir Detalle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(190, 207);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(131, 31);
            button4.TabIndex = 1;
            button4.Text = "Marcar Cumplida";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView3.Location = new Point(9, 29);
            listView3.Margin = new Padding(3, 4, 3, 4);
            listView3.Name = "listView3";
            listView3.Size = new Size(433, 120);
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
            buttonAsignarHDR.Location = new Point(234, 207);
            buttonAsignarHDR.Margin = new Padding(3, 4, 3, 4);
            buttonAsignarHDR.Name = "buttonAsignarHDR";
            buttonAsignarHDR.Size = new Size(131, 31);
            buttonAsignarHDR.TabIndex = 1;
            buttonAsignarHDR.Text = "Asignar";
            buttonAsignarHDR.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8 });
            listView4.Location = new Point(7, 29);
            listView4.Margin = new Padding(3, 4, 3, 4);
            listView4.Name = "listView4";
            listView4.Size = new Size(358, 120);
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
            columnHeader8.Text = "Número de Guía";
            columnHeader8.Width = 100;
            // 
            // button6
            // 
            button6.Location = new Point(697, 557);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(131, 31);
            button6.TabIndex = 4;
            button6.Text = "Aceptar";
            button6.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(275, 49);
            label17.Name = "label17";
            label17.Size = new Size(342, 20);
            label17.TabIndex = 64;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(387, 23);
            label18.Name = "label18";
            label18.Size = new Size(84, 25);
            label18.TabIndex = 63;
            label18.Text = "TUTASA";
            // 
            // RecepcionFleterosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 604);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(button6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
        private ListView listViewHDRAsignadas;
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
        private ColumnHeader columnHeader3;
    }
}