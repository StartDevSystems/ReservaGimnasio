using ReservaGimnasio.Capa_Presentación.Frm_de_Usuarios;
using ReservaGimnasio.Capa_Presentación.Frm_Reservas;
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
    public partial class Principal_Cliente : Form
    {
        public Principal_Cliente(int idUsuarioLogueado)
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelUsuarioSubMenu.Visible = false;
            panelClasesSubMenu.Visible = false;
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
            openChildForm(new Reservas_Client());
           
            
            hideSubMenu();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Gestion_Usuarios());
           
            
            hideSubMenu();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
           
            
            hideSubMenu();
        }


        /////////////////////////////**//////*/*/*/*///////*/*/*//*****//////*/*/*/*/*/*
      


        private void btnClases_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClasesSubMenu);
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
           
            
            hideSubMenu();
        }

        private void btnGestionarClases_Click(object sender, EventArgs e)
        {
           
            
            hideSubMenu();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }


     /////////////////////////////**//////*/*/*/*///////*/*/*//*****//////*/*/*/*/*/*

        private void btnReportes_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReporteAsistencias_Click(object sender, EventArgs e)
        {

        }

        private void btnReportePagos_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

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

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }
    }
}
