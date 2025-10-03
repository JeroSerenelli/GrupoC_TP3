namespace GrupoC_TP3.ConsultaEstadoGuiaEnCD
{
    partial class ConsultaEstadoGuiaEnCDForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxNumeroGuiaConsultaEnCD = new TextBox();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            listView1 = new ListView();
            NumeroGuia = new ColumnHeader();
            Origen = new ColumnHeader();
            Destino = new ColumnHeader();
            Destinatario = new ColumnHeader();
            EstadoEncomienda = new ColumnHeader();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 7);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero de Guia:";
            // 
            // textBoxNumeroGuiaConsultaEnCD
            // 
            textBoxNumeroGuiaConsultaEnCD.Location = new Point(115, 72);
            textBoxNumeroGuiaConsultaEnCD.Name = "textBoxNumeroGuiaConsultaEnCD";
            textBoxNumeroGuiaConsultaEnCD.Size = new Size(248, 23);
            textBoxNumeroGuiaConsultaEnCD.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(19, 118);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(123, 118);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(75, 23);
            buttonLimpiar.TabIndex = 4;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroGuia, Origen, Destino, Destinatario, EstadoEncomienda });
            listView1.Location = new Point(12, 160);
            listView1.Name = "listView1";
            listView1.Size = new Size(643, 228);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Numero De Guia";
            NumeroGuia.Width = 120;
            // 
            // Origen
            // 
            Origen.Text = "Origen";
            Origen.Width = 120;
            // 
            // Destino
            // 
            Destino.Text = "Destino";
            Destino.Width = 120;
            // 
            // Destinatario
            // 
            Destinatario.DisplayIndex = 4;
            Destinatario.Text = "Destinatario";
            Destinatario.Width = 120;
            // 
            // EstadoEncomienda
            // 
            EstadoEncomienda.DisplayIndex = 3;
            EstadoEncomienda.Text = "Estado de Encomienda";
            EstadoEncomienda.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 27);
            label3.Name = "label3";
            label3.Size = new Size(269, 15);
            label3.TabIndex = 6;
            label3.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            label3.Click += label3_Click;
            // 
            // ConsultaEstadoGuiaEnCDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 432);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxNumeroGuiaConsultaEnCD);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaEstadoGuiaEnCDForm";
            Text = "Consulta de Estado de Guia";
            Load += ConsultaEstadoGuiaEnCDForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNumeroGuiaConsultaEnCD;
        private Button buttonBuscar;
        private Button buttonLimpiar;
        private ListView listView1;
        private ColumnHeader NumeroGuia;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private ColumnHeader Destinatario;
        private ColumnHeader EstadoEncomienda;
        private Label label3;
    }
}