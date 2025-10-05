namespace GrupoC_TP3.CU5_RecepcionHDRdeEntregaenAgencia
{
    partial class RecepcionHDRdeEntregaenAgencia
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
            label3 = new Label();
            label1 = new Label();
            DatosdeHDRydeAgencia_Groupbox = new GroupBox();
            Buscar_Button = new Button();
            NumerodeAgencia_label = new Label();
            NuemerodeAgencia_Textbox = new TextBox();
            NumerodeHDR_Label = new Label();
            NumerodeHDR_Textbox = new TextBox();
            ListadodeEncomiendas_Groupbox = new GroupBox();
            ListadodeEncomiendas_Listview = new ListView();
            NroHojaderuta = new ColumnHeader();
            NrodeGuia = new ColumnHeader();
            Cliente = new ColumnHeader();
            TamañoEncomienda = new ColumnHeader();
            Estado = new ColumnHeader();
            Confirmar_Button = new Button();
            Cancelar_Button = new Button();
            DatosdeHDRydeAgencia_Groupbox.SuspendLayout();
            ListadodeEncomiendas_Groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 31);
            label3.Name = "label3";
            label3.Size = new Size(342, 20);
            label3.TabIndex = 8;
            label3.Text = "Transportes Urbanos Terrestres Argentinos S.A.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 4);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 7;
            label1.Text = "TUTASA";
            // 
            // DatosdeHDRydeAgencia_Groupbox
            // 
            DatosdeHDRydeAgencia_Groupbox.Controls.Add(Buscar_Button);
            DatosdeHDRydeAgencia_Groupbox.Controls.Add(NumerodeAgencia_label);
            DatosdeHDRydeAgencia_Groupbox.Controls.Add(NuemerodeAgencia_Textbox);
            DatosdeHDRydeAgencia_Groupbox.Controls.Add(NumerodeHDR_Label);
            DatosdeHDRydeAgencia_Groupbox.Controls.Add(NumerodeHDR_Textbox);
            DatosdeHDRydeAgencia_Groupbox.Location = new Point(26, 76);
            DatosdeHDRydeAgencia_Groupbox.Name = "DatosdeHDRydeAgencia_Groupbox";
            DatosdeHDRydeAgencia_Groupbox.Size = new Size(442, 215);
            DatosdeHDRydeAgencia_Groupbox.TabIndex = 9;
            DatosdeHDRydeAgencia_Groupbox.TabStop = false;
            DatosdeHDRydeAgencia_Groupbox.Text = "Datos de Hoja de ruta y de agencia";
            // 
            // Buscar_Button
            // 
            Buscar_Button.Location = new Point(312, 164);
            Buscar_Button.Name = "Buscar_Button";
            Buscar_Button.Size = new Size(96, 35);
            Buscar_Button.TabIndex = 4;
            Buscar_Button.Text = "Buscar";
            Buscar_Button.UseVisualStyleBackColor = true;
            // 
            // NumerodeAgencia_label
            // 
            NumerodeAgencia_label.AutoSize = true;
            NumerodeAgencia_label.Location = new Point(21, 117);
            NumerodeAgencia_label.Name = "NumerodeAgencia_label";
            NumerodeAgencia_label.Size = new Size(140, 20);
            NumerodeAgencia_label.TabIndex = 3;
            NumerodeAgencia_label.Text = "Número de agencia";
            // 
            // NuemerodeAgencia_Textbox
            // 
            NuemerodeAgencia_Textbox.Location = new Point(21, 140);
            NuemerodeAgencia_Textbox.Name = "NuemerodeAgencia_Textbox";
            NuemerodeAgencia_Textbox.Size = new Size(239, 27);
            NuemerodeAgencia_Textbox.TabIndex = 2;
            // 
            // NumerodeHDR_Label
            // 
            NumerodeHDR_Label.AutoSize = true;
            NumerodeHDR_Label.Location = new Point(21, 45);
            NumerodeHDR_Label.Name = "NumerodeHDR_Label";
            NumerodeHDR_Label.Size = new Size(168, 20);
            NumerodeHDR_Label.TabIndex = 1;
            NumerodeHDR_Label.Text = "Número de hoja de ruta";
            // 
            // NumerodeHDR_Textbox
            // 
            NumerodeHDR_Textbox.Location = new Point(21, 69);
            NumerodeHDR_Textbox.Name = "NumerodeHDR_Textbox";
            NumerodeHDR_Textbox.Size = new Size(239, 27);
            NumerodeHDR_Textbox.TabIndex = 0;
            // 
            // ListadodeEncomiendas_Groupbox
            // 
            ListadodeEncomiendas_Groupbox.Controls.Add(ListadodeEncomiendas_Listview);
            ListadodeEncomiendas_Groupbox.Location = new Point(26, 325);
            ListadodeEncomiendas_Groupbox.Name = "ListadodeEncomiendas_Groupbox";
            ListadodeEncomiendas_Groupbox.Size = new Size(738, 237);
            ListadodeEncomiendas_Groupbox.TabIndex = 10;
            ListadodeEncomiendas_Groupbox.TabStop = false;
            ListadodeEncomiendas_Groupbox.Text = "Listado de encomiendas";
            // 
            // ListadodeEncomiendas_Listview
            // 
            ListadodeEncomiendas_Listview.Columns.AddRange(new ColumnHeader[] { NroHojaderuta, NrodeGuia, Cliente, TamañoEncomienda, Estado });
            ListadodeEncomiendas_Listview.GridLines = true;
            ListadodeEncomiendas_Listview.Location = new Point(33, 37);
            ListadodeEncomiendas_Listview.Name = "ListadodeEncomiendas_Listview";
            ListadodeEncomiendas_Listview.Size = new Size(675, 183);
            ListadodeEncomiendas_Listview.TabIndex = 0;
            ListadodeEncomiendas_Listview.UseCompatibleStateImageBehavior = false;
            ListadodeEncomiendas_Listview.View = View.Details;
            // 
            // NroHojaderuta
            // 
            NroHojaderuta.Text = "Nro Hoja de ruta";
            NroHojaderuta.Width = 130;
            // 
            // NrodeGuia
            // 
            NrodeGuia.Text = "Nro de Guía";
            NrodeGuia.Width = 130;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 130;
            // 
            // TamañoEncomienda
            // 
            TamañoEncomienda.Text = "Tamaño Encomienda";
            TamañoEncomienda.Width = 150;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 130;
            // 
            // Confirmar_Button
            // 
            Confirmar_Button.Location = new Point(738, 603);
            Confirmar_Button.Name = "Confirmar_Button";
            Confirmar_Button.Size = new Size(110, 28);
            Confirmar_Button.TabIndex = 11;
            Confirmar_Button.Text = "Confirmar";
            Confirmar_Button.UseVisualStyleBackColor = true;
            // 
            // Cancelar_Button
            // 
            Cancelar_Button.Location = new Point(858, 603);
            Cancelar_Button.Name = "Cancelar_Button";
            Cancelar_Button.Size = new Size(110, 28);
            Cancelar_Button.TabIndex = 12;
            Cancelar_Button.Text = "Cancelar";
            Cancelar_Button.UseVisualStyleBackColor = true;
            // 
            // RecepcionHDRdeEntregaenAgencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 643);
            Controls.Add(Cancelar_Button);
            Controls.Add(Confirmar_Button);
            Controls.Add(ListadodeEncomiendas_Groupbox);
            Controls.Add(DatosdeHDRydeAgencia_Groupbox);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "RecepcionHDRdeEntregaenAgencia";
            Text = "Hojas de ruta de entrega";
            DatosdeHDRydeAgencia_Groupbox.ResumeLayout(false);
            DatosdeHDRydeAgencia_Groupbox.PerformLayout();
            ListadodeEncomiendas_Groupbox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private GroupBox DatosdeHDRydeAgencia_Groupbox;
        private TextBox NuemerodeAgencia_Textbox;
        private Label NumerodeHDR_Label;
        private TextBox NumerodeHDR_Textbox;
        private Button Buscar_Button;
        private Label NumerodeAgencia_label;
        private GroupBox ListadodeEncomiendas_Groupbox;
        private ListView ListadodeEncomiendas_Listview;
        private ColumnHeader NroHojaderuta;
        private ColumnHeader NrodeGuia;
        private ColumnHeader Cliente;
        private ColumnHeader TamañoEncomienda;
        private ColumnHeader Estado;
        private Button Confirmar_Button;
        private Button Cancelar_Button;
    }
}