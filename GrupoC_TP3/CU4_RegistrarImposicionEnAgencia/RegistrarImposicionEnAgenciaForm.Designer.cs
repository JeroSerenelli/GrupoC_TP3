namespace GrupoC_TP3.RegistrarImposicionEnAgencia
{
    partial class RegistrarImposicionEnAgenciaForm
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
            label5 = new Label();
            buttonNuevaSolicitudLimpiar = new Button();
            label15 = new Label();
            comboBoxTipoCaja = new ComboBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label21 = new Label();
            textBoxDNIDestinatario = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            textBoxNombreDestinatario = new TextBox();
            textBoxApellidoDestinatario = new TextBox();
            groupBox1 = new GroupBox();
            textBoxCUITCUIL = new TextBox();
            labelNombreSolicitante = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNombreSolicitante = new TextBox();
            textBoxApellidoSolicitante = new TextBox();
            textBoxRazonSocial = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label16 = new Label();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            comboBoxCentroDistDestino = new ComboBox();
            label20 = new Label();
            comboBoxCentroDistOrigen = new ComboBox();
            label19 = new Label();
            label10 = new Label();
            label6 = new Label();
            textBoxCodPostDestino = new TextBox();
            textBoxCodPostOrigen = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label14 = new Label();
            textBoxCantidadCajas = new TextBox();
            textBoxOrigenEncomienda = new TextBox();
            textBoxDestinoEncomienda = new TextBox();
            textBoxNumeroDeGuia = new TextBox();
            buttonGenerarNumeroGuia = new Button();
            checkBoxEntregaEnDomicilio = new CheckBox();
            label22 = new Label();
            textBoxCodigoAgencia = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 121);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 35;
            label5.Text = "Codigo Postal Origen:";
            // 
            // buttonNuevaSolicitudLimpiar
            // 
            buttonNuevaSolicitudLimpiar.Location = new Point(14, 412);
            buttonNuevaSolicitudLimpiar.Name = "buttonNuevaSolicitudLimpiar";
            buttonNuevaSolicitudLimpiar.Size = new Size(174, 23);
            buttonNuevaSolicitudLimpiar.TabIndex = 45;
            buttonNuevaSolicitudLimpiar.Text = "Nueva Solicitud";
            buttonNuevaSolicitudLimpiar.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(52, 420);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 43;
            // 
            // comboBoxTipoCaja
            // 
            comboBoxTipoCaja.FormattingEnabled = true;
            comboBoxTipoCaja.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            comboBoxTipoCaja.Location = new Point(102, 57);
            comboBoxTipoCaja.Name = "comboBoxTipoCaja";
            comboBoxTipoCaja.Size = new Size(92, 23);
            comboBoxTipoCaja.TabIndex = 34;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(textBoxDNIDestinatario);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxNombreDestinatario);
            groupBox2.Controls.Add(textBoxApellidoDestinatario);
            groupBox2.Location = new Point(14, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 140);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Destinatario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 25;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 103);
            label21.Name = "label21";
            label21.Size = new Size(127, 15);
            label21.TabIndex = 24;
            label21.Text = "Domicilio Destinatario:";
            // 
            // textBoxDNIDestinatario
            // 
            textBoxDNIDestinatario.Location = new Point(38, 71);
            textBoxDNIDestinatario.Name = "textBoxDNIDestinatario";
            textBoxDNIDestinatario.Size = new Size(211, 23);
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
            textBoxNombreDestinatario.Location = new Point(139, 19);
            textBoxNombreDestinatario.Name = "textBoxNombreDestinatario";
            textBoxNombreDestinatario.Size = new Size(211, 23);
            textBoxNombreDestinatario.TabIndex = 21;
            // 
            // textBoxApellidoDestinatario
            // 
            textBoxApellidoDestinatario.Location = new Point(139, 45);
            textBoxApellidoDestinatario.Name = "textBoxApellidoDestinatario";
            textBoxApellidoDestinatario.Size = new Size(211, 23);
            textBoxApellidoDestinatario.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCUITCUIL);
            groupBox1.Controls.Add(labelNombreSolicitante);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxNombreSolicitante);
            groupBox1.Controls.Add(textBoxApellidoSolicitante);
            groupBox1.Controls.Add(textBoxRazonSocial);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 148);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Solicitante";
            // 
            // textBoxCUITCUIL
            // 
            textBoxCUITCUIL.Location = new Point(93, 104);
            textBoxCUITCUIL.Name = "textBoxCUITCUIL";
            textBoxCUITCUIL.Size = new Size(256, 23);
            textBoxCUITCUIL.TabIndex = 20;
            // 
            // labelNombreSolicitante
            // 
            labelNombreSolicitante.AutoSize = true;
            labelNombreSolicitante.Location = new Point(7, 30);
            labelNombreSolicitante.Name = "labelNombreSolicitante";
            labelNombreSolicitante.Size = new Size(112, 15);
            labelNombreSolicitante.TabIndex = 0;
            labelNombreSolicitante.Text = "Nombre Solicitante:";
            labelNombreSolicitante.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido Solicitante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 84);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Razon Social:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 108);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "CUIT/CUIL:";
            // 
            // textBoxNombreSolicitante
            // 
            textBoxNombreSolicitante.Location = new Point(122, 28);
            textBoxNombreSolicitante.Name = "textBoxNombreSolicitante";
            textBoxNombreSolicitante.Size = new Size(227, 23);
            textBoxNombreSolicitante.TabIndex = 17;
            // 
            // textBoxApellidoSolicitante
            // 
            textBoxApellidoSolicitante.Location = new Point(122, 54);
            textBoxApellidoSolicitante.Name = "textBoxApellidoSolicitante";
            textBoxApellidoSolicitante.Size = new Size(227, 23);
            textBoxApellidoSolicitante.TabIndex = 18;
            // 
            // textBoxRazonSocial
            // 
            textBoxRazonSocial.Location = new Point(93, 78);
            textBoxRazonSocial.Name = "textBoxRazonSocial";
            textBoxRazonSocial.Size = new Size(256, 23);
            textBoxRazonSocial.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(271, 35);
            label17.Name = "label17";
            label17.Size = new Size(269, 15);
            label17.TabIndex = 48;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(353, 15);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 47;
            label18.Text = "TUTASA";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(525, 20);
            label16.Name = "label16";
            label16.Size = new Size(0, 15);
            label16.TabIndex = 46;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(comboBoxCentroDistDestino);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(comboBoxCentroDistOrigen);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxCodPostDestino);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBoxCodPostOrigen);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBoxCantidadCajas);
            groupBox3.Controls.Add(textBoxOrigenEncomienda);
            groupBox3.Controls.Add(comboBoxTipoCaja);
            groupBox3.Controls.Add(textBoxDestinoEncomienda);
            groupBox3.Location = new Point(392, 65);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(396, 294);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Encomienda";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Entrega en Domicilio", "Retiro en Agencia", "Retiro en CD Destino" });
            comboBox1.Location = new Point(120, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 45;
            // 
            // comboBoxCentroDistDestino
            // 
            comboBoxCentroDistDestino.FormattingEnabled = true;
            comboBoxCentroDistDestino.Items.AddRange(new object[] { "Capital-GBA", "Centro (Cordoba)", "Norte (Tucuman)", "Este (Corrientes)", "Cordillera (Neuquen)", "Sur (Viedma)" });
            comboBoxCentroDistDestino.Location = new Point(164, 230);
            comboBoxCentroDistDestino.Name = "comboBoxCentroDistDestino";
            comboBoxCentroDistDestino.Size = new Size(121, 23);
            comboBoxCentroDistDestino.TabIndex = 44;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 233);
            label20.Name = "label20";
            label20.Size = new Size(156, 15);
            label20.TabIndex = 43;
            label20.Text = "Centro Distribucion Destino:";
            // 
            // comboBoxCentroDistOrigen
            // 
            comboBoxCentroDistOrigen.FormattingEnabled = true;
            comboBoxCentroDistOrigen.Items.AddRange(new object[] { "Capital-GBA", "Centro (Cordoba)", "Norte (Tucuman)", "Este (Corrientes)", "Cordillera (Neuquen)", "Sur (Viedma)" });
            comboBoxCentroDistOrigen.Location = new Point(164, 147);
            comboBoxCentroDistOrigen.Name = "comboBoxCentroDistOrigen";
            comboBoxCentroDistOrigen.Size = new Size(121, 23);
            comboBoxCentroDistOrigen.TabIndex = 42;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 151);
            label19.Name = "label19";
            label19.Size = new Size(152, 15);
            label19.TabIndex = 41;
            label19.Text = "Centro Distribucion Origen:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 264);
            label10.Name = "label10";
            label10.Size = new Size(111, 15);
            label10.TabIndex = 39;
            label10.Text = "Metodo de Entrega:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 207);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 37;
            label6.Text = "Codigo Postal Destino:";
            // 
            // textBoxCodPostDestino
            // 
            textBoxCodPostDestino.Location = new Point(139, 203);
            textBoxCodPostDestino.Name = "textBoxCodPostDestino";
            textBoxCodPostDestino.Size = new Size(73, 23);
            textBoxCodPostDestino.TabIndex = 38;
            // 
            // textBoxCodPostOrigen
            // 
            textBoxCodPostOrigen.Location = new Point(127, 118);
            textBoxCodPostOrigen.Name = "textBoxCodPostOrigen";
            textBoxCodPostOrigen.Size = new Size(74, 23);
            textBoxCodPostOrigen.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 30);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 10;
            label13.Text = "Cantidad Cajas:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 59);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 11;
            label12.Text = "Tipo de Caja:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 89);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 12;
            label11.Text = "Origen Caja:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 176);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 13;
            label14.Text = "Destino Caja:";
            // 
            // textBoxCantidadCajas
            // 
            textBoxCantidadCajas.Location = new Point(101, 29);
            textBoxCantidadCajas.Name = "textBoxCantidadCajas";
            textBoxCantidadCajas.Size = new Size(92, 23);
            textBoxCantidadCajas.TabIndex = 24;
            // 
            // textBoxOrigenEncomienda
            // 
            textBoxOrigenEncomienda.Location = new Point(84, 83);
            textBoxOrigenEncomienda.Name = "textBoxOrigenEncomienda";
            textBoxOrigenEncomienda.Size = new Size(297, 23);
            textBoxOrigenEncomienda.TabIndex = 25;
            // 
            // textBoxDestinoEncomienda
            // 
            textBoxDestinoEncomienda.Location = new Point(84, 176);
            textBoxDestinoEncomienda.Name = "textBoxDestinoEncomienda";
            textBoxDestinoEncomienda.Size = new Size(297, 23);
            textBoxDestinoEncomienda.TabIndex = 26;
            // 
            // textBoxNumeroDeGuia
            // 
            textBoxNumeroDeGuia.Location = new Point(194, 366);
            textBoxNumeroDeGuia.Name = "textBoxNumeroDeGuia";
            textBoxNumeroDeGuia.ReadOnly = true;
            textBoxNumeroDeGuia.Size = new Size(170, 23);
            textBoxNumeroDeGuia.TabIndex = 44;
            // 
            // buttonGenerarNumeroGuia
            // 
            buttonGenerarNumeroGuia.Location = new Point(14, 366);
            buttonGenerarNumeroGuia.Name = "buttonGenerarNumeroGuia";
            buttonGenerarNumeroGuia.Size = new Size(174, 23);
            buttonGenerarNumeroGuia.TabIndex = 42;
            buttonGenerarNumeroGuia.Text = "Generar Numero de Guia";
            buttonGenerarNumeroGuia.UseVisualStyleBackColor = true;
            buttonGenerarNumeroGuia.Click += buttonGenerarNumeroGuia_Click;
            // 
            // checkBoxEntregaEnDomicilio
            // 
            checkBoxEntregaEnDomicilio.AutoSize = true;
            checkBoxEntregaEnDomicilio.Location = new Point(644, 67);
            checkBoxEntregaEnDomicilio.Name = "checkBoxEntregaEnDomicilio";
            checkBoxEntregaEnDomicilio.RightToLeft = RightToLeft.Yes;
            checkBoxEntregaEnDomicilio.Size = new Size(136, 19);
            checkBoxEntregaEnDomicilio.TabIndex = 41;
            checkBoxEntregaEnDomicilio.Text = "Entrega en Domicilio";
            checkBoxEntregaEnDomicilio.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(14, 9);
            label22.Name = "label22";
            label22.Size = new Size(95, 15);
            label22.TabIndex = 52;
            label22.Text = "Codigo Agencia:";
            // 
            // textBoxCodigoAgencia
            // 
            textBoxCodigoAgencia.Location = new Point(112, 4);
            textBoxCodigoAgencia.Name = "textBoxCodigoAgencia";
            textBoxCodigoAgencia.ReadOnly = true;
            textBoxCodigoAgencia.Size = new Size(100, 23);
            textBoxCodigoAgencia.TabIndex = 53;
            textBoxCodigoAgencia.Text = "1234";
            // 
            // RegistrarImposicionEnAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCodigoAgencia);
            Controls.Add(label22);
            Controls.Add(buttonNuevaSolicitudLimpiar);
            Controls.Add(label15);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(groupBox3);
            Controls.Add(textBoxNumeroDeGuia);
            Controls.Add(buttonGenerarNumeroGuia);
            Controls.Add(checkBoxEntregaEnDomicilio);
            Name = "RegistrarImposicionEnAgenciaForm";
            Text = "Imposicion - Agencias TUTASA";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button buttonNuevaSolicitudLimpiar;
        private Label label15;
        private ComboBox comboBoxTipoCaja;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label21;
        private TextBox textBoxDNIDestinatario;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox textBoxNombreDestinatario;
        private TextBox textBoxApellidoDestinatario;
        private GroupBox groupBox1;
        private TextBox textBoxCUITCUIL;
        private Label labelNombreSolicitante;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNombreSolicitante;
        private TextBox textBoxApellidoSolicitante;
        private TextBox textBoxRazonSocial;
        private Label label17;
        private Label label18;
        private Label label16;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private ComboBox comboBoxCentroDistDestino;
        private Label label20;
        private ComboBox comboBoxCentroDistOrigen;
        private Label label19;
        private Label label10;
        private Label label6;
        private TextBox textBoxCodPostDestino;
        private TextBox textBoxCodPostOrigen;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private TextBox textBoxCantidadCajas;
        private TextBox textBoxOrigenEncomienda;
        private TextBox textBoxDestinoEncomienda;
        private TextBox textBoxNumeroDeGuia;
        private Button buttonGenerarNumeroGuia;
        private CheckBox checkBoxEntregaEnDomicilio;
        private Label label22;
        private TextBox textBoxCodigoAgencia;
    }
}