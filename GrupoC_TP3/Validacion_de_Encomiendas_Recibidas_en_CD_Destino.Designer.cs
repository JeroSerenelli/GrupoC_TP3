namespace GrupoC_TP3
{
    partial class Validacion_de_Encomiendas_Recibidas_en_CD_Destino
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
            Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino = new DataGridView();
            label2 = new Label();
            Finalizar_Boton = new Button();
            Volver_Boton = new Button();
            Nro_HDR = new DataGridViewTextBoxColumn();
            Estado_HDR = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino).BeginInit();
            SuspendLayout();
            // 
            // Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino
            // 
            Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino.Columns.AddRange(new DataGridViewColumn[] { Nro_HDR, Estado_HDR });
            Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino.Location = new Point(12, 60);
            Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino.Name = "Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino";
            Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino.RowHeadersWidth = 51;
            Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino.Size = new Size(556, 188);
            Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 7;
            label2.Text = "Validación de Carga";
            label2.Click += label2_Click;
            // 
            // Finalizar_Boton
            // 
            Finalizar_Boton.Location = new Point(474, 380);
            Finalizar_Boton.Name = "Finalizar_Boton";
            Finalizar_Boton.Size = new Size(94, 29);
            Finalizar_Boton.TabIndex = 8;
            Finalizar_Boton.Text = "Finalizar";
            Finalizar_Boton.UseVisualStyleBackColor = true;
            // 
            // Volver_Boton
            // 
            Volver_Boton.Location = new Point(374, 380);
            Volver_Boton.Name = "Volver_Boton";
            Volver_Boton.Size = new Size(94, 29);
            Volver_Boton.TabIndex = 9;
            Volver_Boton.Text = "Volver";
            Volver_Boton.UseVisualStyleBackColor = true;
            // 
            // Nro_HDR
            // 
            Nro_HDR.HeaderText = "Nro HDR";
            Nro_HDR.MinimumWidth = 6;
            Nro_HDR.Name = "Nro_HDR";
            // 
            // Estado_HDR
            // 
            Estado_HDR.HeaderText = "Estado HDR";
            Estado_HDR.MinimumWidth = 6;
            Estado_HDR.Name = "Estado_HDR";
            Estado_HDR.Width = 250;
            // 
            // Validacion_de_Encomiendas_Recibidas_en_CD_Destino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 450);
            Controls.Add(Volver_Boton);
            Controls.Add(Finalizar_Boton);
            Controls.Add(label2);
            Controls.Add(Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino);
            Name = "Validacion_de_Encomiendas_Recibidas_en_CD_Destino";
            Text = "Validacion de Encomiendas Recibidas en CD de Destino";
            ((System.ComponentModel.ISupportInitialize)Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Tabla_HDR_con_Estado_Segun_Encomiendas_Recibidas_en_CD_Destino;
        private Label label2;
        private Button Finalizar_Boton;
        private Button Volver_Boton;
        private DataGridViewTextBoxColumn Nro_HDR;
        private DataGridViewTextBoxColumn Estado_HDR;
    }
}