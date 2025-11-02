namespace GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio
{ 
    partial class RegistrarImposicionRetiroPorDomicilioForm
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
            cmbBoxLocalidadDestino = new ComboBox();
            cmbBoxProvDestino = new ComboBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            labelCdDestino = new Label();
            label10 = new Label();
            textBoxDomicilioDestinatario = new TextBox();
            comboBoxMetodoEntrega = new ComboBox();
            label14 = new Label();
            textBoxCPDestino = new TextBox();
            label6 = new Label();
            labelDomicilioDestino = new Label();
            label13 = new Label();
            label12 = new Label();
            textBoxCantidadCajas = new TextBox();
            buttonNuevaSolicitudLimpiar = new Button();
            label15 = new Label();
            label16 = new Label();
            comboBoxTipoCaja = new ComboBox();
            groupBox2 = new GroupBox();
            textBoxDNIDestinatario = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            textBoxNombreDestinatario = new TextBox();
            textBoxApellidoDestinatario = new TextBox();
            label17 = new Label();
            buttonGenerarNumeroGuia = new Button();
            groupBox1 = new GroupBox();
            ValidarCUIT = new Button();
            textBoxCUITCUIL = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label18 = new Label();
            groupBox5 = new GroupBox();
            labelCdOrigen = new Label();
            cmbBoxProvRetiro = new ComboBox();
            label3 = new Label();
            label20 = new Label();
            cmbBoxLocalidadRetiro = new ComboBox();
            label19 = new Label();
            textBoxCpRetiro = new TextBox();
            label5 = new Label();
            label11 = new Label();
            textBoxDomicilioRetiro = new TextBox();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 140);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 49;
            label2.Text = "CD Destino:";
            // 
            // cmbBoxLocalidadDestino
            // 
            cmbBoxLocalidadDestino.FormattingEnabled = true;
            cmbBoxLocalidadDestino.Location = new Point(137, 46);
            cmbBoxLocalidadDestino.Name = "cmbBoxLocalidadDestino";
            cmbBoxLocalidadDestino.Size = new Size(177, 23);
            cmbBoxLocalidadDestino.TabIndex = 48;
            // 
            // cmbBoxProvDestino
            // 
            cmbBoxProvDestino.FormattingEnabled = true;
            cmbBoxProvDestino.Location = new Point(137, 16);
            cmbBoxProvDestino.Name = "cmbBoxProvDestino";
            cmbBoxProvDestino.Size = new Size(177, 23);
            cmbBoxProvDestino.TabIndex = 47;
            cmbBoxProvDestino.SelectedIndexChanged += cmbBoxProvDst_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 52);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 46;
            label1.Text = "Localidad:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelCdDestino);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cmbBoxLocalidadDestino);
            groupBox4.Controls.Add(cmbBoxProvDestino);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(textBoxDomicilioDestinatario);
            groupBox4.Controls.Add(comboBoxMetodoEntrega);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(textBoxCPDestino);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(labelDomicilioDestino);
            groupBox4.Location = new Point(14, 152);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(343, 214);
            groupBox4.TabIndex = 68;
            groupBox4.TabStop = false;
            groupBox4.Text = "Informacion Destino";
            // 
            // labelCdDestino
            // 
            labelCdDestino.AutoSize = true;
            labelCdDestino.Location = new Point(126, 140);
            labelCdDestino.Name = "labelCdDestino";
            labelCdDestino.Size = new Size(0, 15);
            labelCdDestino.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 82);
            label10.Name = "label10";
            label10.Size = new Size(111, 15);
            label10.TabIndex = 39;
            label10.Text = "Metodo de Entrega:";
            // 
            // textBoxDomicilioDestinatario
            // 
            textBoxDomicilioDestinatario.Location = new Point(127, 169);
            textBoxDomicilioDestinatario.Name = "textBoxDomicilioDestinatario";
            textBoxDomicilioDestinatario.Size = new Size(188, 23);
            textBoxDomicilioDestinatario.TabIndex = 25;
            // 
            // comboBoxMetodoEntrega
            // 
            comboBoxMetodoEntrega.FormattingEnabled = true;
            comboBoxMetodoEntrega.Items.AddRange(new object[] { "Entrega en Domicilio", "Retiro en Agencia", "Retiro en CD Destino" });
            comboBoxMetodoEntrega.Location = new Point(137, 76);
            comboBoxMetodoEntrega.Name = "comboBoxMetodoEntrega";
            comboBoxMetodoEntrega.Size = new Size(177, 23);
            comboBoxMetodoEntrega.TabIndex = 45;
            comboBoxMetodoEntrega.SelectedIndexChanged += comboBoxMetodoEntrega_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 22);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 13;
            label14.Text = "Provincia:";
            // 
            // textBoxCPDestino
            // 
            textBoxCPDestino.Location = new Point(137, 106);
            textBoxCPDestino.Name = "textBoxCPDestino";
            textBoxCPDestino.Size = new Size(177, 23);
            textBoxCPDestino.TabIndex = 38;
            textBoxCPDestino.TextChanged += textBoxCodPostDestino_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 108);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 37;
            label6.Text = "Codigo Postal:";
            // 
            // labelDomicilioDestino
            // 
            labelDomicilioDestino.AutoSize = true;
            labelDomicilioDestino.Location = new Point(11, 173);
            labelDomicilioDestino.Name = "labelDomicilioDestino";
            labelDomicilioDestino.Size = new Size(61, 15);
            labelDomicilioDestino.TabIndex = 24;
            labelDomicilioDestino.Text = "Domicilio:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 27);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 10;
            label13.Text = "Cantidad Cajas:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 56);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 11;
            label12.Text = "Tipo de Caja:";
            // 
            // textBoxCantidadCajas
            // 
            textBoxCantidadCajas.Location = new Point(108, 25);
            textBoxCantidadCajas.Name = "textBoxCantidadCajas";
            textBoxCantidadCajas.Size = new Size(92, 23);
            textBoxCantidadCajas.TabIndex = 24;
            // 
            // buttonNuevaSolicitudLimpiar
            // 
            buttonNuevaSolicitudLimpiar.Location = new Point(640, 483);
            buttonNuevaSolicitudLimpiar.Name = "buttonNuevaSolicitudLimpiar";
            buttonNuevaSolicitudLimpiar.Size = new Size(86, 23);
            buttonNuevaSolicitudLimpiar.TabIndex = 59;
            buttonNuevaSolicitudLimpiar.Text = "Aceptar";
            buttonNuevaSolicitudLimpiar.UseVisualStyleBackColor = true;
            buttonNuevaSolicitudLimpiar.Click += buttonNuevaSolicitudLimpiar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(673, 469);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 57;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(525, 16);
            label16.Name = "label16";
            label16.Size = new Size(0, 15);
            label16.TabIndex = 60;
            // 
            // comboBoxTipoCaja
            // 
            comboBoxTipoCaja.FormattingEnabled = true;
            comboBoxTipoCaja.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            comboBoxTipoCaja.Location = new Point(108, 50);
            comboBoxTipoCaja.Name = "comboBoxTipoCaja";
            comboBoxTipoCaja.Size = new Size(92, 23);
            comboBoxTipoCaja.TabIndex = 34;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxDNIDestinatario);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxNombreDestinatario);
            groupBox2.Controls.Add(textBoxApellidoDestinatario);
            groupBox2.Location = new Point(378, 348);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 111);
            groupBox2.TabIndex = 64;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Destinatario";
            // 
            // textBoxDNIDestinatario
            // 
            textBoxDNIDestinatario.Location = new Point(144, 73);
            textBoxDNIDestinatario.Name = "textBoxDNIDestinatario";
            textBoxDNIDestinatario.Size = new Size(188, 23);
            textBoxDNIDestinatario.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 25);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 6;
            label8.Text = "Nombre Destinatario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 49);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 7;
            label7.Text = "Apellido Destinatario:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 74);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 8;
            label9.Text = "DNI:";
            // 
            // textBoxNombreDestinatario
            // 
            textBoxNombreDestinatario.Location = new Point(144, 20);
            textBoxNombreDestinatario.Name = "textBoxNombreDestinatario";
            textBoxNombreDestinatario.Size = new Size(188, 23);
            textBoxNombreDestinatario.TabIndex = 21;
            // 
            // textBoxApellidoDestinatario
            // 
            textBoxApellidoDestinatario.Location = new Point(144, 46);
            textBoxApellidoDestinatario.Name = "textBoxApellidoDestinatario";
            textBoxApellidoDestinatario.Size = new Size(188, 23);
            textBoxApellidoDestinatario.TabIndex = 22;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(293, 31);
            label17.Name = "label17";
            label17.Size = new Size(269, 15);
            label17.TabIndex = 62;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // buttonGenerarNumeroGuia
            // 
            buttonGenerarNumeroGuia.Location = new Point(501, 483);
            buttonGenerarNumeroGuia.Name = "buttonGenerarNumeroGuia";
            buttonGenerarNumeroGuia.Size = new Size(129, 23);
            buttonGenerarNumeroGuia.TabIndex = 56;
            buttonGenerarNumeroGuia.Text = "Generar Guia";
            buttonGenerarNumeroGuia.UseVisualStyleBackColor = true;
            buttonGenerarNumeroGuia.Click += buttonGenerarNumeroGuia_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ValidarCUIT);
            groupBox1.Controls.Add(textBoxCUITCUIL);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 85);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Solicitante";
            // 
            // ValidarCUIT
            // 
            ValidarCUIT.Location = new Point(223, 56);
            ValidarCUIT.Name = "ValidarCUIT";
            ValidarCUIT.Size = new Size(93, 23);
            ValidarCUIT.TabIndex = 54;
            ValidarCUIT.Text = "Validar";
            ValidarCUIT.UseVisualStyleBackColor = true;
            ValidarCUIT.Click += ValidarCUIT_Click;
            // 
            // textBoxCUITCUIL
            // 
            textBoxCUITCUIL.Location = new Point(96, 25);
            textBoxCUITCUIL.Name = "textBoxCUITCUIL";
            textBoxCUITCUIL.Size = new Size(220, 23);
            textBoxCUITCUIL.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 28);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "CUIT/CUIL:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBoxCantidadCajas);
            groupBox3.Controls.Add(comboBoxTipoCaja);
            groupBox3.Location = new Point(11, 374);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(346, 85);
            groupBox3.TabIndex = 65;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Encomienda";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(391, 11);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 61;
            label18.Text = "TUTASA";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(labelCdOrigen);
            groupBox5.Controls.Add(cmbBoxProvRetiro);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(cmbBoxLocalidadRetiro);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(textBoxCpRetiro);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(textBoxDomicilioRetiro);
            groupBox5.Location = new Point(378, 152);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(347, 181);
            groupBox5.TabIndex = 66;
            groupBox5.TabStop = false;
            groupBox5.Text = "Datos Retiro";
            // 
            // labelCdOrigen
            // 
            labelCdOrigen.AutoSize = true;
            labelCdOrigen.Location = new Point(123, 121);
            labelCdOrigen.Name = "labelCdOrigen";
            labelCdOrigen.Size = new Size(0, 15);
            labelCdOrigen.TabIndex = 60;
            // 
            // cmbBoxProvRetiro
            // 
            cmbBoxProvRetiro.FormattingEnabled = true;
            cmbBoxProvRetiro.Location = new Point(121, 32);
            cmbBoxProvRetiro.Name = "cmbBoxProvRetiro";
            cmbBoxProvRetiro.Size = new Size(121, 23);
            cmbBoxProvRetiro.TabIndex = 57;
            cmbBoxProvRetiro.SelectedIndexChanged += cmbBoxProvRetiro_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 121);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 59;
            label3.Text = "CD Origen:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(7, 154);
            label20.Name = "label20";
            label20.Size = new Size(111, 15);
            label20.TabIndex = 52;
            label20.Text = "Domicilio de Retiro:";
            // 
            // cmbBoxLocalidadRetiro
            // 
            cmbBoxLocalidadRetiro.FormattingEnabled = true;
            cmbBoxLocalidadRetiro.Location = new Point(121, 58);
            cmbBoxLocalidadRetiro.Name = "cmbBoxLocalidadRetiro";
            cmbBoxLocalidadRetiro.Size = new Size(121, 23);
            cmbBoxLocalidadRetiro.TabIndex = 58;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 92);
            label19.Name = "label19";
            label19.Size = new Size(84, 15);
            label19.TabIndex = 54;
            label19.Text = "Codigo Postal:";
            // 
            // textBoxCpRetiro
            // 
            textBoxCpRetiro.Location = new Point(123, 89);
            textBoxCpRetiro.Name = "textBoxCpRetiro";
            textBoxCpRetiro.Size = new Size(121, 23);
            textBoxCpRetiro.TabIndex = 55;
            textBoxCpRetiro.TextChanged += textBoxCpRetiro_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 65);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 56;
            label5.Text = "Localidad:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 35);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 51;
            label11.Text = "Provincia:";
            // 
            // textBoxDomicilioRetiro
            // 
            textBoxDomicilioRetiro.Location = new Point(144, 152);
            textBoxDomicilioRetiro.Name = "textBoxDomicilioRetiro";
            textBoxDomicilioRetiro.Size = new Size(188, 23);
            textBoxDomicilioRetiro.TabIndex = 53;
            // 
            // RegistrarImposicionRetiroPorDomicilioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 522);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(buttonNuevaSolicitudLimpiar);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(groupBox2);
            Controls.Add(label17);
            Controls.Add(buttonGenerarNumeroGuia);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(label18);
            Name = "RegistrarImposicionRetiroPorDomicilioForm";
            Text = "Sistema de Imposicion Telefonica";
            Load += RegistrarImposicionRetiroPorDomicilioForm_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cmbBoxLocalidadDestino;
        private ComboBox cmbBoxProvDestino;
        private Label label1;
        private GroupBox groupBox4;
        private Label label10;
        private TextBox textBoxDomicilioDestinatario;
        private ComboBox comboBoxMetodoEntrega;
        private Label label14;
        private TextBox textBoxCPDestino;
        private Label label6;
        private Label labelDomicilioDestino;
        private Label label13;
        private Label label12;
        private TextBox textBoxCantidadCajas;
        private Button buttonNuevaSolicitudLimpiar;
        private Label label15;
        private Label label16;
        private ComboBox comboBoxTipoCaja;
        private GroupBox groupBox2;
        private TextBox textBoxDNIDestinatario;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox textBoxNombreDestinatario;
        private TextBox textBoxApellidoDestinatario;
        private Label label17;
        private Button buttonGenerarNumeroGuia;
        private GroupBox groupBox1;
        private Button ValidarCUIT;
        private TextBox textBoxCUITCUIL;
        private Label label4;
        private GroupBox groupBox3;
        private Label label18;
        private GroupBox groupBox5;
        private ComboBox cmbBoxProvRetiro;
        private Label label3;
        private Label label20;
        private ComboBox cmbBoxLocalidadRetiro;
        private Label label19;
        private TextBox textBoxCpRetiro;
        private Label label5;
        private Label label11;
        private TextBox textBoxDomicilioRetiro;
        private Label labelCdDestino;
        private Label labelCdOrigen;
    }
}