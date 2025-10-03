namespace GrupoC_TP3
{
    partial class HojaDeRuta
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
            BuscarHDR = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            LimpiarBusquedaHDR = new Button();
            TablaDatosHDRdataGridView1 = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            NumeroHDRTxt = new TextBox();
            NumeroDeTramite = new Label();
            RegistrarAdmisionEncomiendasBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Nro_Encomienda = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Fecha_Ingreso_Encomienda = new DataGridViewTextBoxColumn();
            Cantidad_Encomienda = new DataGridViewTextBoxColumn();
            Peso_Encomienda = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            CancelarRegistroEncomiendaBTN = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaDatosHDRdataGridView1).BeginInit();
            RegistrarAdmisionEncomiendasBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BuscarHDR
            // 
            BuscarHDR.AccessibleName = "Buscar";
            BuscarHDR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarHDR.Location = new Point(320, 26);
            BuscarHDR.Name = "BuscarHDR";
            BuscarHDR.Size = new Size(74, 32);
            BuscarHDR.TabIndex = 5;
            BuscarHDR.Text = "Buscar";
            BuscarHDR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AccessibleName = "NumeroDeTramite";
            label3.AutoSize = true;
            label3.Location = new Point(42, 139);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 8);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 10;
            label4.Text = "Tramites";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LimpiarBusquedaHDR);
            groupBox1.Controls.Add(TablaDatosHDRdataGridView1);
            groupBox1.Controls.Add(NumeroHDRTxt);
            groupBox1.Controls.Add(NumeroDeTramite);
            groupBox1.Controls.Add(BuscarHDR);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 205);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Hoja de Ruta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // LimpiarBusquedaHDR
            // 
            LimpiarBusquedaHDR.AccessibleName = "Limpiar";
            LimpiarBusquedaHDR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LimpiarBusquedaHDR.Location = new Point(410, 26);
            LimpiarBusquedaHDR.Name = "LimpiarBusquedaHDR";
            LimpiarBusquedaHDR.Size = new Size(74, 32);
            LimpiarBusquedaHDR.TabIndex = 15;
            LimpiarBusquedaHDR.Text = "Limpiar";
            LimpiarBusquedaHDR.UseVisualStyleBackColor = true;
            // 
            // TablaDatosHDRdataGridView1
            // 
            TablaDatosHDRdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaDatosHDRdataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numero, Fecha, Titulo });
            TablaDatosHDRdataGridView1.Location = new Point(51, 74);
            TablaDatosHDRdataGridView1.Name = "TablaDatosHDRdataGridView1";
            TablaDatosHDRdataGridView1.Size = new Size(343, 54);
            TablaDatosHDRdataGridView1.TabIndex = 14;
            TablaDatosHDRdataGridView1.CellContentClick += TablaDatosHDRdataGridView1_CellContentClick;
            // 
            // Numero
            // 
            Numero.HeaderText = "Numero";
            Numero.Name = "Numero";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            // 
            // NumeroHDRTxt
            // 
            NumeroHDRTxt.AccessibleName = "NumeroDeTramiteTxt";
            NumeroHDRTxt.Location = new Point(161, 28);
            NumeroHDRTxt.Name = "NumeroHDRTxt";
            NumeroHDRTxt.Size = new Size(143, 27);
            NumeroHDRTxt.TabIndex = 12;
            // 
            // NumeroDeTramite
            // 
            NumeroDeTramite.AccessibleName = "NumeroDeTramite";
            NumeroDeTramite.AutoSize = true;
            NumeroDeTramite.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumeroDeTramite.Location = new Point(27, 34);
            NumeroDeTramite.Name = "NumeroDeTramite";
            NumeroDeTramite.Size = new Size(115, 17);
            NumeroDeTramite.TabIndex = 12;
            NumeroDeTramite.Text = "NumeroDeTramite";
            // 
            // RegistrarAdmisionEncomiendasBox2
            // 
            RegistrarAdmisionEncomiendasBox2.Controls.Add(button2);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(button1);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(dataGridView1);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(groupBox3);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(groupBox2);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(CancelarRegistroEncomiendaBTN);
            RegistrarAdmisionEncomiendasBox2.FlatStyle = FlatStyle.System;
            RegistrarAdmisionEncomiendasBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RegistrarAdmisionEncomiendasBox2.Location = new Point(38, 250);
            RegistrarAdmisionEncomiendasBox2.Name = "RegistrarAdmisionEncomiendasBox2";
            RegistrarAdmisionEncomiendasBox2.Size = new Size(775, 471);
            RegistrarAdmisionEncomiendasBox2.TabIndex = 12;
            RegistrarAdmisionEncomiendasBox2.TabStop = false;
            RegistrarAdmisionEncomiendasBox2.Text = "Registrar Encomiendas";
            RegistrarAdmisionEncomiendasBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(593, 424);
            button2.Name = "button2";
            button2.Size = new Size(85, 30);
            button2.TabIndex = 13;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(502, 424);
            button1.Name = "button1";
            button1.Size = new Size(85, 30);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nro_Encomienda, Cliente, Fecha_Ingreso_Encomienda, Cantidad_Encomienda, Peso_Encomienda });
            dataGridView1.Location = new Point(44, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(725, 111);
            dataGridView1.TabIndex = 11;
            // 
            // Nro_Encomienda
            // 
            Nro_Encomienda.HeaderText = "Numero de Encomienda";
            Nro_Encomienda.Name = "Nro_Encomienda";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Fecha_Ingreso_Encomienda
            // 
            Fecha_Ingreso_Encomienda.HeaderText = "Fecha";
            Fecha_Ingreso_Encomienda.Name = "Fecha_Ingreso_Encomienda";
            // 
            // Cantidad_Encomienda
            // 
            Cantidad_Encomienda.HeaderText = "Cantidad";
            Cantidad_Encomienda.Name = "Cantidad_Encomienda";
            // 
            // Peso_Encomienda
            // 
            Peso_Encomienda.HeaderText = "Peso";
            Peso_Encomienda.Name = "Peso_Encomienda";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(44, 194);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(658, 100);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de la encomienda";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(446, 43);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 5;
            label8.Text = "Peso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 43);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 4;
            label7.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 43);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 3;
            label6.Text = "Descripcion";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(446, 66);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 28);
            textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 28);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 28);
            textBox3.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(44, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(658, 128);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la encomienda";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(446, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 28);
            dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 45);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 5;
            label5.Text = "Fecha de Admision";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 45);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 3;
            label1.Text = "Numero de Encomienda";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 28);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 28);
            textBox1.TabIndex = 0;
            // 
            // CancelarRegistroEncomiendaBTN
            // 
            CancelarRegistroEncomiendaBTN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelarRegistroEncomiendaBTN.Location = new Point(690, 424);
            CancelarRegistroEncomiendaBTN.Name = "CancelarRegistroEncomiendaBTN";
            CancelarRegistroEncomiendaBTN.Size = new Size(85, 30);
            CancelarRegistroEncomiendaBTN.TabIndex = 6;
            CancelarRegistroEncomiendaBTN.Text = "Cancelar";
            CancelarRegistroEncomiendaBTN.UseVisualStyleBackColor = true;
            // 
            // HojaDeRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 749);
            Controls.Add(RegistrarAdmisionEncomiendasBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "HojaDeRuta";
            Text = "HojaDeRuta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TablaDatosHDRdataGridView1).EndInit();
            RegistrarAdmisionEncomiendasBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BuscarHDR;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox NumeroHDRTxt;
        private Label NumeroDeTramite;
        private GroupBox RegistrarAdmisionEncomiendasBox2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button CancelarRegistroEncomiendaBTN;
        private DataGridView TablaDatosHDRdataGridView1;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Titulo;
        private Button LimpiarBusquedaHDR;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridViewTextBoxColumn Nro_Encomienda;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fecha_Ingreso_Encomienda;
        private DataGridViewTextBoxColumn Cantidad_Encomienda;
        private DataGridViewTextBoxColumn Peso_Encomienda;
        private Button button2;
        private Button button1;
    }
}