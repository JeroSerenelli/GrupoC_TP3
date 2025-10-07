namespace GrupoC_TP3.ResultadoCostosVsVentas
{
    partial class ResultadoCostosVsVentasForm
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
            label3 = new Label();
            label2 = new Label();
            IniciodateTimePicker = new DateTimePicker();
            FindateTimePicker = new DateTimePicker();
            button1 = new Button();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label17 = new Label();
            label18 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(IniciodateTimePicker);
            groupBox1.Controls.Add(FindateTimePicker);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(25, 62);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(476, 109);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo de busqueda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 13;
            label3.Text = "Fin de Periodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 24);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 12;
            label2.Text = "Incio de Periodo:";
            // 
            // IniciodateTimePicker
            // 
            IniciodateTimePicker.CustomFormat = "MMMM yyyy";
            IniciodateTimePicker.Format = DateTimePickerFormat.Custom;
            IniciodateTimePicker.Location = new Point(118, 20);
            IniciodateTimePicker.Margin = new Padding(3, 2, 3, 2);
            IniciodateTimePicker.Name = "IniciodateTimePicker";
            IniciodateTimePicker.ShowUpDown = true;
            IniciodateTimePicker.Size = new Size(219, 23);
            IniciodateTimePicker.TabIndex = 10;
            IniciodateTimePicker.Value = new DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // FindateTimePicker
            // 
            FindateTimePicker.CustomFormat = "MMMM yyyy";
            FindateTimePicker.Format = DateTimePickerFormat.Custom;
            FindateTimePicker.Location = new Point(118, 49);
            FindateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FindateTimePicker.Name = "FindateTimePicker";
            FindateTimePicker.ShowUpDown = true;
            FindateTimePicker.Size = new Size(219, 23);
            FindateTimePicker.TabIndex = 9;
            FindateTimePicker.Value = new DateTime(2025, 10, 2, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(388, 83);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(25, 187);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(476, 122);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado de Resultados";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(8, 20);
            listView1.Name = "listView1";
            listView1.Size = new Size(459, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Empresa de Transporte";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ventas";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Costo";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Resultado";
            columnHeader4.Width = 100;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(126, 29);
            label17.Name = "label17";
            label17.Size = new Size(269, 15);
            label17.TabIndex = 50;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(208, 9);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 49;
            label18.Text = "TUTASA";
            // 
            // ResultadoCostosVsVentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 340);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResultadoCostosVsVentasForm";
            Text = "Estado de Resultados";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private DateTimePicker IniciodateTimePicker;
        private DateTimePicker FindateTimePicker;
        private Button button1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label17;
        private Label label18;
    }
}