namespace GrupoC_TP3
{
    partial class EmisionFacturasForm
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
            razonSocialTxt = new TextBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            razonSocialList = new ListView();
            RazonSocialColumn = new ColumnHeader();
            cuitColumn = new ColumnHeader();
            nombreSolicitante = new ColumnHeader();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            cuentaCorrienteLstView = new ListView();
            Nro_Guia = new ColumnHeader();
            Sub_Total = new ColumnHeader();
            Total = new ColumnHeader();
            apellidoSolicitante = new ColumnHeader();
            EstadoEncomienda = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Razon Social:";
            label1.Click += label1_Click;
            // 
            // razonSocialTxt
            // 
            razonSocialTxt.Location = new Point(143, 41);
            razonSocialTxt.Name = "razonSocialTxt";
            razonSocialTxt.Size = new Size(154, 27);
            razonSocialTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(razonSocialList);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(razonSocialTxt);
            groupBox1.Location = new Point(29, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(759, 195);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(591, 91);
            button4.Name = "button4";
            button4.Size = new Size(118, 61);
            button4.TabIndex = 6;
            button4.Text = "Mostrar Facturas";
            button4.UseVisualStyleBackColor = true;
            // 
            // razonSocialList
            // 
            razonSocialList.Columns.AddRange(new ColumnHeader[] { RazonSocialColumn, cuitColumn, nombreSolicitante, apellidoSolicitante });
            razonSocialList.Location = new Point(22, 91);
            razonSocialList.Name = "razonSocialList";
            razonSocialList.Size = new Size(563, 81);
            razonSocialList.TabIndex = 5;
            razonSocialList.UseCompatibleStateImageBehavior = false;
            razonSocialList.View = View.Details;
            razonSocialList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // RazonSocialColumn
            // 
            RazonSocialColumn.Text = "Razon Social";
            RazonSocialColumn.Width = 120;
            // 
            // cuitColumn
            // 
            cuitColumn.Text = "CUIT";
            cuitColumn.Width = 120;
            // 
            // nombreSolicitante
            // 
            nombreSolicitante.Text = "Nombre Solicitante";
            nombreSolicitante.Width = 160;
            // 
            // button1
            // 
            button1.Location = new Point(317, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(cuentaCorrienteLstView);
            groupBox2.Location = new Point(29, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(759, 293);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pedidos a Facturar";
            // 
            // button2
            // 
            button2.Location = new Point(22, 235);
            button2.Name = "button2";
            button2.Size = new Size(209, 29);
            button2.TabIndex = 3;
            button2.Text = "Emitir Factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // cuentaCorrienteLstView
            // 
            cuentaCorrienteLstView.Columns.AddRange(new ColumnHeader[] { Nro_Guia, EstadoEncomienda, Sub_Total, Total });
            cuentaCorrienteLstView.Location = new Point(24, 41);
            cuentaCorrienteLstView.Name = "cuentaCorrienteLstView";
            cuentaCorrienteLstView.Size = new Size(685, 171);
            cuentaCorrienteLstView.TabIndex = 2;
            cuentaCorrienteLstView.UseCompatibleStateImageBehavior = false;
            cuentaCorrienteLstView.View = View.Details;
            cuentaCorrienteLstView.SelectedIndexChanged += cuentaCorrienteLstView_SelectedIndexChanged;
            // 
            // Nro_Guia
            // 
            Nro_Guia.Text = "Numero de Guia";
            Nro_Guia.Width = 140;
            // 
            // Sub_Total
            // 
            Sub_Total.DisplayIndex = 1;
            Sub_Total.Text = "Sub Total";
            Sub_Total.Width = 100;
            // 
            // Total
            // 
            Total.DisplayIndex = 2;
            Total.Text = "Total";
            // 
            // apellidoSolicitante
            // 
            apellidoSolicitante.Text = "Apellido Solicitante";
            apellidoSolicitante.Width = 160;
            // 
            // EstadoEncomienda
            // 
            EstadoEncomienda.DisplayIndex = 3;
            EstadoEncomienda.Text = "Estado Encomienda";
            EstadoEncomienda.Width = 180;
            // 
            // EmisionFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 536);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EmisionFacturas";
            Text = "CU3: Emision de Facutras";
            Load += EmisionFacturas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox razonSocialTxt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private ListView cuentaCorrienteLstView;
        private ColumnHeader Nro_Guia;
        private ColumnHeader Sub_Total;
        private ColumnHeader Total;
        private Button button2;
        private ListView razonSocialList;
        private ColumnHeader RazonSocialColumn;
        private ColumnHeader cuitColumn;
        private ColumnHeader nombreSolicitante;
        private Button button4;
        private ColumnHeader apellidoSolicitante;
        private ColumnHeader EstadoEncomienda;
    }
}