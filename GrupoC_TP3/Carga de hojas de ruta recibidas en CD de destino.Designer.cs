namespace GrupoC_TP3
{
    partial class Carga_de_hojas_de_ruta_recibidas_en_CD_de_destino
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
            Hoja_Ruta_Recibida_CD_Destino_TextBox = new TextBox();
            Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton = new Button();
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid = new DataGridView();
            Siguiente_Boton = new Button();
            label2 = new Label();
            Nro_HDR = new DataGridViewTextBoxColumn();
            CD_Destino = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Tag = "";
            label1.Text = "Ingrese Hoja de Ruta";
            label1.Click += label1_Click;
            // 
            // Hoja_Ruta_Recibida_CD_Destino_TextBox
            // 
            Hoja_Ruta_Recibida_CD_Destino_TextBox.Location = new Point(12, 73);
            Hoja_Ruta_Recibida_CD_Destino_TextBox.Name = "Hoja_Ruta_Recibida_CD_Destino_TextBox";
            Hoja_Ruta_Recibida_CD_Destino_TextBox.Size = new Size(158, 27);
            Hoja_Ruta_Recibida_CD_Destino_TextBox.TabIndex = 1;
            // 
            // Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton
            // 
            Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton.Location = new Point(176, 71);
            Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton.Name = "Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton";
            Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton.Size = new Size(94, 29);
            Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton.TabIndex = 2;
            Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton.Text = "Cargar";
            Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton.UseVisualStyleBackColor = true;
            // 
            // Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid
            // 
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid.Columns.AddRange(new DataGridViewColumn[] { Nro_HDR, CD_Destino });
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid.Location = new Point(12, 130);
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid.Name = "Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid";
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid.RowHeadersWidth = 51;
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid.Size = new Size(467, 105);
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid.TabIndex = 3;
            Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Siguiente_Boton
            // 
            Siguiente_Boton.Location = new Point(385, 263);
            Siguiente_Boton.Name = "Siguiente_Boton";
            Siguiente_Boton.Size = new Size(94, 29);
            Siguiente_Boton.TabIndex = 4;
            Siguiente_Boton.Text = "Siguiente";
            Siguiente_Boton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 5;
            label2.Text = "Carga de Hojas de Ruta";
            // 
            // Nro_HDR
            // 
            Nro_HDR.HeaderText = "Nro HDR";
            Nro_HDR.MinimumWidth = 6;
            Nro_HDR.Name = "Nro_HDR";
            // 
            // CD_Destino
            // 
            CD_Destino.HeaderText = "CD Destino";
            CD_Destino.MinimumWidth = 6;
            CD_Destino.Name = "CD_Destino";
            CD_Destino.Width = 200;
            // 
            // Carga_de_hojas_de_ruta_recibidas_en_CD_de_destino
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 330);
            Controls.Add(label2);
            Controls.Add(Siguiente_Boton);
            Controls.Add(Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid);
            Controls.Add(Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton);
            Controls.Add(Hoja_Ruta_Recibida_CD_Destino_TextBox);
            Controls.Add(label1);
            Name = "Carga_de_hojas_de_ruta_recibidas_en_CD_de_destino";
            Text = "Carga de Hojas de Ruta Recibidas en CD de Destino";
            ((System.ComponentModel.ISupportInitialize)Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Hoja_Ruta_Recibida_CD_Destino_TextBox;
        private Button Carga_Hojas_Ruta_Recibidas_CD_Destino_Boton;
        private DataGridView Tabla_Hojas_de_Ruta_Recibidas_en_CD_Destino_DataGrid;
        private Button Siguiente_Boton;
        private Label label2;
        private DataGridViewTextBoxColumn Nro_HDR;
        private DataGridViewTextBoxColumn CD_Destino;
    }
}