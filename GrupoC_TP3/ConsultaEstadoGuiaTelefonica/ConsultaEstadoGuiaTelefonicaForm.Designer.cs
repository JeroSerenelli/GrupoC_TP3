namespace GrupoC_TP3.ConsultaEstadoGuiaTelefonica
{
    partial class ConsultaEstadoGuiaTelefonicaForm
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
            listView1 = new ListView();
            NumeroGuia = new ColumnHeader();
            OrigenCaja = new ColumnHeader();
            DestinoCaja = new ColumnHeader();
            NombreDestinatario = new ColumnHeader();
            ApellidoDestinatario = new ColumnHeader();
            EstadoEncomienda = new ColumnHeader();
            label1 = new Label();
            textBoxNumeroGuiaConsultaEnCD = new TextBox();
            label2 = new Label();
            buttonLimpiar = new Button();
            buttonBuscar = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(6, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 262);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados de Consulta";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroGuia, OrigenCaja, DestinoCaja, NombreDestinatario, ApellidoDestinatario, EstadoEncomienda });
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(777, 228);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "N° de Guia";
            NumeroGuia.Width = 100;
            // 
            // OrigenCaja
            // 
            OrigenCaja.Text = "Origen Caja";
            OrigenCaja.Width = 120;
            // 
            // DestinoCaja
            // 
            DestinoCaja.Text = "Destino Caja";
            DestinoCaja.Width = 120;
            // 
            // NombreDestinatario
            // 
            NombreDestinatario.Text = "Nombre Destinatario";
            NombreDestinatario.Width = 140;
            // 
            // ApellidoDestinatario
            // 
            ApellidoDestinatario.Text = "Apellido Destinatario";
            ApellidoDestinatario.Width = 140;
            // 
            // EstadoEncomienda
            // 
            EstadoEncomienda.Text = "Estado de Encomienda";
            EstadoEncomienda.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 9;
            label1.Text = "TUTASA";
            // 
            // textBoxNumeroGuiaConsultaEnCD
            // 
            textBoxNumeroGuiaConsultaEnCD.Location = new Point(112, 22);
            textBoxNumeroGuiaConsultaEnCD.Name = "textBoxNumeroGuiaConsultaEnCD";
            textBoxNumeroGuiaConsultaEnCD.Size = new Size(248, 23);
            textBoxNumeroGuiaConsultaEnCD.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 25);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero de Guia:";
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(152, 129);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(133, 23);
            buttonLimpiar.TabIndex = 11;
            buttonLimpiar.Text = "Nueva Busqueda";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(12, 129);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(134, 23);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxNumeroGuiaConsultaEnCD);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 59);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parametros de Consulta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 40);
            label3.Name = "label3";
            label3.Size = new Size(269, 15);
            label3.TabIndex = 12;
            label3.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // ConsultaEstadoGuiaTelefonicaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Name = "ConsultaEstadoGuiaTelefonicaForm";
            Text = "Consulta de Estado de Guia";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader NumeroGuia;
        private ColumnHeader OrigenCaja;
        private ColumnHeader DestinoCaja;
        private ColumnHeader NombreDestinatario;
        private ColumnHeader ApellidoDestinatario;
        private ColumnHeader EstadoEncomienda;
        private Label label1;
        private TextBox textBoxNumeroGuiaConsultaEnCD;
        private Label label2;
        private Button buttonLimpiar;
        private Button buttonBuscar;
        private GroupBox groupBox2;
        private Label label3;
    }
}