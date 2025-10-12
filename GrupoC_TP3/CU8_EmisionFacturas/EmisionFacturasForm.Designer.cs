namespace GrupoC_TP3.CU8_EmisionFacturas;

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
        groupBox1 = new GroupBox();
        textBoxCuilCliente = new TextBox();
        buttonBuscarCuilCliente = new Button();
        groupBox2 = new GroupBox();
        textBoxTotalFactura = new TextBox();
        label4 = new Label();
        buttonEmitirFactura = new Button();
        PedidosAFacturarListView = new ListView();
        Nro_Guia = new ColumnHeader();
        Total = new ColumnHeader();
        label3 = new Label();
        label2 = new Label();
        buttonAceptar = new Button();
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
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBoxCuilCliente);
        groupBox1.Controls.Add(buttonBuscarCuilCliente);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(25, 74);
        groupBox1.Margin = new Padding(3, 2, 3, 2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 2, 3, 2);
        groupBox1.Size = new Size(370, 99);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Cliente";
        // 
        // textBoxCuilCliente
        // 
        textBoxCuilCliente.Location = new Point(102, 30);
        textBoxCuilCliente.Name = "textBoxCuilCliente";
        textBoxCuilCliente.Size = new Size(247, 23);
        textBoxCuilCliente.TabIndex = 3;
        // 
        // buttonBuscarCuilCliente
        // 
        buttonBuscarCuilCliente.Location = new Point(282, 73);
        buttonBuscarCuilCliente.Margin = new Padding(3, 2, 3, 2);
        buttonBuscarCuilCliente.Name = "buttonBuscarCuilCliente";
        buttonBuscarCuilCliente.Size = new Size(82, 22);
        buttonBuscarCuilCliente.TabIndex = 2;
        buttonBuscarCuilCliente.Text = "Buscar";
        buttonBuscarCuilCliente.UseVisualStyleBackColor = true;
        buttonBuscarCuilCliente.Click += buttonBuscarCuilCliente_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(textBoxTotalFactura);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(buttonEmitirFactura);
        groupBox2.Controls.Add(PedidosAFacturarListView);
        groupBox2.Location = new Point(25, 188);
        groupBox2.Margin = new Padding(3, 2, 3, 2);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(3, 2, 3, 2);
        groupBox2.Size = new Size(370, 250);
        groupBox2.TabIndex = 3;
        groupBox2.TabStop = false;
        groupBox2.Text = "Servicios a facturar";
        // 
        // textBoxTotalFactura
        // 
        textBoxTotalFactura.Location = new Point(113, 178);
        textBoxTotalFactura.Name = "textBoxTotalFactura";
        textBoxTotalFactura.Size = new Size(100, 23);
        textBoxTotalFactura.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 181);
        label4.Name = "label4";
        label4.Size = new Size(89, 15);
        label4.TabIndex = 4;
        label4.Text = "Total a facturar:";
        // 
        // buttonEmitirFactura
        // 
        buttonEmitirFactura.Location = new Point(259, 214);
        buttonEmitirFactura.Margin = new Padding(3, 2, 3, 2);
        buttonEmitirFactura.Name = "buttonEmitirFactura";
        buttonEmitirFactura.Size = new Size(105, 22);
        buttonEmitirFactura.TabIndex = 3;
        buttonEmitirFactura.Text = "Emitir Factura";
        buttonEmitirFactura.UseVisualStyleBackColor = true;
        buttonEmitirFactura.Click += buttonEmitirFactura_Click;
        // 
        // PedidosAFacturarListView
        // 
        PedidosAFacturarListView.Columns.AddRange(new ColumnHeader[] { Nro_Guia, Total });
        PedidosAFacturarListView.GridLines = true;
        PedidosAFacturarListView.Location = new Point(6, 31);
        PedidosAFacturarListView.Margin = new Padding(3, 2, 3, 2);
        PedidosAFacturarListView.Name = "PedidosAFacturarListView";
        PedidosAFacturarListView.Size = new Size(358, 129);
        PedidosAFacturarListView.TabIndex = 2;
        PedidosAFacturarListView.UseCompatibleStateImageBehavior = false;
        PedidosAFacturarListView.View = View.Details;
        PedidosAFacturarListView.SelectedIndexChanged += PedidosAFacturarListView_SelectedIndexChanged;
        // 
        // Nro_Guia
        // 
        Nro_Guia.Text = "Numero de Guia";
        Nro_Guia.Width = 140;
        // 
        // Total
        // 
        Total.Text = "Subtotal";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(66, 29);
        label3.Name = "label3";
        label3.Size = new Size(269, 15);
        label3.TabIndex = 8;
        label3.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(160, 9);
        label2.Name = "label2";
        label2.Size = new Size(67, 20);
        label2.TabIndex = 7;
        label2.Text = "TUTASA";
        // 
        // buttonAceptar
        // 
        buttonAceptar.Location = new Point(284, 454);
        buttonAceptar.Margin = new Padding(3, 2, 3, 2);
        buttonAceptar.Name = "buttonAceptar";
        buttonAceptar.Size = new Size(105, 22);
        buttonAceptar.TabIndex = 6;
        buttonAceptar.Text = "Aceptar";
        buttonAceptar.UseVisualStyleBackColor = true;
        buttonAceptar.Click += buttonAceptar_Click;
        // 
        // EmisionFacturasForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(480, 526);
        Controls.Add(buttonAceptar);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "EmisionFacturasForm";
        Text = "Facturacion Clientes";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Button buttonBuscarCuilCliente;
    private ListView PedidosAFacturarListView;
    private ColumnHeader Nro_Guia;
    private ColumnHeader Total;
    private Button buttonEmitirFactura;
    private Label label3;
    private Label label2;
    private Label label4;
    private TextBox textBoxCuilCliente;
    private TextBox textBoxTotalFactura;
    private Button buttonAceptar;
}