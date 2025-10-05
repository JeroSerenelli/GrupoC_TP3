
namespace GrupoC_TP3
{
    partial class RendicionHDRRendFletero
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
            TutasaTitulo = new Label();
            TutasaSubText = new Label();
            HDRfletBox = new GroupBox();
            FechaHDRFletlabel1 = new Label();
            HDRFLetdateTimePicker = new DateTimePicker();
            FletAsiglabel = new Label();
            FletAsigtextBox = new TextBox();
            buttonBuscarHDRFlet = new Button();
            TipoHDRFletText = new Label();
            TipoHDRFlettextBox = new TextBox();
            NumHDRFlet = new Label();
            NumHDRFlettextBox1 = new TextBox();
            ListadoEncoHDRFletgroupBox2 = new GroupBox();
            ListadoEncoHDRFletlistView1 = new ListView();
            Numerohojaderuta = new ColumnHeader();
            Numerodeguia = new ColumnHeader();
            Cliente = new ColumnHeader();
            Estado = new ColumnHeader();
            buttonConfirHDRFlet = new Button();
            HDRfletBox.SuspendLayout();
            ListadoEncoHDRFletgroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaTitulo
            // 
            TutasaTitulo.AutoSize = true;
            TutasaTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TutasaTitulo.Location = new Point(386, 12);
            TutasaTitulo.Name = "TutasaTitulo";
            TutasaTitulo.Size = new Size(84, 25);
            TutasaTitulo.TabIndex = 8;
            TutasaTitulo.Text = "TUTASA";
            // 
            // TutasaSubText
            // 
            TutasaSubText.AutoSize = true;
            TutasaSubText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TutasaSubText.Location = new Point(278, 39);
            TutasaSubText.Name = "TutasaSubText";
            TutasaSubText.Size = new Size(342, 20);
            TutasaSubText.TabIndex = 9;
            TutasaSubText.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // HDRfletBox
            // 
            HDRfletBox.Controls.Add(FechaHDRFletlabel1);
            HDRfletBox.Controls.Add(HDRFLetdateTimePicker);
            HDRfletBox.Controls.Add(FletAsiglabel);
            HDRfletBox.Controls.Add(FletAsigtextBox);
            HDRfletBox.Controls.Add(buttonBuscarHDRFlet);
            HDRfletBox.Controls.Add(TipoHDRFletText);
            HDRfletBox.Controls.Add(TipoHDRFlettextBox);
            HDRfletBox.Controls.Add(NumHDRFlet);
            HDRfletBox.Controls.Add(NumHDRFlettextBox1);
            HDRfletBox.Location = new Point(21, 77);
            HDRfletBox.Name = "HDRfletBox";
            HDRfletBox.Size = new Size(565, 372);
            HDRfletBox.TabIndex = 10;
            HDRfletBox.TabStop = false;
            HDRfletBox.Text = "Datos de Hoja de ruta";
            // 
            // FechaHDRFletlabel1
            // 
            FechaHDRFletlabel1.AutoSize = true;
            FechaHDRFletlabel1.Location = new Point(21, 260);
            FechaHDRFletlabel1.Name = "FechaHDRFletlabel1";
            FechaHDRFletlabel1.Size = new Size(152, 20);
            FechaHDRFletlabel1.TabIndex = 11;
            FechaHDRFletlabel1.Text = "Fecha de hoja de ruta";
            // 
            // HDRFLetdateTimePicker
            // 
            HDRFLetdateTimePicker.Location = new Point(21, 284);
            HDRFLetdateTimePicker.Margin = new Padding(3, 4, 3, 4);
            HDRFLetdateTimePicker.Name = "HDRFLetdateTimePicker";
            HDRFLetdateTimePicker.Size = new Size(239, 27);
            HDRFLetdateTimePicker.TabIndex = 7;
            // 
            // FletAsiglabel
            // 
            FletAsiglabel.AutoSize = true;
            FletAsiglabel.Location = new Point(21, 189);
            FletAsiglabel.Name = "FletAsiglabel";
            FletAsiglabel.Size = new Size(120, 20);
            FletAsiglabel.TabIndex = 6;
            FletAsiglabel.Text = "Fletero asignado";
            // 
            // FletAsigtextBox
            // 
            FletAsigtextBox.Location = new Point(21, 212);
            FletAsigtextBox.Name = "FletAsigtextBox";
            FletAsigtextBox.Size = new Size(239, 27);
            FletAsigtextBox.TabIndex = 5;
            // 
            // buttonBuscarHDRFlet
            // 
            buttonBuscarHDRFlet.Location = new Point(443, 316);
            buttonBuscarHDRFlet.Name = "buttonBuscarHDRFlet";
            buttonBuscarHDRFlet.Size = new Size(96, 35);
            buttonBuscarHDRFlet.TabIndex = 4;
            buttonBuscarHDRFlet.Text = "Buscar";
            buttonBuscarHDRFlet.UseVisualStyleBackColor = true;
            // 
            // TipoHDRFletText
            // 
            TipoHDRFletText.AutoSize = true;
            TipoHDRFletText.Location = new Point(21, 116);
            TipoHDRFletText.Name = "TipoHDRFletText";
            TipoHDRFletText.Size = new Size(144, 20);
            TipoHDRFletText.TabIndex = 3;
            TipoHDRFletText.Text = "Tipo de hoja de ruta";
            // 
            // TipoHDRFlettextBox
            // 
            TipoHDRFlettextBox.Location = new Point(21, 140);
            TipoHDRFlettextBox.Name = "TipoHDRFlettextBox";
            TipoHDRFlettextBox.Size = new Size(239, 27);
            TipoHDRFlettextBox.TabIndex = 2;
            // 
            // NumHDRFlet
            // 
            NumHDRFlet.AutoSize = true;
            NumHDRFlet.Location = new Point(21, 44);
            NumHDRFlet.Name = "NumHDRFlet";
            NumHDRFlet.Size = new Size(168, 20);
            NumHDRFlet.TabIndex = 1;
            NumHDRFlet.Text = "Número de hoja de ruta";
            // 
            // NumHDRFlettextBox1
            // 
            NumHDRFlettextBox1.Location = new Point(21, 69);
            NumHDRFlettextBox1.Name = "NumHDRFlettextBox1";
            NumHDRFlettextBox1.Size = new Size(239, 27);
            NumHDRFlettextBox1.TabIndex = 0;
            // 
            // ListadoEncoHDRFletgroupBox2
            // 
            ListadoEncoHDRFletgroupBox2.Controls.Add(ListadoEncoHDRFletlistView1);
            ListadoEncoHDRFletgroupBox2.Location = new Point(21, 455);
            ListadoEncoHDRFletgroupBox2.Name = "ListadoEncoHDRFletgroupBox2";
            ListadoEncoHDRFletgroupBox2.Size = new Size(658, 237);
            ListadoEncoHDRFletgroupBox2.TabIndex = 11;
            ListadoEncoHDRFletgroupBox2.TabStop = false;
            ListadoEncoHDRFletgroupBox2.Text = "Listado de encomiendas";
            // 
            // ListadoEncoHDRFletlistView1
            // 
            ListadoEncoHDRFletlistView1.Columns.AddRange(new ColumnHeader[] { Numerohojaderuta, Numerodeguia, Cliente, Estado });
            ListadoEncoHDRFletlistView1.GridLines = true;
            ListadoEncoHDRFletlistView1.LabelEdit = true;
            ListadoEncoHDRFletlistView1.Location = new Point(33, 37);
            ListadoEncoHDRFletlistView1.Name = "ListadoEncoHDRFletlistView1";
            ListadoEncoHDRFletlistView1.Size = new Size(524, 183);
            ListadoEncoHDRFletlistView1.TabIndex = 0;
            ListadoEncoHDRFletlistView1.UseCompatibleStateImageBehavior = false;
            ListadoEncoHDRFletlistView1.View = View.Details;
            ListadoEncoHDRFletlistView1.SelectedIndexChanged += ListadoEncoHDRFletlistView1_SelectedIndexChanged;
            // 
            // Numerohojaderuta
            // 
            Numerohojaderuta.Text = "Nro Hoja de ruta";
            Numerohojaderuta.Width = 130;
            // 
            // Numerodeguia
            // 
            Numerodeguia.Text = "Nro de Guía";
            Numerodeguia.Width = 130;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 130;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 130;
            // 
            // buttonConfirHDRFlet
            // 
            buttonConfirHDRFlet.Location = new Point(826, 689);
            buttonConfirHDRFlet.Name = "buttonConfirHDRFlet";
            buttonConfirHDRFlet.Size = new Size(110, 28);
            buttonConfirHDRFlet.TabIndex = 12;
            buttonConfirHDRFlet.Text = "Confirmar";
            buttonConfirHDRFlet.UseVisualStyleBackColor = true;
            // 
            // RendicionHDRRendFletero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 732);
            Controls.Add(buttonConfirHDRFlet);
            Controls.Add(ListadoEncoHDRFletgroupBox2);
            Controls.Add(HDRfletBox);
            Controls.Add(TutasaSubText);
            Controls.Add(TutasaTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RendicionHDRRendFletero";
            Text = "Hojas de rutas rendidas";
            Load += RendicionHDRRendFletero_Load;
            HDRfletBox.ResumeLayout(false);
            HDRfletBox.PerformLayout();
            ListadoEncoHDRFletgroupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void ListadoEncoHDRFletlistView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label TutasaTitulo;
        private Label TutasaSubText;
        private GroupBox HDRfletBox;
        private Button buttonBuscarHDRFlet;
        private Label TipoHDRFletText;
        private TextBox TipoHDRFlettextBox;
        private Label NumHDRFlet;
        private TextBox NumHDRFlettextBox1;
        private Label FletAsiglabel;
        private TextBox FletAsigtextBox;
        private DateTimePicker HDRFLetdateTimePicker;
        private Label FechaHDRFletlabel1;
        private GroupBox ListadoEncoHDRFletgroupBox2;
        private ListView ListadoEncoHDRFletlistView1;
        private ColumnHeader Numerohojaderuta;
        private ColumnHeader Numerodeguia;
        private ColumnHeader Cliente;
        private ColumnHeader Estado;
        private Button buttonConfirHDRFlet;
    }
}