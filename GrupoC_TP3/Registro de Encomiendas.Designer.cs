namespace GrupoC_TP3
{
    partial class RegistrarEncomiendas
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
            label3 = new Label();
            RegistrarAdmisionEncomiendasBox2 = new GroupBox();
            listView1 = new ListView();
            Numero = new ColumnHeader();
            ClienteRegistrarEncomienda = new ColumnHeader();
            FechaRegistrarEncomienda = new ColumnHeader();
            CantidadRegistroEncomienda = new ColumnHeader();
            PesoRegistroEncomienda = new ColumnHeader();
            button2 = new Button();
            button1 = new Button();
            DetalleEncomienda = new GroupBox();
            PesoDetalleEncomienda = new Label();
            CantidadDetalleEncomienda = new Label();
            DescripcionDetalleEncomienda = new Label();
            PesoDetalleEncomiendaTextBox = new TextBox();
            CantidadDetalleEncomiendaTextBox = new TextBox();
            DatoEncomiendas = new GroupBox();
            FechaDatoEncomiendaDateTimePicker1 = new DateTimePicker();
            FechaDatoEncomienda = new Label();
            ClienteDatoEncomienda = new Label();
            NumeroDeEncomienda = new Label();
            ClienteDatoEncomiendaTextBox = new TextBox();
            NumeroEncomiendaDatoTextBox = new TextBox();
            CancelarRegistroEncomiendaBTN = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            Tamaño = new Label();
            ListadoTamañoPaquete = new ComboBox();
            RegistrarAdmisionEncomiendasBox2.SuspendLayout();
            DetalleEncomienda.SuspendLayout();
            DatoEncomiendas.SuspendLayout();
            SuspendLayout();
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
            // RegistrarAdmisionEncomiendasBox2
            // 
            RegistrarAdmisionEncomiendasBox2.Controls.Add(listView1);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(button2);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(button1);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(DetalleEncomienda);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(DatoEncomiendas);
            RegistrarAdmisionEncomiendasBox2.Controls.Add(CancelarRegistroEncomiendaBTN);
            RegistrarAdmisionEncomiendasBox2.FlatStyle = FlatStyle.System;
            RegistrarAdmisionEncomiendasBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RegistrarAdmisionEncomiendasBox2.Location = new Point(12, 12);
            RegistrarAdmisionEncomiendasBox2.Name = "RegistrarAdmisionEncomiendasBox2";
            RegistrarAdmisionEncomiendasBox2.Size = new Size(775, 471);
            RegistrarAdmisionEncomiendasBox2.TabIndex = 12;
            RegistrarAdmisionEncomiendasBox2.TabStop = false;
            RegistrarAdmisionEncomiendasBox2.Text = "Registrar Encomiendas";
            RegistrarAdmisionEncomiendasBox2.Enter += groupBox2_Enter;
            // 
            // listView1
            // 
            listView1.AccessibleName = "ListadoDetalleEncomienda";
            listView1.Columns.AddRange(new ColumnHeader[] { Numero, ClienteRegistrarEncomienda, FechaRegistrarEncomienda, CantidadRegistroEncomienda, PesoRegistroEncomienda });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(50, 311);
            listView1.Name = "listView1";
            listView1.Size = new Size(465, 107);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Numero
            // 
            Numero.Text = "Numero";
            Numero.Width = 100;
            // 
            // ClienteRegistrarEncomienda
            // 
            ClienteRegistrarEncomienda.Text = "Cliente";
            ClienteRegistrarEncomienda.TextAlign = HorizontalAlignment.Center;
            ClienteRegistrarEncomienda.Width = 100;
            // 
            // FechaRegistrarEncomienda
            // 
            FechaRegistrarEncomienda.Text = "Fecha";
            FechaRegistrarEncomienda.TextAlign = HorizontalAlignment.Center;
            // 
            // CantidadRegistroEncomienda
            // 
            CantidadRegistroEncomienda.Text = "Cantidad";
            CantidadRegistroEncomienda.TextAlign = HorizontalAlignment.Center;
            CantidadRegistroEncomienda.Width = 100;
            // 
            // PesoRegistroEncomienda
            // 
            PesoRegistroEncomienda.Text = "Peso";
            PesoRegistroEncomienda.TextAlign = HorizontalAlignment.Center;
            PesoRegistroEncomienda.Width = 100;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
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
            button1.Location = new Point(490, 424);
            button1.Name = "button1";
            button1.Size = new Size(85, 30);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // DetalleEncomienda
            // 
            DetalleEncomienda.Controls.Add(ListadoTamañoPaquete);
            DetalleEncomienda.Controls.Add(Tamaño);
            DetalleEncomienda.Controls.Add(PesoDetalleEncomienda);
            DetalleEncomienda.Controls.Add(CantidadDetalleEncomienda);
            DetalleEncomienda.Controls.Add(DescripcionDetalleEncomienda);
            DetalleEncomienda.Controls.Add(PesoDetalleEncomiendaTextBox);
            DetalleEncomienda.Controls.Add(CantidadDetalleEncomiendaTextBox);
            DetalleEncomienda.Location = new Point(44, 194);
            DetalleEncomienda.Name = "DetalleEncomienda";
            DetalleEncomienda.Size = new Size(658, 100);
            DetalleEncomienda.TabIndex = 10;
            DetalleEncomienda.TabStop = false;
            DetalleEncomienda.Text = "Detalle de la encomienda";
            // 
            // PesoDetalleEncomienda
            // 
            PesoDetalleEncomienda.AutoSize = true;
            PesoDetalleEncomienda.Location = new Point(446, 43);
            PesoDetalleEncomienda.Name = "PesoDetalleEncomienda";
            PesoDetalleEncomienda.Size = new Size(40, 20);
            PesoDetalleEncomienda.TabIndex = 5;
            PesoDetalleEncomienda.Text = "Peso";
            // 
            // CantidadDetalleEncomienda
            // 
            CantidadDetalleEncomienda.AutoSize = true;
            CantidadDetalleEncomienda.Location = new Point(36, 43);
            CantidadDetalleEncomienda.Name = "CantidadDetalleEncomienda";
            CantidadDetalleEncomienda.Size = new Size(73, 20);
            CantidadDetalleEncomienda.TabIndex = 4;
            CantidadDetalleEncomienda.Text = "Cantidad";
            // 
            // DescripcionDetalleEncomienda
            // 
            DescripcionDetalleEncomienda.AutoSize = true;
            DescripcionDetalleEncomienda.Location = new Point(30, 43);
            DescripcionDetalleEncomienda.Name = "DescripcionDetalleEncomienda";
            DescripcionDetalleEncomienda.Size = new Size(0, 20);
            DescripcionDetalleEncomienda.TabIndex = 3;
            // 
            // PesoDetalleEncomiendaTextBox
            // 
            PesoDetalleEncomiendaTextBox.Location = new Point(446, 66);
            PesoDetalleEncomiendaTextBox.Name = "PesoDetalleEncomiendaTextBox";
            PesoDetalleEncomiendaTextBox.Size = new Size(200, 28);
            PesoDetalleEncomiendaTextBox.TabIndex = 2;
            // 
            // CantidadDetalleEncomiendaTextBox
            // 
            CantidadDetalleEncomiendaTextBox.Location = new Point(36, 66);
            CantidadDetalleEncomiendaTextBox.Name = "CantidadDetalleEncomiendaTextBox";
            CantidadDetalleEncomiendaTextBox.Size = new Size(182, 28);
            CantidadDetalleEncomiendaTextBox.TabIndex = 1;
            // 
            // DatoEncomiendas
            // 
            DatoEncomiendas.Controls.Add(FechaDatoEncomiendaDateTimePicker1);
            DatoEncomiendas.Controls.Add(FechaDatoEncomienda);
            DatoEncomiendas.Controls.Add(ClienteDatoEncomienda);
            DatoEncomiendas.Controls.Add(NumeroDeEncomienda);
            DatoEncomiendas.Controls.Add(ClienteDatoEncomiendaTextBox);
            DatoEncomiendas.Controls.Add(NumeroEncomiendaDatoTextBox);
            DatoEncomiendas.ImeMode = ImeMode.Off;
            DatoEncomiendas.Location = new Point(44, 27);
            DatoEncomiendas.Name = "DatoEncomiendas";
            DatoEncomiendas.Size = new Size(658, 128);
            DatoEncomiendas.TabIndex = 9;
            DatoEncomiendas.TabStop = false;
            DatoEncomiendas.Text = "Datos de la encomienda";
            // 
            // FechaDatoEncomiendaDateTimePicker1
            // 
            FechaDatoEncomiendaDateTimePicker1.Location = new Point(446, 80);
            FechaDatoEncomiendaDateTimePicker1.Name = "FechaDatoEncomiendaDateTimePicker1";
            FechaDatoEncomiendaDateTimePicker1.Size = new Size(200, 28);
            FechaDatoEncomiendaDateTimePicker1.TabIndex = 6;
            // 
            // FechaDatoEncomienda
            // 
            FechaDatoEncomienda.AutoSize = true;
            FechaDatoEncomienda.Location = new Point(458, 45);
            FechaDatoEncomienda.Name = "FechaDatoEncomienda";
            FechaDatoEncomienda.Size = new Size(138, 20);
            FechaDatoEncomienda.TabIndex = 5;
            FechaDatoEncomienda.Text = "Fecha de Admision";
            // 
            // ClienteDatoEncomienda
            // 
            ClienteDatoEncomienda.AutoSize = true;
            ClienteDatoEncomienda.Location = new Point(231, 45);
            ClienteDatoEncomienda.Name = "ClienteDatoEncomienda";
            ClienteDatoEncomienda.Size = new Size(57, 20);
            ClienteDatoEncomienda.TabIndex = 4;
            ClienteDatoEncomienda.Text = "Cliente";
            // 
            // NumeroDeEncomienda
            // 
            NumeroDeEncomienda.AutoSize = true;
            NumeroDeEncomienda.Location = new Point(30, 45);
            NumeroDeEncomienda.Name = "NumeroDeEncomienda";
            NumeroDeEncomienda.Size = new Size(174, 20);
            NumeroDeEncomienda.TabIndex = 3;
            NumeroDeEncomienda.Text = "Numero de Encomienda";
            // 
            // ClienteDatoEncomiendaTextBox
            // 
            ClienteDatoEncomiendaTextBox.Location = new Point(231, 80);
            ClienteDatoEncomiendaTextBox.Name = "ClienteDatoEncomiendaTextBox";
            ClienteDatoEncomiendaTextBox.Size = new Size(182, 28);
            ClienteDatoEncomiendaTextBox.TabIndex = 1;
            // 
            // NumeroEncomiendaDatoTextBox
            // 
            NumeroEncomiendaDatoTextBox.Location = new Point(30, 80);
            NumeroEncomiendaDatoTextBox.Name = "NumeroEncomiendaDatoTextBox";
            NumeroEncomiendaDatoTextBox.Size = new Size(174, 28);
            NumeroEncomiendaDatoTextBox.TabIndex = 0;
            // 
            // CancelarRegistroEncomiendaBTN
            // 
            CancelarRegistroEncomiendaBTN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelarRegistroEncomiendaBTN.Location = new Point(684, 424);
            CancelarRegistroEncomiendaBTN.Name = "CancelarRegistroEncomiendaBTN";
            CancelarRegistroEncomiendaBTN.Size = new Size(85, 30);
            CancelarRegistroEncomiendaBTN.TabIndex = 6;
            CancelarRegistroEncomiendaBTN.Text = "Cancelar";
            CancelarRegistroEncomiendaBTN.UseVisualStyleBackColor = true;
            // 
            // Tamaño
            // 
            Tamaño.AutoSize = true;
            Tamaño.Location = new Point(242, 43);
            Tamaño.Name = "Tamaño";
            Tamaño.Size = new Size(65, 20);
            Tamaño.TabIndex = 6;
            Tamaño.Text = "Tamaño";
            // 
            // ListadoTamañoPaquete
            // 
            ListadoTamañoPaquete.FormattingEnabled = true;
            ListadoTamañoPaquete.Location = new Point(242, 66);
            ListadoTamañoPaquete.Name = "ListadoTamañoPaquete";
            ListadoTamañoPaquete.Size = new Size(183, 28);
            ListadoTamañoPaquete.TabIndex = 7;
            // 
            // RegistrarEncomiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 492);
            Controls.Add(RegistrarAdmisionEncomiendasBox2);
            Controls.Add(label3);
            Name = "RegistrarEncomiendas";
            Text = "Registrar Encomiendas";
            RegistrarAdmisionEncomiendasBox2.ResumeLayout(false);
            DetalleEncomienda.ResumeLayout(false);
            DetalleEncomienda.PerformLayout();
            DatoEncomiendas.ResumeLayout(false);
            DatoEncomiendas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private GroupBox RegistrarAdmisionEncomiendasBox2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button CancelarRegistroEncomiendaBTN;
        private GroupBox DatoEncomiendas;
        private TextBox ClienteDatoEncomiendaTextBox;
        private TextBox NumeroEncomiendaDatoTextBox;
        private GroupBox DetalleEncomienda;
        private TextBox textBox;
        private TextBox CantidadDetalleEncomiendaTextBox;
        private DateTimePicker FechaDatoEncomiendaDateTimePicker1;
        private Label FechaDatoEncomienda;
        private Label ClienteDatoEncomienda;
        private Label NumeroDeEncomienda;
        private Label PesoDetalleEncomienda;
        private Label CantidadDetalleEncomienda;
        private Label DescripcionDetalleEncomienda;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Numero;
        private ColumnHeader ClienteRegistrarEncomienda;
        private ColumnHeader FechaRegistrarEncomienda;
        private ColumnHeader CantidadRegistroEncomienda;
        private ColumnHeader PesoRegistroEncomienda;
        private TextBox PesoDetalleEncomiendaTextBox;
        private Label Tamaño;
        private ComboBox ListadoTamañoPaquete;
    }
}