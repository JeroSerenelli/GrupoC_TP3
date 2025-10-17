namespace GrupoC_TP3.CU5_GestionCD
{
    partial class GestionCentroDeDistribucionForm
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
            groupBox1 = new GroupBox();
            buttonBuscarMicro = new Button();
            textBoxPatente = new TextBox();
            label1 = new Label();
            listViewEncomiendasARecibir = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label18 = new Label();
            groupBox2 = new GroupBox();
            buttonAceptar = new Button();
            groupBox3 = new GroupBox();
            listViewEncomiendasADespachar = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            buttonActualizar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonBuscarMicro);
            groupBox1.Controls.Add(textBoxPatente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Unidad";
            // 
            // buttonBuscarMicro
            // 
            buttonBuscarMicro.Location = new Point(310, 35);
            buttonBuscarMicro.Name = "buttonBuscarMicro";
            buttonBuscarMicro.Size = new Size(75, 23);
            buttonBuscarMicro.TabIndex = 2;
            buttonBuscarMicro.Text = "Buscar";
            buttonBuscarMicro.UseVisualStyleBackColor = true;
            buttonBuscarMicro.Click += buttonBuscarMicro_Click;
            // 
            // textBoxPatente
            // 
            textBoxPatente.Location = new Point(70, 35);
            textBoxPatente.Name = "textBoxPatente";
            textBoxPatente.Size = new Size(219, 23);
            textBoxPatente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Patente:";
            // 
            // listViewEncomiendasARecibir
            // 
            listViewEncomiendasARecibir.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader2, columnHeader5 });
            listViewEncomiendasARecibir.GridLines = true;
            listViewEncomiendasARecibir.Location = new Point(8, 22);
            listViewEncomiendasARecibir.Name = "listViewEncomiendasARecibir";
            listViewEncomiendasARecibir.Size = new Size(398, 99);
            listViewEncomiendasARecibir.TabIndex = 3;
            listViewEncomiendasARecibir.UseCompatibleStateImageBehavior = false;
            listViewEncomiendasARecibir.View = View.Details;
            listViewEncomiendasARecibir.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hoja de Ruta";
            columnHeader4.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Numero de Guia";
            columnHeader2.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estado";
            columnHeader5.Width = 180;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(178, 19);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 65;
            label18.Text = "TUTASA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewEncomiendasARecibir);
            groupBox2.Location = new Point(16, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(426, 136);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descargar y recibir en CD";
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(333, 130);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 3;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listViewEncomiendasADespachar);
            groupBox3.Controls.Add(buttonAceptar);
            groupBox3.Controls.Add(buttonActualizar);
            groupBox3.Location = new Point(16, 302);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(426, 166);
            groupBox3.TabIndex = 68;
            groupBox3.TabStop = false;
            groupBox3.Text = "Despachar desde CD";
            // 
            // listViewEncomiendasADespachar
            // 
            listViewEncomiendasADespachar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader6 });
            listViewEncomiendasADespachar.GridLines = true;
            listViewEncomiendasADespachar.Location = new Point(8, 22);
            listViewEncomiendasADespachar.Name = "listViewEncomiendasADespachar";
            listViewEncomiendasADespachar.Size = new Size(401, 104);
            listViewEncomiendasADespachar.TabIndex = 3;
            listViewEncomiendasADespachar.UseCompatibleStateImageBehavior = false;
            listViewEncomiendasADespachar.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Numero de Guia";
            columnHeader3.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Estado";
            columnHeader6.Width = 180;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(253, 130);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(75, 23);
            buttonActualizar.TabIndex = 3;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // GestionCentroDeDistribucionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 477);
            Controls.Add(groupBox3);
            Controls.Add(label18);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "GestionCentroDeDistribucionForm";
            Text = "Gestion de Centro de Distribucion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listViewEncomiendasARecibir;
        private ColumnHeader columnHeader2;
        private Button buttonBuscarMicro;
        private TextBox textBoxPatente;
        private Label label1;
        private ColumnHeader columnHeader4;
        private Label label18;
        private GroupBox groupBox2;
        private Button buttonAceptar;
        private GroupBox groupBox3;
        private ListView listViewEncomiendasADespachar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private Button buttonActualizar;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}