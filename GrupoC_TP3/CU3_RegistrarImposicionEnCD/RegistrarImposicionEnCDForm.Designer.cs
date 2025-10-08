namespace GrupoC_TP3.CU3_RegistrarImposicionEnCD
{
    partial class RegistrarImposicionEnCDForm
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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            textBoxCDDestino = new TextBox();
            label10 = new Label();
            textBoxDomicilioDestinatario = new TextBox();
            comboBoxMetodoEntrega = new ComboBox();
            label14 = new Label();
            textBoxCodPostDestino = new TextBox();
            label6 = new Label();
            label21 = new Label();
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
            textBoxNumeroDeGuia = new TextBox();
            buttonGenerarNumeroGuia = new Button();
            groupBox1 = new GroupBox();
            buttonValidarCuil = new Button();
            textBoxCUITCUIL = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label18 = new Label();
            textBoxCodigoAgencia = new TextBox();
            label22 = new Label();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(126, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 48;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 47;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
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
            groupBox4.Controls.Add(textBoxCDDestino);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(textBoxDomicilioDestinatario);
            groupBox4.Controls.Add(comboBoxMetodoEntrega);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(textBoxCodPostDestino);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label21);
            groupBox4.Location = new Point(12, 156);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(384, 214);
            groupBox4.TabIndex = 68;
            groupBox4.TabStop = false;
            groupBox4.Text = "Informacion Destino";
            // 
            // textBoxCDDestino
            // 
            textBoxCDDestino.Location = new Point(127, 136);
            textBoxCDDestino.Name = "textBoxCDDestino";
            textBoxCDDestino.Size = new Size(246, 23);
            textBoxCDDestino.TabIndex = 50;
            textBoxCDDestino.Leave += textBoxCDDestino_Leave;
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
            textBoxDomicilioDestinatario.Size = new Size(246, 23);
            textBoxDomicilioDestinatario.TabIndex = 25;
            textBoxDomicilioDestinatario.Leave += textBoxDomicilioDestinatario_Leave;
            // 
            // comboBoxMetodoEntrega
            // 
            comboBoxMetodoEntrega.FormattingEnabled = true;
            comboBoxMetodoEntrega.Items.AddRange(new object[] { "Entrega en Domicilio", "Retiro en Agencia", "Retiro en CD Destino" });
            comboBoxMetodoEntrega.Location = new Point(126, 74);
            comboBoxMetodoEntrega.Name = "comboBoxMetodoEntrega";
            comboBoxMetodoEntrega.Size = new Size(150, 23);
            comboBoxMetodoEntrega.TabIndex = 45;
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
            // textBoxCodPostDestino
            // 
            textBoxCodPostDestino.Location = new Point(126, 105);
            textBoxCodPostDestino.Name = "textBoxCodPostDestino";
            textBoxCodPostDestino.Size = new Size(121, 23);
            textBoxCodPostDestino.TabIndex = 38;
            textBoxCodPostDestino.Leave += textBoxCodPostDestino_Leave_1;
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
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(11, 173);
            label21.Name = "label21";
            label21.Size = new Size(61, 15);
            label21.TabIndex = 24;
            label21.Text = "Domicilio:";
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
            label12.Size = new Size(76, 15);
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
            buttonNuevaSolicitudLimpiar.Location = new Point(399, 629);
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
            label15.Location = new Point(723, 494);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 57;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(523, 20);
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
            groupBox2.Location = new Point(14, 477);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 111);
            groupBox2.TabIndex = 64;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Destinatario";
            // 
            // textBoxDNIDestinatario
            // 
            textBoxDNIDestinatario.Location = new Point(139, 74);
            textBoxDNIDestinatario.Name = "textBoxDNIDestinatario";
            textBoxDNIDestinatario.Size = new Size(211, 23);
            textBoxDNIDestinatario.TabIndex = 23;
            textBoxDNIDestinatario.Leave += textBoxDNIDestinatario_Leave;
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
            textBoxNombreDestinatario.Leave += textBoxNombreDestinatario_Leave;
            // 
            // textBoxApellidoDestinatario
            // 
            textBoxApellidoDestinatario.Location = new Point(139, 45);
            textBoxApellidoDestinatario.Name = "textBoxApellidoDestinatario";
            textBoxApellidoDestinatario.Size = new Size(211, 23);
            textBoxApellidoDestinatario.TabIndex = 22;
            textBoxApellidoDestinatario.Leave += textBoxApellidoDestinatario_Leave;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(112, 35);
            label17.Name = "label17";
            label17.Size = new Size(269, 15);
            label17.TabIndex = 62;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // textBoxNumeroDeGuia
            // 
            textBoxNumeroDeGuia.Location = new Point(194, 629);
            textBoxNumeroDeGuia.Name = "textBoxNumeroDeGuia";
            textBoxNumeroDeGuia.ReadOnly = true;
            textBoxNumeroDeGuia.Size = new Size(170, 23);
            textBoxNumeroDeGuia.TabIndex = 58;
            // 
            // buttonGenerarNumeroGuia
            // 
            buttonGenerarNumeroGuia.Location = new Point(14, 629);
            buttonGenerarNumeroGuia.Name = "buttonGenerarNumeroGuia";
            buttonGenerarNumeroGuia.Size = new Size(174, 23);
            buttonGenerarNumeroGuia.TabIndex = 56;
            buttonGenerarNumeroGuia.Text = "Generar Numero de Guia";
            buttonGenerarNumeroGuia.UseVisualStyleBackColor = true;
            buttonGenerarNumeroGuia.Click += buttonGenerarNumeroGuia_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonValidarCuil);
            groupBox1.Controls.Add(textBoxCUITCUIL);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(10, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 85);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Solicitante";
            // 
            // buttonValidarCuil
            // 
            buttonValidarCuil.Location = new Point(281, 56);
            buttonValidarCuil.Name = "buttonValidarCuil";
            buttonValidarCuil.Size = new Size(93, 23);
            buttonValidarCuil.TabIndex = 54;
            buttonValidarCuil.Text = "Validar";
            buttonValidarCuil.UseVisualStyleBackColor = true;
            buttonValidarCuil.Click += buttonValidarCuil_Click_1;
            // 
            // textBoxCUITCUIL
            // 
            textBoxCUITCUIL.Location = new Point(96, 25);
            textBoxCUITCUIL.Name = "textBoxCUITCUIL";
            textBoxCUITCUIL.Size = new Size(278, 23);
            textBoxCUITCUIL.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 28);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "CUIT/CUIL:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBoxCantidadCajas);
            groupBox3.Controls.Add(comboBoxTipoCaja);
            groupBox3.Location = new Point(14, 376);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 85);
            groupBox3.TabIndex = 65;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Encomienda";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(210, 15);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 61;
            label18.Text = "TUTASA";
            // 
            // textBoxCodigoAgencia
            // 
            textBoxCodigoAgencia.Location = new Point(77, 5);
            textBoxCodigoAgencia.Name = "textBoxCodigoAgencia";
            textBoxCodigoAgencia.ReadOnly = true;
            textBoxCodigoAgencia.Size = new Size(36, 23);
            textBoxCodigoAgencia.TabIndex = 70;
            textBoxCodigoAgencia.Text = "1234";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(10, 9);
            label22.Name = "label22";
            label22.Size = new Size(68, 15);
            label22.TabIndex = 69;
            label22.Text = "Codigo CD:";
            // 
            // RegistrarImposicionEnCDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 665);
            Controls.Add(textBoxCodigoAgencia);
            Controls.Add(label22);
            Controls.Add(groupBox4);
            Controls.Add(buttonNuevaSolicitudLimpiar);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(groupBox2);
            Controls.Add(label17);
            Controls.Add(textBoxNumeroDeGuia);
            Controls.Add(buttonGenerarNumeroGuia);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(label18);
            Name = "RegistrarImposicionEnCDForm";
            Text = "Imposicion - Centro Distribucion";
            Load += RegistrarImposicionEnCDForm_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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

        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox4;
        private TextBox textBoxCDDestino;
        private Label label10;
        private TextBox textBoxDomicilioDestinatario;
        private ComboBox comboBoxMetodoEntrega;
        private Label label14;
        private TextBox textBoxCodPostDestino;
        private Label label6;
        private Label label21;
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
        private TextBox textBoxNumeroDeGuia;
        private Button buttonGenerarNumeroGuia;
        private GroupBox groupBox1;
        private Button buttonValidarCuil;
        private TextBox textBoxCUITCUIL;
        private Label label4;
        private GroupBox groupBox3;
        private Label label18;
        private TextBox textBoxCodigoAgencia;
        private Label label22;
    }
}