namespace ReservaGimnasio.Capa_Presentación.Frm_Administración
{
    partial class Horario_Clases
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeHorarios = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbEntrenadores = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbSalon = new System.Windows.Forms.ComboBox();
            this.dataGridVistaHorarios = new System.Windows.Forms.DataGridView();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVistaHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vista Horarios";
            // 
            // dateTimeHorarios
            // 
            this.dateTimeHorarios.Location = new System.Drawing.Point(99, 133);
            this.dateTimeHorarios.Name = "dateTimeHorarios";
            this.dateTimeHorarios.ShowUpDown = true;
            this.dateTimeHorarios.Size = new System.Drawing.Size(215, 20);
            this.dateTimeHorarios.TabIndex = 3;
           // this.dateTimeHorarios.ValueChanged += new System.EventHandler(this.dateTimeHorarios_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(365, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "🔍 Filtros:";
            // 
            // CmbEntrenadores
            // 
            this.CmbEntrenadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CmbEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbEntrenadores.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEntrenadores.ForeColor = System.Drawing.Color.Transparent;
            this.CmbEntrenadores.FormattingEnabled = true;
            this.CmbEntrenadores.Location = new System.Drawing.Point(482, 108);
            this.CmbEntrenadores.Name = "CmbEntrenadores";
            this.CmbEntrenadores.Size = new System.Drawing.Size(156, 24);
            this.CmbEntrenadores.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(382, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "- Entrenador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(374, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = " - Salón / Área:";
            // 
            // CmbSalon
            // 
            this.CmbSalon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CmbSalon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbSalon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSalon.ForeColor = System.Drawing.Color.Transparent;
            this.CmbSalon.FormattingEnabled = true;
            this.CmbSalon.Location = new System.Drawing.Point(481, 137);
            this.CmbSalon.Name = "CmbSalon";
            this.CmbSalon.Size = new System.Drawing.Size(157, 24);
            this.CmbSalon.TabIndex = 12;
            // 
            // dataGridVistaHorarios
            // 
            this.dataGridVistaHorarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridVistaHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVistaHorarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridVistaHorarios.Location = new System.Drawing.Point(17, 167);
            this.dataGridVistaHorarios.Name = "dataGridVistaHorarios";
            this.dataGridVistaHorarios.Size = new System.Drawing.Size(621, 179);
            this.dataGridVistaHorarios.TabIndex = 13;
            // 
            // BtnExportar
            // 
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExportar.Location = new System.Drawing.Point(197, 367);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(109, 28);
            this.BtnExportar.TabIndex = 14;
            this.BtnExportar.Text = "Exportar PDF";
            this.BtnExportar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Location = new System.Drawing.Point(339, 367);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(109, 28);
            this.BtnCerrar.TabIndex = 15;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // Horario_Clases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.dataGridVistaHorarios);
            this.Controls.Add(this.CmbSalon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbEntrenadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeHorarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Horario_Clases";
            this.Text = "Horario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVistaHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHorarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbEntrenadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbSalon;
        private System.Windows.Forms.DataGridView dataGridVistaHorarios;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnCerrar;
    }
}