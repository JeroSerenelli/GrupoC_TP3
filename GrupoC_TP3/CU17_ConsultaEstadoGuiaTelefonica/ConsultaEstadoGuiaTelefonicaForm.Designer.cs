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
            label1 = new Label();
            textBoxNumeroGuiaConsultaEnCD = new TextBox();
            label2 = new Label();
            buttonLimpiar = new Button();
            buttonBuscar = new Button();
            listView1 = new ListView();
            NumeroGuia = new ColumnHeader();
            EstadoEncomienda = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            button1 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 10;
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
            buttonLimpiar.Location = new Point(156, 118);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(133, 23);
            buttonLimpiar.TabIndex = 12;
            buttonLimpiar.Text = "Nueva Busqueda";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(16, 118);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(134, 23);
            buttonBuscar.TabIndex = 11;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroGuia, EstadoEncomienda, columnHeader1 });
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(419, 131);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "N° de Guia";
            NumeroGuia.Width = 100;
            // 
            // EstadoEncomienda
            // 
            EstadoEncomienda.Text = "Estado de Encomienda";
            EstadoEncomienda.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ultima Actualizacion";
            columnHeader1.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxNumeroGuiaConsultaEnCD);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(16, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 59);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parametros de Consulta";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(10, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 182);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados de Consulta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 29);
            label3.Name = "label3";
            label3.Size = new Size(269, 15);
            label3.TabIndex = 13;
            label3.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // button1
            // 
            button1.Location = new Point(363, 376);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // ConsultaEstadoGuiaTelefonicaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 410);
            Controls.Add(label1);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Name = "ConsultaEstadoGuiaTelefonicaForm";
            Text = "Consulta de Estado de Guia";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumeroGuiaConsultaEnCD;
        private Label label2;
        private Button buttonLimpiar;
        private Button buttonBuscar;
        private ListView listView1;
        private ColumnHeader NumeroGuia;
        private ColumnHeader EstadoEncomienda;
        private ColumnHeader columnHeader1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Button button1;
    }
}