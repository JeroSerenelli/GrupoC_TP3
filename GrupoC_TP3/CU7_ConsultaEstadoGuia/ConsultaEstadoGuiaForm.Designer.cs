namespace GrupoC_TP3.CU7_ConsultaEstadoGuia
{
    partial class ConsultaEstadoGuiaForm
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
            textBoxNumeroGuiaConsulta = new TextBox();
            buttonBuscar = new Button();
            listView1 = new ListView();
            EstadoEncomienda = new ColumnHeader();
            UltimaActualizacion = new ColumnHeader();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 4);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 33);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero de Guia:";
            // 
            // textBoxNumeroGuiaConsulta
            // 
            textBoxNumeroGuiaConsulta.Location = new Point(128, 29);
            textBoxNumeroGuiaConsulta.Margin = new Padding(3, 4, 3, 4);
            textBoxNumeroGuiaConsulta.Name = "textBoxNumeroGuiaConsulta";
            textBoxNumeroGuiaConsulta.Size = new Size(283, 27);
            textBoxNumeroGuiaConsulta.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(320, 88);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(91, 36);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { EstadoEncomienda, UltimaActualizacion });
            listView1.Location = new Point(7, 29);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(478, 173);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // EstadoEncomienda
            // 
            EstadoEncomienda.Text = "Estado de Encomienda";
            EstadoEncomienda.Width = 150;
            // 
            // UltimaActualizacion
            // 
            UltimaActualizacion.Text = "Ultima Actualizacion";
            UltimaActualizacion.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 31);
            label3.Name = "label3";
            label3.Size = new Size(342, 20);
            label3.TabIndex = 6;
            label3.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(14, 211);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(514, 243);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados de Consulta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxNumeroGuiaConsulta);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(buttonBuscar);
            groupBox2.Location = new Point(21, 71);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(424, 132);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parametros de Consulta";
            // 
            // button1
            // 
            button1.Location = new Point(437, 476);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 9;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAceptar_Click;
            // 
            // ConsultaEstadoGuiaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 516);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultaEstadoGuiaForm";
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
        private TextBox textBoxNumeroGuiaConsulta;
        private Button buttonBuscar;
        private ListView listView1;
        private ColumnHeader EstadoEncomienda;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ColumnHeader UltimaActualizacion;
        private Button button1;
    }
}