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
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            PedidosAFacturarListView = new ListView();
            Nro_Guia = new ColumnHeader();
            Total = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "CUIT/CUIL:";
            label1.Click += label1_Click;
            // 
            // razonSocialTxt
            // 
            razonSocialTxt.Location = new Point(125, 31);
            razonSocialTxt.Margin = new Padding(3, 2, 3, 2);
            razonSocialTxt.Name = "razonSocialTxt";
            razonSocialTxt.Size = new Size(135, 23);
            razonSocialTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(razonSocialTxt);
            groupBox1.Location = new Point(25, 29);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(370, 84);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(277, 29);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(PedidosAFacturarListView);
            groupBox2.Location = new Point(25, 117);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(370, 231);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pedidos a Facturar";
            // 
            // button2
            // 
            button2.Location = new Point(19, 176);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(183, 22);
            button2.TabIndex = 3;
            button2.Text = "Emitir Factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // PedidosAFacturarListView
            // 
            PedidosAFacturarListView.Columns.AddRange(new ColumnHeader[] { Nro_Guia, Total });
            PedidosAFacturarListView.Location = new Point(21, 31);
            PedidosAFacturarListView.Margin = new Padding(3, 2, 3, 2);
            PedidosAFacturarListView.Name = "PedidosAFacturarListView";
            PedidosAFacturarListView.Size = new Size(214, 129);
            PedidosAFacturarListView.TabIndex = 2;
            PedidosAFacturarListView.UseCompatibleStateImageBehavior = false;
            PedidosAFacturarListView.View = View.Details;
            PedidosAFacturarListView.SelectedIndexChanged += cuentaCorrienteLstView_SelectedIndexChanged;
            // 
            // Nro_Guia
            // 
            Nro_Guia.Text = "Numero de Guia";
            Nro_Guia.Width = 140;
            // 
            // Total
            // 
            Total.Text = "Total";
            // 
            // EmisionFacturasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 377);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmisionFacturasForm";
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
        private ListView PedidosAFacturarListView;
        private ColumnHeader Nro_Guia;
        private ColumnHeader Total;
        private Button button2;
    }
}