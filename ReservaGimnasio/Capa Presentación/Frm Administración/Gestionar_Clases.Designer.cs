namespace ReservaGimnasio.Capa_Presentación
{
    partial class Gestionar_Clases
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
            this.txtBuscarClase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dataGridGestionClases = new System.Windows.Forms.DataGridView();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestionClases)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarClase
            // 
            this.txtBuscarClase.BackColor = System.Drawing.Color.Black;
            this.txtBuscarClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarClase.ForeColor = System.Drawing.Color.White;
            this.txtBuscarClase.Location = new System.Drawing.Point(110, 81);
            this.txtBuscarClase.Name = "txtBuscarClase";
            this.txtBuscarClase.Size = new System.Drawing.Size(236, 20);
            this.txtBuscarClase.TabIndex = 0;
            this.txtBuscarClase.TextChanged += new System.EventHandler(this.txtBuscarClase_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(159, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTIONAR CLASES ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "🔍 Buscar clase:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Location = new System.Drawing.Point(355, 78);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar ";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dataGridGestionClases
            // 
            this.dataGridGestionClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGestionClases.Location = new System.Drawing.Point(2, 150);
            this.dataGridGestionClases.Name = "dataGridGestionClases";
            this.dataGridGestionClases.Size = new System.Drawing.Size(545, 215);
            this.dataGridGestionClases.TabIndex = 4;
            this.dataGridGestionClases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGestionClases_CellContentClick);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRefrescar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnRefrescar.Location = new System.Drawing.Point(12, 118);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.BtnRefrescar.TabIndex = 5;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseVisualStyleBackColor = false;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnModificar.Location = new System.Drawing.Point(142, 390);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(103, 30);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportarExcel.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExportarExcel.Location = new System.Drawing.Point(273, 390);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Size = new System.Drawing.Size(136, 30);
            this.BtnExportarExcel.TabIndex = 8;
            this.BtnExportarExcel.Text = "Exportar a Excel";
            this.BtnExportarExcel.UseVisualStyleBackColor = false;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
            // 
            // Gestionar_Clases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnRefrescar);
            this.Controls.Add(this.dataGridGestionClases);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarClase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestionar_Clases";
            this.Opacity = 0.9D;
            this.Text = "Gestionar Clases";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestionClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dataGridGestionClases;
        private System.Windows.Forms.Button BtnRefrescar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnExportarExcel;
    }
}