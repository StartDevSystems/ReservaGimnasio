namespace Principal
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panelReportesSubMenu = new System.Windows.Forms.Panel();
            this.btnReporteAsistencias = new System.Windows.Forms.Button();
            this.panelClasesSubMenu = new System.Windows.Forms.Panel();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnGestionarClases = new System.Windows.Forms.Button();
            this.btnAgregarClase = new System.Windows.Forms.Button();
            this.btnClases = new System.Windows.Forms.Button();
            this.panelUsuarioSubMenu = new System.Windows.Forms.Panel();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBoxLogoCentro = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnvolver_login = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelReportesSubMenu.SuspendLayout();
            this.panelClasesSubMenu.SuspendLayout();
            this.panelUsuarioSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCentro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnvolver_login);
            this.panelSideMenu.Controls.Add(this.btnSalir);
            this.panelSideMenu.Controls.Add(this.btnAyuda);
            this.panelSideMenu.Controls.Add(this.panelReportesSubMenu);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.panelClasesSubMenu);
            this.panelSideMenu.Controls.Add(this.btnClases);
            this.panelSideMenu.Controls.Add(this.panelUsuarioSubMenu);
            this.panelSideMenu.Controls.Add(this.btnUsuarios);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Silver;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 621);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(233, 45);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.ForeColor = System.Drawing.Color.Silver;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 487);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(233, 67);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // panelReportesSubMenu
            // 
            this.panelReportesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelReportesSubMenu.Controls.Add(this.btnReporteAsistencias);
            this.panelReportesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportesSubMenu.Location = new System.Drawing.Point(0, 444);
            this.panelReportesSubMenu.Name = "panelReportesSubMenu";
            this.panelReportesSubMenu.Size = new System.Drawing.Size(233, 43);
            this.panelReportesSubMenu.TabIndex = 7;
            // 
            // btnReporteAsistencias
            // 
            this.btnReporteAsistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteAsistencias.FlatAppearance.BorderSize = 0;
            this.btnReporteAsistencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnReporteAsistencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnReporteAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAsistencias.ForeColor = System.Drawing.Color.Silver;
            this.btnReporteAsistencias.Location = new System.Drawing.Point(0, 0);
            this.btnReporteAsistencias.Name = "btnReporteAsistencias";
            this.btnReporteAsistencias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReporteAsistencias.Size = new System.Drawing.Size(233, 40);
            this.btnReporteAsistencias.TabIndex = 0;
            this.btnReporteAsistencias.Text = "Reporte de Asistencias";
            this.btnReporteAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteAsistencias.UseVisualStyleBackColor = true;
            this.btnReporteAsistencias.Click += new System.EventHandler(this.btnReporteAsistencias_Click);
            // 
            // panelClasesSubMenu
            // 
            this.panelClasesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelClasesSubMenu.Controls.Add(this.btnHorarios);
            this.panelClasesSubMenu.Controls.Add(this.btnGestionarClases);
            this.panelClasesSubMenu.Controls.Add(this.btnAgregarClase);
            this.panelClasesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClasesSubMenu.Location = new System.Drawing.Point(0, 270);
            this.panelClasesSubMenu.Name = "panelClasesSubMenu";
            this.panelClasesSubMenu.Size = new System.Drawing.Size(233, 129);
            this.panelClasesSubMenu.TabIndex = 4;
            // 
            // btnHorarios
            // 
            this.btnHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.ForeColor = System.Drawing.Color.Silver;
            this.btnHorarios.Location = new System.Drawing.Point(0, 80);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHorarios.Size = new System.Drawing.Size(233, 40);
            this.btnHorarios.TabIndex = 2;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnGestionarClases
            // 
            this.btnGestionarClases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarClases.FlatAppearance.BorderSize = 0;
            this.btnGestionarClases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnGestionarClases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnGestionarClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarClases.ForeColor = System.Drawing.Color.Silver;
            this.btnGestionarClases.Location = new System.Drawing.Point(0, 40);
            this.btnGestionarClases.Name = "btnGestionarClases";
            this.btnGestionarClases.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGestionarClases.Size = new System.Drawing.Size(233, 40);
            this.btnGestionarClases.TabIndex = 1;
            this.btnGestionarClases.Text = "Gestionar Clases";
            this.btnGestionarClases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarClases.UseVisualStyleBackColor = true;
            this.btnGestionarClases.Click += new System.EventHandler(this.btnGestionarClases_Click);
            // 
            // btnAgregarClase
            // 
            this.btnAgregarClase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarClase.FlatAppearance.BorderSize = 0;
            this.btnAgregarClase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAgregarClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAgregarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClase.ForeColor = System.Drawing.Color.Silver;
            this.btnAgregarClase.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarClase.Name = "btnAgregarClase";
            this.btnAgregarClase.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarClase.Size = new System.Drawing.Size(233, 40);
            this.btnAgregarClase.TabIndex = 0;
            this.btnAgregarClase.Text = "Agregar Clase";
            this.btnAgregarClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarClase.UseVisualStyleBackColor = true;
            this.btnAgregarClase.Click += new System.EventHandler(this.btnAgregarClase_Click);
            // 
            // btnClases
            // 
            this.btnClases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClases.FlatAppearance.BorderSize = 0;
            this.btnClases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnClases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClases.ForeColor = System.Drawing.Color.Silver;
            this.btnClases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClases.Location = new System.Drawing.Point(0, 225);
            this.btnClases.Name = "btnClases";
            this.btnClases.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClases.Size = new System.Drawing.Size(233, 45);
            this.btnClases.TabIndex = 3;
            this.btnClases.Text = "Clases";
            this.btnClases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClases.UseVisualStyleBackColor = true;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // panelUsuarioSubMenu
            // 
            this.panelUsuarioSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelUsuarioSubMenu.Controls.Add(this.btnGestionarUsuarios);
            this.panelUsuarioSubMenu.Controls.Add(this.btnRegistrarUsuario);
            this.panelUsuarioSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarioSubMenu.Location = new System.Drawing.Point(0, 137);
            this.panelUsuarioSubMenu.Name = "panelUsuarioSubMenu";
            this.panelUsuarioSubMenu.Size = new System.Drawing.Size(233, 88);
            this.panelUsuarioSubMenu.TabIndex = 2;
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnGestionarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnGestionarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarUsuarios.ForeColor = System.Drawing.Color.Silver;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 40);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(233, 40);
            this.btnGestionarUsuarios.TabIndex = 1;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.Silver;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(233, 40);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Silver;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 92);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(233, 45);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.AutoScroll = true;
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PanelPrincipal.Controls.Add(this.pictureBoxLogoCentro);
            this.PanelPrincipal.Location = new System.Drawing.Point(250, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(684, 561);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // pictureBoxLogoCentro
            // 
            this.pictureBoxLogoCentro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogoCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogoCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogoCentro.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoCentro.Image")));
            this.pictureBoxLogoCentro.Location = new System.Drawing.Point(106, 83);
            this.pictureBoxLogoCentro.Name = "pictureBoxLogoCentro";
            this.pictureBoxLogoCentro.Size = new System.Drawing.Size(396, 376);
            this.pictureBoxLogoCentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoCentro.TabIndex = 2;
            this.pictureBoxLogoCentro.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.Silver;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 399);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(233, 45);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnvolver_login
            // 
            this.btnvolver_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvolver_login.FlatAppearance.BorderSize = 0;
            this.btnvolver_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnvolver_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnvolver_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver_login.ForeColor = System.Drawing.Color.Silver;
            this.btnvolver_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolver_login.Location = new System.Drawing.Point(0, 554);
            this.btnvolver_login.Name = "btnvolver_login";
            this.btnvolver_login.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnvolver_login.Size = new System.Drawing.Size(233, 67);
            this.btnvolver_login.TabIndex = 10;
            this.btnvolver_login.Text = "Login";
            this.btnvolver_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolver_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvolver_login.UseVisualStyleBackColor = true;
            this.btnvolver_login.Click += new System.EventHandler(this.btnvolver_login_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelReportesSubMenu.ResumeLayout(false);
            this.panelClasesSubMenu.ResumeLayout(false);
            this.panelUsuarioSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCentro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelUsuarioSubMenu;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panelReportesSubMenu;
        private System.Windows.Forms.Panel panelClasesSubMenu;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnGestionarClases;
        private System.Windows.Forms.Button btnAgregarClase;
        private System.Windows.Forms.Button btnClases;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxLogoCentro;
        private System.Windows.Forms.Button btnReporteAsistencias;
        private System.Windows.Forms.Button btnvolver_login;
        private System.Windows.Forms.Button btnReportes;
    }
}

