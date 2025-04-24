using ReservaGimnasio;
using ReservaGimnasio.Capa_Presentación;
using ReservaGimnasio.Capa_Presentación.Frm_Administración;
using ReservaGimnasio.Capa_Presentación.Frm_de_Usuarios;
using ReservaGimnasio.Capa_Presentación.Frm_Reporte_y_Estadistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : Form
    {
        public Principal(int idUsuarioLogueado)
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelUsuarioSubMenu.Visible = false;
            panelClasesSubMenu.Visible = false;
            panelReportesSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        /////////////////////////////**//////*/*/*/*///////*/*/*//*/*******************/*/*/
        

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsuarioSubMenu);
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new Regristro_Admin());
            //your codes
            //..
            hideSubMenu();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Gestion_Usuarios());
            //your codes
            //..
            hideSubMenu();
        }


        /////////////////////////////**//////*/*/*/*///////*/*/*//*****//////*/*/*/*/*/*
      


        private void btnClases_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClasesSubMenu);
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarClases());
            //your codes
            //..
            hideSubMenu();
        }

        private void btnGestionarClases_Click(object sender, EventArgs e)
        {
            openChildForm(new Gestionar_Clases());
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Horario_Clases());
            //your codes
            //..
            hideSubMenu();
        }


     /////////////////////////////**//////*/*/*/*///////*/*/*//*****//////*/*/*/*/*/*

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportesSubMenu);
        }

        private void btnReporteAsistencias_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Asistencia());
        }

        private void btnReportePagos_Click(object sender, EventArgs e)
        {
            openChildForm(new Reporte_Pagos());
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            openChildForm(new Estadistica());
        }

        /////////////////////////////**//////*/*/*/*///////*/*/*//*****//////*/*/*/*/*/*


        private void btnReservas_Click(object sender, EventArgs e)
        {
        }

        /////////////////////////////**//////*/*/*/*///////*/*/*//*****//////*/*/*/*/*/*

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(childForm);
            PanelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnvolver_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
           this.Close();
        }
    }
}
