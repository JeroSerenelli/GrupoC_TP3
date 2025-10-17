namespace GrupoC_TP3.CU10_ResultadoCostosVsVentas
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
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFin = new DateTimePicker();
            buttonBuscar = new Button();
            groupBox2 = new GroupBox();
            listViewResultados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label17 = new Label();
            label18 = new Label();
            buttonAceptar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePickerInicio);
            groupBox1.Controls.Add(dateTimePickerFin);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Location = new Point(25, 62);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(431, 109);
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
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.CustomFormat = "MMMM yyyy";
            dateTimePickerInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicio.Location = new Point(118, 20);
            dateTimePickerInicio.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.ShowUpDown = true;
            dateTimePickerInicio.Size = new Size(219, 23);
            dateTimePickerInicio.TabIndex = 10;
            dateTimePickerInicio.Value = new DateTime(2025, 9, 2, 0, 0, 0, 0);
            dateTimePickerInicio.ValueChanged += IniciodateTimePicker_ValueChanged;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.CustomFormat = "MMMM yyyy";
            dateTimePickerFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerFin.Location = new Point(118, 49);
            dateTimePickerFin.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.ShowUpDown = true;
            dateTimePickerFin.Size = new Size(219, 23);
            dateTimePickerFin.TabIndex = 10;
            dateTimePickerFin.Value = new DateTime(2025, 10, 2, 0, 0, 0, 0);
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(332, 82);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 22);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewResultados);
            groupBox2.Location = new Point(25, 187);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(431, 124);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado de Resultados";
            // 
            // listViewResultados
            // 
            listViewResultados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewResultados.GridLines = true;
            listViewResultados.Location = new Point(8, 20);
            listViewResultados.Name = "listViewResultados";
            listViewResultados.Size = new Size(412, 97);
            listViewResultados.TabIndex = 0;
            listViewResultados.UseCompatibleStateImageBehavior = false;
            listViewResultados.View = View.Details;
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
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(362, 322);
            buttonAceptar.Margin = new Padding(3, 2, 3, 2);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(94, 22);
            buttonAceptar.TabIndex = 14;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // ResultadoCostosVsVentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 353);
            Controls.Add(buttonAceptar);
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
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFin;
        private Button buttonBuscar;
        private GroupBox groupBox2;
        private ListView listViewResultados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label17;
        private Label label18;
        private Button buttonAceptar;
    }
}