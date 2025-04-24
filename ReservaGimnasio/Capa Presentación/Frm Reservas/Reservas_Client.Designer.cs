namespace ReservaGimnasio.Capa_Presentación.Frm_Reservas
{
    partial class Reservas_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // --- Declaración de todos los controles ---
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbTipoClase;
        private System.Windows.Forms.Label lblTipoClase;
        private System.Windows.Forms.ComboBox cmbEntrenador;
        private System.Windows.Forms.Label lblEntrenadorFiltro;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.DataGridView dgvClasesDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salon;
        private System.Windows.Forms.DataGridViewButtonColumn btnReservar;
        private System.Windows.Forms.Label lblClasesDisponibles;
        private System.Windows.Forms.Button btnConfirmarReserva;
        // --- Fin de la declaración de controles ---

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbTipoClase = new System.Windows.Forms.ComboBox();
            this.lblTipoClase = new System.Windows.Forms.Label();
            this.cmbEntrenador = new System.Windows.Forms.ComboBox();
            this.lblEntrenadorFiltro = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.dgvClasesDisponibles = new System.Windows.Forms.DataGridView();
            this.ClaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblClasesDisponibles = new System.Windows.Forms.Label();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(720, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RESERVA DE CLASES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panelFiltros.Controls.Add(this.btnFiltrar);
            this.panelFiltros.Controls.Add(this.cmbTipoClase);
            this.panelFiltros.Controls.Add(this.lblTipoClase);
            this.panelFiltros.Controls.Add(this.cmbEntrenador);
            this.panelFiltros.Controls.Add(this.lblEntrenadorFiltro);
            this.panelFiltros.Controls.Add(this.cmbDia);
            this.panelFiltros.Controls.Add(this.lblDia);
            this.panelFiltros.Controls.Add(this.lblFiltros);
            this.panelFiltros.Location = new System.Drawing.Point(50, 100);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(720, 90);
            this.panelFiltros.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(621, 50);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(96, 26);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // cmbTipoClase
            // 
            this.cmbTipoClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoClase.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbTipoClase.FormattingEnabled = true;
            this.cmbTipoClase.Location = new System.Drawing.Point(478, 52);
            this.cmbTipoClase.Name = "cmbTipoClase";
            this.cmbTipoClase.Size = new System.Drawing.Size(131, 29);
            this.cmbTipoClase.TabIndex = 6;
            // 
            // lblTipoClase
            // 
            this.lblTipoClase.AutoSize = true;
            this.lblTipoClase.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTipoClase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTipoClase.Location = new System.Drawing.Point(407, 53);
            this.lblTipoClase.Name = "lblTipoClase";
            this.lblTipoClase.Size = new System.Drawing.Size(65, 23);
            this.lblTipoClase.TabIndex = 5;
            this.lblTipoClase.Text = "Salon:";
            // 
            // cmbEntrenador
            // 
            this.cmbEntrenador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntrenador.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbEntrenador.FormattingEnabled = true;
            this.cmbEntrenador.Location = new System.Drawing.Point(275, 51);
            this.cmbEntrenador.Name = "cmbEntrenador";
            this.cmbEntrenador.Size = new System.Drawing.Size(126, 29);
            this.cmbEntrenador.TabIndex = 4;
            // 
            // lblEntrenadorFiltro
            // 
            this.lblEntrenadorFiltro.AutoSize = true;
            this.lblEntrenadorFiltro.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblEntrenadorFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblEntrenadorFiltro.Location = new System.Drawing.Point(170, 53);
            this.lblEntrenadorFiltro.Name = "lblEntrenadorFiltro";
            this.lblEntrenadorFiltro.Size = new System.Drawing.Size(113, 23);
            this.lblEntrenadorFiltro.TabIndex = 3;
            this.lblEntrenadorFiltro.Text = "Entrenador:";
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(62, 50);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(102, 29);
            this.cmbDia.TabIndex = 2;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDia.Location = new System.Drawing.Point(15, 53);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(47, 23);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Día:";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblFiltros.Location = new System.Drawing.Point(15, 15);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(167, 29);
            this.lblFiltros.TabIndex = 0;
            this.lblFiltros.Text = "Filtrar clases:";
            // 
            // dgvClasesDisponibles
            // 
            this.dgvClasesDisponibles.AllowUserToAddRows = false;
            this.dgvClasesDisponibles.AllowUserToDeleteRows = false;
            this.dgvClasesDisponibles.AllowUserToResizeRows = false;
            this.dgvClasesDisponibles.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasesDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClasesDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasesDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClasesDisponibles.ColumnHeadersHeight = 30;
            this.dgvClasesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClasesDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaseID,
            this.NombreClase,
            this.Entrenador,
            this.Horario,
            this.Duracion,
            this.Disponibilidad,
            this.Salon,
            this.btnReservar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasesDisponibles.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClasesDisponibles.EnableHeadersVisualStyles = false;
            this.dgvClasesDisponibles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgvClasesDisponibles.Location = new System.Drawing.Point(50, 240);
            this.dgvClasesDisponibles.MultiSelect = false;
            this.dgvClasesDisponibles.Name = "dgvClasesDisponibles";
            this.dgvClasesDisponibles.ReadOnly = true;
            this.dgvClasesDisponibles.RowHeadersVisible = false;
            this.dgvClasesDisponibles.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dgvClasesDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClasesDisponibles.RowTemplate.Height = 35;
            this.dgvClasesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasesDisponibles.Size = new System.Drawing.Size(720, 180);
            this.dgvClasesDisponibles.TabIndex = 3;
            this.dgvClasesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasesDisponibles_CellContentClick);
            // 
            // ClaseID
            // 
            this.ClaseID.DataPropertyName = "ClaseID";
            this.ClaseID.HeaderText = "ID";
            this.ClaseID.MinimumWidth = 8;
            this.ClaseID.Name = "ClaseID";
            this.ClaseID.ReadOnly = true;
            this.ClaseID.Visible = false;
            this.ClaseID.Width = 150;
            // 
            // NombreClase
            // 
            this.NombreClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreClase.DataPropertyName = "NombreClase";
            this.NombreClase.HeaderText = "Nombre";
            this.NombreClase.MinimumWidth = 100;
            this.NombreClase.Name = "NombreClase";
            this.NombreClase.ReadOnly = true;
            // 
            // Entrenador
            // 
            this.Entrenador.DataPropertyName = "Entrenador";
            this.Entrenador.HeaderText = "Entrenador";
            this.Entrenador.MinimumWidth = 100;
            this.Entrenador.Name = "Entrenador";
            this.Entrenador.ReadOnly = true;
            this.Entrenador.Width = 120;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.MinimumWidth = 100;
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 110;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "Duracion";
            this.Duracion.HeaderText = "Duración";
            this.Duracion.MinimumWidth = 60;
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Width = 80;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.DataPropertyName = "Disponibilidad";
            this.Disponibilidad.HeaderText = "Disponibilidad";
            this.Disponibilidad.MinimumWidth = 80;
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.ReadOnly = true;
            this.Disponibilidad.Width = 150;
            // 
            // Salon
            // 
            this.Salon.DataPropertyName = "Salon";
            this.Salon.HeaderText = "Salón";
            this.Salon.MinimumWidth = 80;
            this.Salon.Name = "Salon";
            this.Salon.ReadOnly = true;
            this.Salon.Visible = false;
            this.Salon.Width = 150;
            // 
            // btnReservar
            // 
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.HeaderText = "Acción";
            this.btnReservar.MinimumWidth = 80;
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.ReadOnly = true;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseColumnTextForButtonValue = true;
            this.btnReservar.Width = 90;
            // 
            // lblClasesDisponibles
            // 
            this.lblClasesDisponibles.AutoSize = true;
            this.lblClasesDisponibles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblClasesDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblClasesDisponibles.Location = new System.Drawing.Point(52, 208);
            this.lblClasesDisponibles.Name = "lblClasesDisponibles";
            this.lblClasesDisponibles.Size = new System.Drawing.Size(240, 29);
            this.lblClasesDisponibles.TabIndex = 2;
            this.lblClasesDisponibles.Text = "Clases Disponibles:";
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnConfirmarReserva.FlatAppearance.BorderSize = 0;
            this.btnConfirmarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarReserva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarReserva.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarReserva.Location = new System.Drawing.Point(295, 453);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(243, 50);
            this.btnConfirmarReserva.TabIndex = 14;
            this.btnConfirmarReserva.Text = "CONFIRMAR RESERVA";
            this.btnConfirmarReserva.UseVisualStyleBackColor = false;
            this.btnConfirmarReserva.Click += new System.EventHandler(this.btnConfirmarReserva_Click_1);
            // 
            // Reservas_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblClasesDisponibles);
            this.Controls.Add(this.btnConfirmarReserva);
            this.Controls.Add(this.dgvClasesDisponibles);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Reservas_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Clases";
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}