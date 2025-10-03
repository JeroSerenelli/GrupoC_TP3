namespace GrupoC_TP3.ConfeccionarHojaDeRuta
{
    partial class ConfeccionarHojaDeRuta
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
            label2 = new Label();
            RetirocheckBox1 = new CheckBox();
            TransportecheckBox1 = new CheckBox();
            RetirogroupBox1 = new GroupBox();
            TransportegroupBox1 = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            RetiroOrigentextBox1 = new TextBox();
            label4 = new Label();
            ListadoChofereTransportecomboBox1 = new ComboBox();
            DestinoRetirotextBox2 = new TextBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            listView1 = new ListView();
            NumerodeGuia = new ColumnHeader();
            Chofer = new ColumnHeader();
            listView2 = new ListView();
            NumerodeGuiaRetiro = new ColumnHeader();
            OrigenRetiro = new ColumnHeader();
            DestinoRetiro = new ColumnHeader();
//            this.AgregarRetiro = new Button();
           // this.Transportebutton = new Button();
            EntregacheckBox = new CheckBox();
            EntregaGroupBox1 = new GroupBox();
           // this.AgregarEntregabutton = new Button();
            listView3 = new ListView();
            //this.NumeroGuiaEntrega = new ColumnHeader();
          //  this.OrigenEntrega1 = new ColumnHeader();
            DestinoEntrega1 = new ColumnHeader();
            comboBox4 = new ComboBox();
          //  this.NumeroGuia = new Label();
           // this.DestinoEntregatextBox1 = new TextBox();
            OrigenEntregatextBox2 = new TextBox();
            label10 = new Label();
            OrigenEntrega = new Label();
            Confirmarbutton1 = new Button();
            Cancelarbutton1 = new Button();
            ListadoChoferesEntregacomboBox5 = new ComboBox();
            ListadoChoferesEntregalabel6 = new Label();
            ListadoChoferesRetirocomboBox6 = new ComboBox();
            label8 = new Label();
            ChoferesEntrega = new ColumnHeader();
            ChoferesRetiro = new ColumnHeader();
            RetirogroupBox1.SuspendLayout();
            TransportegroupBox1.SuspendLayout();
            EntregaGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 31);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 2;
            label2.Text = "Seleccione el tipo de operacion: ";
            label2.Click += label2_Click;
            // 
            // RetirocheckBox1
            // 
            RetirocheckBox1.AutoSize = true;
            RetirocheckBox1.Location = new Point(302, 31);
            RetirocheckBox1.Name = "RetirocheckBox1";
            RetirocheckBox1.Size = new Size(57, 19);
            RetirocheckBox1.TabIndex = 4;
            RetirocheckBox1.Text = "Retiro";
            RetirocheckBox1.UseVisualStyleBackColor = true;
            // 
            // TransportecheckBox1
            // 
            TransportecheckBox1.AutoSize = true;
            TransportecheckBox1.Location = new Point(302, 81);
            TransportecheckBox1.Name = "TransportecheckBox1";
            TransportecheckBox1.Size = new Size(81, 19);
            TransportecheckBox1.TabIndex = 6;
            TransportecheckBox1.Text = "Transporte";
            TransportecheckBox1.UseVisualStyleBackColor = true;
            // 
            // RetirogroupBox1
            // 
            RetirogroupBox1.Controls.Add(ListadoChoferesRetirocomboBox6);
            RetirogroupBox1.Controls.Add(label8);
            //RetirogroupBox1.Controls.Add(this.AgregarRetiro);
            RetirogroupBox1.Controls.Add(listView2);
            RetirogroupBox1.Controls.Add(comboBox2);
            RetirogroupBox1.Controls.Add(label5);
            RetirogroupBox1.Controls.Add(DestinoRetirotextBox2);
            RetirogroupBox1.Controls.Add(RetiroOrigentextBox1);
            RetirogroupBox1.Controls.Add(label3);
            RetirogroupBox1.Controls.Add(label1);
            RetirogroupBox1.Location = new Point(42, 106);
            RetirogroupBox1.Name = "RetirogroupBox1";
            RetirogroupBox1.Size = new Size(731, 206);
            RetirogroupBox1.TabIndex = 7;
            RetirogroupBox1.TabStop = false;
            RetirogroupBox1.Text = "Retiro ";
            // 
            // TransportegroupBox1
            // 
          //  TransportegroupBox1.Controls.Add(this.Transportebutton);
            TransportegroupBox1.Controls.Add(listView1);
            TransportegroupBox1.Controls.Add(comboBox3);
            TransportegroupBox1.Controls.Add(label7);
            TransportegroupBox1.Controls.Add(ListadoChofereTransportecomboBox1);
            TransportegroupBox1.Controls.Add(label4);
            TransportegroupBox1.Location = new Point(42, 550);
            TransportegroupBox1.Name = "TransportegroupBox1";
            TransportegroupBox1.Size = new Size(731, 205);
            TransportegroupBox1.TabIndex = 9;
            TransportegroupBox1.TabStop = false;
            TransportegroupBox1.Text = "Transporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 27);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Destino";
            // 
            // RetiroOrigentextBox1
            // 
            RetiroOrigentextBox1.Location = new Point(172, 24);
            RetiroOrigentextBox1.Name = "RetiroOrigentextBox1";
            RetiroOrigentextBox1.Size = new Size(151, 23);
            RetiroOrigentextBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 37);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 0;
            label4.Text = "Listado de choferes";
            // 
            // ListadoChofereTransportecomboBox1
            // 
            ListadoChofereTransportecomboBox1.FormattingEnabled = true;
            ListadoChofereTransportecomboBox1.Location = new Point(510, 34);
            ListadoChofereTransportecomboBox1.Name = "ListadoChofereTransportecomboBox1";
            ListadoChofereTransportecomboBox1.Size = new Size(171, 23);
            ListadoChofereTransportecomboBox1.TabIndex = 1;
            // 
            // DestinoRetirotextBox2
            // 
            DestinoRetirotextBox2.Location = new Point(492, 27);
            DestinoRetirotextBox2.Name = "DestinoRetirotextBox2";
            DestinoRetirotextBox2.Size = new Size(177, 23);
            DestinoRetirotextBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 66);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 4;
            label5.Text = "Numero de guias";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(172, 63);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 23);
            comboBox2.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 42);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 2;
            label7.Text = "Numero de guias";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(156, 34);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 23);
            comboBox3.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumerodeGuia, Chofer });
            listView1.GridLines = true;
            listView1.Location = new Point(42, 99);
            listView1.Name = "listView1";
            listView1.Size = new Size(204, 87);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumerodeGuia
            // 
            NumerodeGuia.Text = "Numero de Guia";
            NumerodeGuia.Width = 100;
            // 
            // Chofer
            // 
            Chofer.Text = "Chofer";
            Chofer.TextAlign = HorizontalAlignment.Center;
            Chofer.Width = 100;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { NumerodeGuiaRetiro, OrigenRetiro, DestinoRetiro, ChoferesRetiro });
            listView2.GridLines = true;
            listView2.Location = new Point(42, 102);
            listView2.Name = "listView2";
            listView2.Size = new Size(406, 98);
            listView2.TabIndex = 10;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // NumerodeGuiaRetiro
            // 
            NumerodeGuiaRetiro.Text = "Numero de Guia";
            NumerodeGuiaRetiro.Width = 100;
            // 
            // OrigenRetiro
            // 
            OrigenRetiro.Text = "Origen";
            OrigenRetiro.TextAlign = HorizontalAlignment.Center;
            OrigenRetiro.Width = 100;
            // 
            // DestinoRetiro
            // 
            DestinoRetiro.Text = "Destino";
            DestinoRetiro.TextAlign = HorizontalAlignment.Center;
            DestinoRetiro.Width = 100;
            // 
            // AgregarRetiro
            // 
            /*this.AgregarRetiro.Location = new Point(542, 123);
            this.AgregarRetiro.Name = "AgregarRetiro";
            this.AgregarRetiro.Size = new Size(75, 23);
            this.AgregarRetiro.TabIndex = 11;
            this.AgregarRetiro.Text = "Agregar";
            this.AgregarRetiro.UseVisualStyleBackColor = true;
            */// 
            // Transportebutton
            // 
            /*this.Transportebutton.Location = new Point(542, 135);
            this.Transportebutton.Name = "Transportebutton";
            this.Transportebutton.Size = new Size(75, 23);
            this.Transportebutton.TabIndex = 12;
            this.Transportebutton.Text = "Agregar";
            this.Transportebutton.UseVisualStyleBackColor = true;
            */
            // 
            // EntregacheckBox
            // 
            EntregacheckBox.AutoSize = true;
            EntregacheckBox.Location = new Point(302, 56);
            EntregacheckBox.Name = "EntregacheckBox";
            EntregacheckBox.Size = new Size(66, 19);
            EntregacheckBox.TabIndex = 12;
            EntregacheckBox.Text = "Entrega";
            EntregacheckBox.UseVisualStyleBackColor = true;
            // 
            // EntregaGroupBox1
            // 
            EntregaGroupBox1.Controls.Add(ListadoChoferesEntregacomboBox5);
            EntregaGroupBox1.Controls.Add(ListadoChoferesEntregalabel6);
            //EntregaGroupBox1.Controls.Add(this.AgregarEntregabutton);
            EntregaGroupBox1.Controls.Add(listView3);
            EntregaGroupBox1.Controls.Add(comboBox4);
           // EntregaGroupBox1.Controls.Add(this.NumeroGuia);
            //EntregaGroupBox1.Controls.Add(this.DestinoEntregatextBox1);
            EntregaGroupBox1.Controls.Add(OrigenEntregatextBox2);
            EntregaGroupBox1.Controls.Add(label10);
            EntregaGroupBox1.Controls.Add(OrigenEntrega);
            EntregaGroupBox1.Location = new Point(42, 338);
            EntregaGroupBox1.Name = "EntregaGroupBox1";
            EntregaGroupBox1.Size = new Size(731, 206);
            EntregaGroupBox1.TabIndex = 12;
            EntregaGroupBox1.TabStop = false;
            EntregaGroupBox1.Text = "Entrega";
            // 
            // AgregarEntregabutton
            // 
           /* this.AgregarEntregabutton.Location = new Point(542, 132);
            this.AgregarEntregabutton.Name = "AgregarEntregabutton";
            this.AgregarEntregabutton.Size = new Size(75, 23);
            this.AgregarEntregabutton.TabIndex = 11;
            this.AgregarEntregabutton.Text = "Agregar";
            this.AgregarEntregabutton.UseVisualStyleBackColor = true;
            */// 
            // listView3
            // 
            //listView3.Columns.AddRange(new ColumnHeader[] { this.NumeroGuiaEntrega, this.OrigenEntrega1, DestinoEntrega1, ChoferesEntrega });
            listView3.GridLines = true;
            listView3.Location = new Point(42, 102);
            listView3.Name = "listView3";
            listView3.Size = new Size(406, 98);
            listView3.TabIndex = 10;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // NumeroGuiaEntrega
            // 
            /*this.NumeroGuiaEntrega.Text = "Numero de Guia";
            this.NumeroGuiaEntrega.Width = 100;
            // 
            // OrigenEntrega1
            // 
            this.OrigenEntrega1.Text = "Origen";
            this.OrigenEntrega1.TextAlign = HorizontalAlignment.Center;
            this.OrigenEntrega1.Width = 100;
            */// 
            // DestinoEntrega1
            // 
            DestinoEntrega1.Text = "Destino";
            DestinoEntrega1.TextAlign = HorizontalAlignment.Center;
            DestinoEntrega1.Width = 100;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(172, 63);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 23);
            comboBox4.TabIndex = 5;
            // 
            // NumeroGuia
            // 
            /*this.NumeroGuia.AutoSize = true;
            this.NumeroGuia.Location = new Point(42, 66);
            this.NumeroGuia.Name = "NumeroGuia";
            this.NumeroGuia.Size = new Size(98, 15);
            this.NumeroGuia.TabIndex = 4;
            this.NumeroGuia.Text = "Numero de guias";
            // 
            // DestinoEntregatextBox1
            // 
            this.DestinoEntregatextBox1.Location = new Point(492, 27);
            this.DestinoEntregatextBox1.Name = "DestinoEntregatextBox1";
            this.DestinoEntregatextBox1.Size = new Size(177, 23);
            this.DestinoEntregatextBox1.TabIndex = 3;
            */// 
            // OrigenEntregatextBox2
            // 
            OrigenEntregatextBox2.Location = new Point(172, 24);
            OrigenEntregatextBox2.Name = "OrigenEntregatextBox2";
            OrigenEntregatextBox2.Size = new Size(151, 23);
            OrigenEntregatextBox2.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(379, 27);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 1;
            label10.Text = "Destino";
            // 
            // OrigenEntrega
            // 
            OrigenEntrega.AutoSize = true;
            OrigenEntrega.Location = new Point(42, 27);
            OrigenEntrega.Name = "OrigenEntrega";
            OrigenEntrega.Size = new Size(49, 15);
            OrigenEntrega.TabIndex = 0;
            OrigenEntrega.Text = "Origene";
            // 
            // Confirmarbutton1
            // 
            Confirmarbutton1.Location = new Point(584, 791);
            Confirmarbutton1.Name = "Confirmarbutton1";
            Confirmarbutton1.Size = new Size(75, 23);
            Confirmarbutton1.TabIndex = 13;
            Confirmarbutton1.Text = "Confirmar";
            Confirmarbutton1.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton1
            // 
            Cancelarbutton1.Location = new Point(686, 791);
            Cancelarbutton1.Name = "Cancelarbutton1";
            Cancelarbutton1.Size = new Size(75, 23);
            Cancelarbutton1.TabIndex = 14;
            Cancelarbutton1.Text = "Cancelar";
            Cancelarbutton1.UseVisualStyleBackColor = true;
            // 
            // ListadoChoferesEntregacomboBox5
            // 
            ListadoChoferesEntregacomboBox5.FormattingEnabled = true;
            ListadoChoferesEntregacomboBox5.Location = new Point(492, 66);
            ListadoChoferesEntregacomboBox5.Name = "ListadoChoferesEntregacomboBox5";
            ListadoChoferesEntregacomboBox5.Size = new Size(171, 23);
            ListadoChoferesEntregacomboBox5.TabIndex = 14;
            // 
            // ListadoChoferesEntregalabel6
            // 
            ListadoChoferesEntregalabel6.AutoSize = true;
            ListadoChoferesEntregalabel6.Location = new Point(364, 69);
            ListadoChoferesEntregalabel6.Name = "ListadoChoferesEntregalabel6";
            ListadoChoferesEntregalabel6.Size = new Size(109, 15);
            ListadoChoferesEntregalabel6.TabIndex = 13;
            ListadoChoferesEntregalabel6.Text = "Listado de choferes";
            // 
            // ListadoChoferesRetirocomboBox6
            // 
            ListadoChoferesRetirocomboBox6.FormattingEnabled = true;
            ListadoChoferesRetirocomboBox6.Location = new Point(492, 66);
            ListadoChoferesRetirocomboBox6.Name = "ListadoChoferesRetirocomboBox6";
            ListadoChoferesRetirocomboBox6.Size = new Size(171, 23);
            ListadoChoferesRetirocomboBox6.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 69);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 15;
            label8.Text = "Listado de choferes";
            // 
            // ChoferesEntrega
            // 
            ChoferesEntrega.Text = "Choferes";
            ChoferesEntrega.TextAlign = HorizontalAlignment.Center;
            ChoferesEntrega.Width = 100;
            // 
            // ChoferesRetiro
            // 
            ChoferesRetiro.Text = "Choferes";
            ChoferesRetiro.TextAlign = HorizontalAlignment.Center;
            ChoferesRetiro.Width = 100;
            // 
            // ConfeccionarHojaDeRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 852);
            Controls.Add(Cancelarbutton1);
            Controls.Add(Confirmarbutton1);
            Controls.Add(EntregaGroupBox1);
            Controls.Add(EntregacheckBox);
            Controls.Add(TransportegroupBox1);
            Controls.Add(RetirogroupBox1);
            Controls.Add(TransportecheckBox1);
            Controls.Add(RetirocheckBox1);
            Controls.Add(label2);
            Name = "ConfeccionarHojaDeRuta";
            Text = "Confeccionar Hoja de Ruta";
            RetirogroupBox1.ResumeLayout(false);
            RetirogroupBox1.PerformLayout();
            TransportegroupBox1.ResumeLayout(false);
            TransportegroupBox1.PerformLayout();
            EntregaGroupBox1.ResumeLayout(false);
            EntregaGroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private CheckBox RetirocheckBox1;
        private CheckBox TransportecheckBox1;
        private GroupBox RetirogroupBox1;
        private TextBox RetiroOrigentextBox1;
        private Label label3;
        private Label label1;
        private GroupBox TransportegroupBox1;
        private Label label4;
        private Label Numerodeencomienda;
        private TextBox NumerodeencomeindatextBox1;
        private ComboBox ListadoChofereTransportecomboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox DestinoRetirotextBox2;
        private Label label7;
        private ListView listView1;
        private ColumnHeader NumerodeGuia;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private ColumnHeader Chofer;
        private ComboBox comboBox3;
        private ListView listView2;
        private ColumnHeader NumerodeGuiaRetiro;
        private ColumnHeader OrigenRetiro;
        private ColumnHeader DestinoRetiro;
        private Button Agregar;
        private Button button1;
        private CheckBox EntregacheckBox;
        private GroupBox EntregaGroupBox1;
        private Button button2;
        private ListView listView3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader DestinoEntrega1;
        private ComboBox comboBox4;
        private Label label9;
        private TextBox textBox1;
        private TextBox OrigenEntregatextBox2;
        private Label label10;
        private Label OrigenEntrega;
        private Button Confirmarbutton1;
        private Button Cancelarbutton1;
        private ComboBox ListadoChoferesRetirocomboBox6;
        private Label label8;
        private ComboBox ListadoChoferesEntregacomboBox5;
        private Label ListadoChoferesEntregalabel6;
        private ColumnHeader ChoferesRetiro;
        private ColumnHeader ChoferesEntrega;
    }
}