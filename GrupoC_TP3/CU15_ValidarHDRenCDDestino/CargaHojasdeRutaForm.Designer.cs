namespace GrupoC_TP3
{
    partial class CargaHojasdeRutaRecibidasenCDDestino
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
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            Hoja_Ruta_Recibida_CD_Destino_TextBox = new TextBox();
            Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton = new Button();
            Validar_HDR_Recibida_CD_Destino_Boton = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            Encomiendas_HDR_Recibidas_CD_Destino_listView = new ListView();
            Nro_HDR = new ColumnHeader();
            Nro_Guia = new ColumnHeader();
            Estado_Encomienda = new ColumnHeader();
            Nombre_Destinatario = new ColumnHeader();
            Apellido_Destinatario = new ColumnHeader();
            Destino = new ColumnHeader();
            Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox = new ComboBox();
            Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton = new Button();
            Selecionar = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Hoja_Ruta_Recibida_CD_Destino_TextBox
            // 
            Hoja_Ruta_Recibida_CD_Destino_TextBox.Location = new Point(6, 26);
            Hoja_Ruta_Recibida_CD_Destino_TextBox.Name = "Hoja_Ruta_Recibida_CD_Destino_TextBox";
            Hoja_Ruta_Recibida_CD_Destino_TextBox.Size = new Size(158, 27);
            Hoja_Ruta_Recibida_CD_Destino_TextBox.TabIndex = 1;
            // 
            // Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton
            // 
            Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton.Location = new Point(170, 24);
            Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton.Name = "Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton";
            Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton.Size = new Size(150, 29);
            Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton.TabIndex = 2;
            Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton.Text = "Ingresar";
            Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton.UseVisualStyleBackColor = true;
            // 
            // Validar_HDR_Recibida_CD_Destino_Boton
            // 
            Validar_HDR_Recibida_CD_Destino_Boton.Location = new Point(18, 448);
            Validar_HDR_Recibida_CD_Destino_Boton.Name = "Validar_HDR_Recibida_CD_Destino_Boton";
            Validar_HDR_Recibida_CD_Destino_Boton.Size = new Size(150, 29);
            Validar_HDR_Recibida_CD_Destino_Boton.TabIndex = 4;
            Validar_HDR_Recibida_CD_Destino_Boton.Text = "Validar";
            Validar_HDR_Recibida_CD_Destino_Boton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton);
            groupBox1.Controls.Add(Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox);
            groupBox1.Controls.Add(Encomiendas_HDR_Recibidas_CD_Destino_listView);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Hoja_Ruta_Recibida_CD_Destino_TextBox);
            groupBox1.Controls.Add(Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(810, 415);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hoja de Ruta";
            groupBox1.Enter += this.groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 75);
            label1.Name = "label1";
            label1.Size = new Size(244, 20);
            label1.TabIndex = 6;
            label1.Text = "Seleccione una o mas encomiendas";
            // 
            // Encomiendas_HDR_Recibidas_CD_Destino_listView
            // 
            Encomiendas_HDR_Recibidas_CD_Destino_listView.Columns.AddRange(new ColumnHeader[] { Selecionar, Nro_HDR, Nro_Guia, Estado_Encomienda, Nombre_Destinatario, Apellido_Destinatario, Destino });
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            Encomiendas_HDR_Recibidas_CD_Destino_listView.Groups.AddRange(new ListViewGroup[] { listViewGroup2 });
            Encomiendas_HDR_Recibidas_CD_Destino_listView.Location = new Point(6, 109);
            Encomiendas_HDR_Recibidas_CD_Destino_listView.Name = "Encomiendas_HDR_Recibidas_CD_Destino_listView";
            Encomiendas_HDR_Recibidas_CD_Destino_listView.Size = new Size(798, 121);
            Encomiendas_HDR_Recibidas_CD_Destino_listView.TabIndex = 9;
            Encomiendas_HDR_Recibidas_CD_Destino_listView.UseCompatibleStateImageBehavior = false;
            Encomiendas_HDR_Recibidas_CD_Destino_listView.View = View.Details;
            // 
            // Nro_HDR
            // 
            Nro_HDR.Tag = "";
            Nro_HDR.Text = "Nro Hoja de Ruta";
            Nro_HDR.Width = 150;
            // 
            // Nro_Guia
            // 
            Nro_Guia.Text = "Nro de Guia";
            Nro_Guia.Width = 120;
            // 
            // Estado_Encomienda
            // 
            Estado_Encomienda.Text = "Estado Encomienda";
            Estado_Encomienda.Width = 200;
            // 
            // Nombre_Destinatario
            // 
            Nombre_Destinatario.Text = "Nombre";
            Nombre_Destinatario.Width = 100;
            // 
            // Apellido_Destinatario
            // 
            Apellido_Destinatario.Text = "Apellido";
            Apellido_Destinatario.Width = 100;
            // 
            // Destino
            // 
            Destino.Text = "Destino";
            Destino.Width = 100;
            // 
            // Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox
            // 
            Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox.FormattingEnabled = true;
            Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox.Location = new Point(6, 255);
            Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox.Name = "Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox";
            Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox.Size = new Size(150, 28);
            Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox.TabIndex = 10;
            // 
            // Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton
            // 
            Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton.Location = new Point(6, 298);
            Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton.Name = "Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton";
            Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton.Size = new Size(150, 29);
            Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton.TabIndex = 11;
            Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton.Text = "Actualizar Estado";
            Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton.UseVisualStyleBackColor = true;
            // 
            // Selecionar
            // 
            Selecionar.Text = "Selecionar";
            // 
            // CargaHojasdeRutaRecibidasenCDDestino
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 503);
            Controls.Add(groupBox1);
            Controls.Add(Validar_HDR_Recibida_CD_Destino_Boton);
            Name = "CargaHojasdeRutaRecibidasenCDDestino";
            Text = "Carga de Hojas de Ruta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox Hoja_Ruta_Recibida_CD_Destino_TextBox;
        private Button Ingreso_Hojas_Ruta_Recibidas_CD_Destino_Boton;
        private Button Validar_HDR_Recibida_CD_Destino_Boton;
        private GroupBox groupBox1;
        private Label label1;
        private ListView Encomiendas_HDR_Recibidas_CD_Destino_listView;
        private ColumnHeader Nro_HDR;
        private ColumnHeader Nro_Guia;
        private ColumnHeader Estado_Encomienda;
        private ColumnHeader Nombre_Destinatario;
        private ColumnHeader Apellido_Destinatario;
        private ColumnHeader Destino;
        private Button Actualizar_Estado_Guias_Recibidas_CD_Destino_Boton;
        private ComboBox Actualizar_Estado_Guias_Recibidas_CD_Destino_ComboBox;
        private ColumnHeader Selecionar;
    }
}