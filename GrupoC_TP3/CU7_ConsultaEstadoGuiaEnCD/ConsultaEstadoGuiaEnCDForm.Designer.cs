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
            EstadoEncomienda = new ColumnHeader();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            columnHeader1 = new ColumnHeader();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
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
            // textBoxNumeroGuiaConsultaEnCD
            // 
            textBoxNumeroGuiaConsultaEnCD.Location = new Point(112, 22);
            textBoxNumeroGuiaConsultaEnCD.Name = "textBoxNumeroGuiaConsultaEnCD";
            textBoxNumeroGuiaConsultaEnCD.Size = new Size(248, 23);
            textBoxNumeroGuiaConsultaEnCD.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(18, 118);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(134, 23);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(158, 118);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(133, 23);
            buttonLimpiar.TabIndex = 4;
            buttonLimpiar.Text = "Nueva Busqueda";
            buttonLimpiar.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 29);
            label3.Name = "label3";
            label3.Size = new Size(269, 15);
            label3.TabIndex = 6;
            label3.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 182);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados de Consulta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxNumeroGuiaConsultaEnCD);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(18, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 59);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parametros de Consulta";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ultima Actualizacion";
            columnHeader1.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(365, 376);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // ConsultaEstadoGuiaEnCDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 413);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(label1);
            Name = "ConsultaEstadoGuiaEnCDForm";
            Text = "Consulta de Estado de Guia";
            Load += ConsultaEstadoGuiaEnCDForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private ColumnHeader EstadoEncomienda;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ColumnHeader columnHeader1;
        private Button button1;
    }
}