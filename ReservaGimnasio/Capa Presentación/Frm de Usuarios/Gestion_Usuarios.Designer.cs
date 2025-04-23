namespace ReservaGimnasio.Capa_Presentación.Frm_de_Usuarios
{
    partial class Gestion_Usuarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridListaUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(4, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Usuario";
            // 
            // dataGridListaUsuarios
            // 
            this.dataGridListaUsuarios.AllowUserToOrderColumns = true;
            this.dataGridListaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridListaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dataGridListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaUsuarios.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridListaUsuarios.Location = new System.Drawing.Point(0, 184);
            this.dataGridListaUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridListaUsuarios.Name = "dataGridListaUsuarios";
            this.dataGridListaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridListaUsuarios.Size = new System.Drawing.Size(671, 317);
            this.dataGridListaUsuarios.TabIndex = 3;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBuscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarNombre.Location = new System.Drawing.Point(171, 127);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(290, 26);
            this.txtBuscarNombre.TabIndex = 4;
            // 
            // btnBuscarRegistro
            // 
            this.btnBuscarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarRegistro.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBuscarRegistro.Location = new System.Drawing.Point(469, 127);
            this.btnBuscarRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarRegistro.Name = "btnBuscarRegistro";
            this.btnBuscarRegistro.Size = new System.Drawing.Size(106, 27);
            this.btnBuscarRegistro.TabIndex = 5;
            this.btnBuscarRegistro.Text = "Buscar ";
            this.btnBuscarRegistro.UseVisualStyleBackColor = false;
            this.btnBuscarRegistro.Click += new System.EventHandler(this.btnBuscarRegistro_Click);
            // 
            // Gestion_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(672, 502);
            this.Controls.Add(this.btnBuscarRegistro);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.dataGridListaUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestion_Usuarios";
            this.Text = "Gestion_Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridListaUsuarios;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Button btnBuscarRegistro;
    }
}