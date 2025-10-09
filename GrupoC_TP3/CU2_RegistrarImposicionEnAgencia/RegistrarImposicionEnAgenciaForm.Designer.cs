namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
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
            buttonNuevaSolicitudLimpiar = new Button();
            label15 = new Label();
            comboBoxTipoCaja = new ComboBox();
            groupBox2 = new GroupBox();
            textBoxDNIDestinatario = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            textBoxNombreDestinatario = new TextBox();
            textBoxApellidoDestinatario = new TextBox();
            textBoxDomicilioDestinatario = new TextBox();
            labelDomicilioDestino = new Label();
            groupBox1 = new GroupBox();
            buttonValidar = new Button();
            textBoxCUITCUIL = new TextBox();
            label4 = new Label();
            label17 = new Label();
            label18 = new Label();
            label16 = new Label();
            groupBox3 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            textBoxCantidadCajas = new TextBox();
            comboBoxMetodoEntrega = new ComboBox();
            label10 = new Label();
            label6 = new Label();
            textBoxCodPostDestino = new TextBox();
            label14 = new Label();
            buttonGenerarNumeroGuia = new Button();
            label22 = new Label();
            textBoxCodigoAgencia = new TextBox();
            groupBox4 = new GroupBox();
            labelCdDestino = new Label();
            cmbBoxProvDst = new ComboBox();
            label2 = new Label();
            cmbBoxLocalidadDst = new ComboBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNuevaSolicitudLimpiar
            // 
            buttonNuevaSolicitudLimpiar.Location = new Point(458, 839);
            buttonNuevaSolicitudLimpiar.Margin = new Padding(3, 4, 3, 4);
            buttonNuevaSolicitudLimpiar.Name = "buttonNuevaSolicitudLimpiar";
            buttonNuevaSolicitudLimpiar.Size = new Size(98, 31);
            buttonNuevaSolicitudLimpiar.TabIndex = 45;
            buttonNuevaSolicitudLimpiar.Text = "Aceptar";
            buttonNuevaSolicitudLimpiar.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(829, 659);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 43;
            // 
            // comboBoxTipoCaja
            // 
            comboBoxTipoCaja.FormattingEnabled = true;
            comboBoxTipoCaja.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            comboBoxTipoCaja.Location = new Point(123, 67);
            comboBoxTipoCaja.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipoCaja.Name = "comboBoxTipoCaja";
            comboBoxTipoCaja.Size = new Size(105, 28);
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
            groupBox2.Location = new Point(18, 636);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(439, 148);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Destinatario";
            // 
            // textBoxDNIDestinatario
            // 
            textBoxDNIDestinatario.Location = new Point(62, 99);
            textBoxDNIDestinatario.Margin = new Padding(3, 4, 3, 4);
            textBoxDNIDestinatario.Name = "textBoxDNIDestinatario";
            textBoxDNIDestinatario.Size = new Size(241, 27);
            textBoxDNIDestinatario.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 33);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 6;
            label8.Text = "Nombre Destinatario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 65);
            label7.Name = "label7";
            label7.Size = new Size(154, 20);
            label7.TabIndex = 7;
            label7.Text = "Apellido Destinatario:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 99);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 8;
            label9.Text = "DNI:";
            // 
            // textBoxNombreDestinatario
            // 
            textBoxNombreDestinatario.Location = new Point(159, 25);
            textBoxNombreDestinatario.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreDestinatario.Name = "textBoxNombreDestinatario";
            textBoxNombreDestinatario.Size = new Size(241, 27);
            textBoxNombreDestinatario.TabIndex = 21;
            // 
            // textBoxApellidoDestinatario
            // 
            textBoxApellidoDestinatario.Location = new Point(159, 60);
            textBoxApellidoDestinatario.Margin = new Padding(3, 4, 3, 4);
            textBoxApellidoDestinatario.Name = "textBoxApellidoDestinatario";
            textBoxApellidoDestinatario.Size = new Size(241, 27);
            textBoxApellidoDestinatario.TabIndex = 22;
            // 
            // textBoxDomicilioDestinatario
            // 
            textBoxDomicilioDestinatario.Location = new Point(145, 225);
            textBoxDomicilioDestinatario.Margin = new Padding(3, 4, 3, 4);
            textBoxDomicilioDestinatario.Name = "textBoxDomicilioDestinatario";
            textBoxDomicilioDestinatario.Size = new Size(281, 27);
            textBoxDomicilioDestinatario.TabIndex = 25;
            // 
            // labelDomicilioDestino
            // 
            labelDomicilioDestino.AutoSize = true;
            labelDomicilioDestino.Location = new Point(13, 231);
            labelDomicilioDestino.Name = "labelDomicilioDestino";
            labelDomicilioDestino.Size = new Size(77, 20);
            labelDomicilioDestino.TabIndex = 24;
            labelDomicilioDestino.Text = "Domicilio:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonValidar);
            groupBox1.Controls.Add(textBoxCUITCUIL);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(14, 87);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(441, 113);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Solicitante";
            // 
            // buttonValidar
            // 
            buttonValidar.Location = new Point(321, 75);
            buttonValidar.Margin = new Padding(3, 4, 3, 4);
            buttonValidar.Name = "buttonValidar";
            buttonValidar.Size = new Size(106, 31);
            buttonValidar.TabIndex = 54;
            buttonValidar.Text = "Validar";
            buttonValidar.UseVisualStyleBackColor = true;
            buttonValidar.Click += buttonValidar_Click;
            // 
            // textBoxCUITCUIL
            // 
            textBoxCUITCUIL.Location = new Point(110, 33);
            textBoxCUITCUIL.Margin = new Padding(3, 4, 3, 4);
            textBoxCUITCUIL.Name = "textBoxCUITCUIL";
            textBoxCUITCUIL.Size = new Size(317, 27);
            textBoxCUITCUIL.TabIndex = 20;
            textBoxCUITCUIL.TextChanged += textBoxCUITCUIL_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 37);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "CUIT/CUIL:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(130, 47);
            label17.Name = "label17";
            label17.Size = new Size(342, 20);
            label17.TabIndex = 48;
            label17.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(242, 20);
            label18.Name = "label18";
            label18.Size = new Size(84, 25);
            label18.TabIndex = 47;
            label18.Text = "TUTASA";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(600, 27);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 46;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBoxCantidadCajas);
            groupBox3.Controls.Add(comboBoxTipoCaja);
            groupBox3.Location = new Point(18, 501);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(439, 113);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Encomienda";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 36);
            label13.Name = "label13";
            label13.Size = new Size(111, 20);
            label13.TabIndex = 10;
            label13.Text = "Cantidad Cajas:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 75);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 11;
            label12.Text = "Tipo de Caja:";
            // 
            // textBoxCantidadCajas
            // 
            textBoxCantidadCajas.Location = new Point(123, 33);
            textBoxCantidadCajas.Margin = new Padding(3, 4, 3, 4);
            textBoxCantidadCajas.Name = "textBoxCantidadCajas";
            textBoxCantidadCajas.Size = new Size(105, 27);
            textBoxCantidadCajas.TabIndex = 24;
            // 
            // comboBoxMetodoEntrega
            // 
            comboBoxMetodoEntrega.FormattingEnabled = true;
            comboBoxMetodoEntrega.Items.AddRange(new object[] { "Entrega en Domicilio", "Retiro en Agencia", "Retiro en CD Destino" });
            comboBoxMetodoEntrega.Location = new Point(157, 104);
            comboBoxMetodoEntrega.Margin = new Padding(3, 4, 3, 4);
            comboBoxMetodoEntrega.Name = "comboBoxMetodoEntrega";
            comboBoxMetodoEntrega.Size = new Size(171, 28);
            comboBoxMetodoEntrega.TabIndex = 45;
            comboBoxMetodoEntrega.SelectedIndexChanged += comboBoxMetodoEntrega_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 109);
            label10.Name = "label10";
            label10.Size = new Size(141, 20);
            label10.TabIndex = 39;
            label10.Text = "Metodo de Entrega:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 144);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 37;
            label6.Text = "Codigo Postal:";
            // 
            // textBoxCodPostDestino
            // 
            textBoxCodPostDestino.Location = new Point(144, 140);
            textBoxCodPostDestino.Margin = new Padding(3, 4, 3, 4);
            textBoxCodPostDestino.Name = "textBoxCodPostDestino";
            textBoxCodPostDestino.Size = new Size(138, 27);
            textBoxCodPostDestino.TabIndex = 38;
            textBoxCodPostDestino.TextChanged += textBoxCodPostDestino_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 29);
            label14.Name = "label14";
            label14.Size = new Size(72, 20);
            label14.TabIndex = 13;
            label14.Text = "Provincia:";
            // 
            // buttonGenerarNumeroGuia
            // 
            buttonGenerarNumeroGuia.Location = new Point(343, 839);
            buttonGenerarNumeroGuia.Margin = new Padding(3, 4, 3, 4);
            buttonGenerarNumeroGuia.Name = "buttonGenerarNumeroGuia";
            buttonGenerarNumeroGuia.Size = new Size(109, 31);
            buttonGenerarNumeroGuia.TabIndex = 42;
            buttonGenerarNumeroGuia.Text = "Generar Guia";
            buttonGenerarNumeroGuia.UseVisualStyleBackColor = true;
            buttonGenerarNumeroGuia.Click += buttonGenerarNumeroGuia_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(8, 12);
            label22.Name = "label22";
            label22.Size = new Size(119, 20);
            label22.TabIndex = 52;
            label22.Text = "Codigo Agencia:";
            // 
            // textBoxCodigoAgencia
            // 
            textBoxCodigoAgencia.Location = new Point(123, 8);
            textBoxCodigoAgencia.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigoAgencia.Name = "textBoxCodigoAgencia";
            textBoxCodigoAgencia.ReadOnly = true;
            textBoxCodigoAgencia.Size = new Size(41, 27);
            textBoxCodigoAgencia.TabIndex = 53;
            textBoxCodigoAgencia.Text = "1234";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelCdDestino);
            groupBox4.Controls.Add(cmbBoxProvDst);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cmbBoxLocalidadDst);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(textBoxDomicilioDestinatario);
            groupBox4.Controls.Add(comboBoxMetodoEntrega);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(textBoxCodPostDestino);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(labelDomicilioDestino);
            groupBox4.Location = new Point(16, 208);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(439, 285);
            groupBox4.TabIndex = 55;
            groupBox4.TabStop = false;
            groupBox4.Text = "Informacion Destino";
            // 
            // labelCdDestino
            // 
            labelCdDestino.AutoSize = true;
            labelCdDestino.Location = new Point(145, 187);
            labelCdDestino.Name = "labelCdDestino";
            labelCdDestino.Size = new Size(0, 20);
            labelCdDestino.TabIndex = 52;
            // 
            // cmbBoxProvDst
            // 
            cmbBoxProvDst.FormattingEnabled = true;
            cmbBoxProvDst.Items.AddRange(new object[] { "Buenos Aires", "La Pampa" });
            cmbBoxProvDst.Location = new Point(145, 24);
            cmbBoxProvDst.Margin = new Padding(3, 4, 3, 4);
            cmbBoxProvDst.Name = "cmbBoxProvDst";
            cmbBoxProvDst.Size = new Size(138, 28);
            cmbBoxProvDst.TabIndex = 51;
            cmbBoxProvDst.SelectedIndexChanged += cmbBoxProvDst_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 187);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 49;
            label2.Text = "CD Destino:";
            // 
            // cmbBoxLocalidadDst
            // 
            cmbBoxLocalidadDst.FormattingEnabled = true;
            cmbBoxLocalidadDst.Items.AddRange(new object[] { "Gral. San Martin", "Villa 31" });
            cmbBoxLocalidadDst.Location = new Point(144, 60);
            cmbBoxLocalidadDst.Margin = new Padding(3, 4, 3, 4);
            cmbBoxLocalidadDst.Name = "cmbBoxLocalidadDst";
            cmbBoxLocalidadDst.Size = new Size(138, 28);
            cmbBoxLocalidadDst.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 69);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 46;
            label1.Text = "Localidad:";
            // 
            // RegistrarImposicionEnAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 885);
            Controls.Add(groupBox4);
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
            Controls.Add(buttonGenerarNumeroGuia);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrarImposicionEnAgenciaForm";
            Text = "Imposicion - Agencias";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonNuevaSolicitudLimpiar;
        private Label label15;
        private ComboBox comboBoxTipoCaja;
        private GroupBox groupBox2;
        private TextBox textBoxDomicilioDestinatario;
        private Label labelDomicilioDestino;
        private TextBox textBoxDNIDestinatario;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox textBoxNombreDestinatario;
        private TextBox textBoxApellidoDestinatario;
        private GroupBox groupBox1;
        private TextBox textBoxCUITCUIL;
        private Label label4;
        private Label label17;
        private Label label18;
        private Label label16;
        private GroupBox groupBox3;
        private ComboBox comboBoxMetodoEntrega;
        private Label label10;
        private Label label6;
        private TextBox textBoxCodPostDestino;
        private Label label13;
        private Label label12;
        private Label label14;
        private TextBox textBoxCantidadCajas;
        private Button buttonGenerarNumeroGuia;
        private Label label22;
        private TextBox textBoxCodigoAgencia;
        private Button buttonValidar;
        private GroupBox groupBox4;
        private Label label1;
        private ComboBox cmbBoxLocalidadDst;
        private Label label2;
        private ComboBox cmbBoxProvDst;
        private Label labelCdDestino;
    }
}