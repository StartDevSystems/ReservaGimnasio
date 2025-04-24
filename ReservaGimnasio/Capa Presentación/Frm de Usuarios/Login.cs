using Principal;
using ReservaGimnasio.Capa_de_Negocio;
using ReservaGimnasio.Capa_Presentación;
using ReservaGimnasio.Capa_Presentación.Frm_de_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaGimnasio
{
    public partial class Login : Form
    {
        public MessageBoxIcon Warning { get; private set; }

        public Login()
        {
            InitializeComponent();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (textCorreo.Text == "CORREO")
            {
                textCorreo.Text = "";
                textCorreo.ForeColor = Color.LightGray;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Text == "")
            
            {
                textCorreo.Text = "CORREO";
                textCorreo.ForeColor = Color.DimGray;
            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Contraseña")
            {
                textContraseña.Text = "";
                textContraseña.ForeColor = Color.LightGray;
                textContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (textContraseña.Text == "")
            {
                textContraseña.Text = "Contraseña";
                textContraseña.ForeColor= Color.DimGray;
                textContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string correo = textCorreo.Text;
            string contraseña = textContraseña.Text;

            
            if (correo == "CORREO" || contraseña == "Contraseña")
            {
                MessageBox.Show("Por favor, ingrese su correo y contraseña.", "Datos Faltantes", MessageBoxButtons.OK, Warning);
                return;
            }


            UsuariosBL usuarioBL = new UsuariosBL();
            DataTable dt = null; 

            try 
            {
                dt = usuarioBL.ValidarLogin(correo, contraseña);
            }
            catch (ArgumentException aex) 
            {
                MessageBox.Show(aex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ocurrió un error al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }


            if (dt != null && dt.Rows.Count > 0) 
            {
                //MessageBox.Show("Bienvenido!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information); // Puedes quitarlo si la redirección es suficiente

                DataRow userData = dt.Rows[0]; // Obtener la fila de datos del usuario

                // --- ¡AQUÍ LA MODIFICACIÓN CLAVE! ---
                // Obtener el rol y el ID del usuario
                string rolUsuario = userData["Rol"].ToString();
                // Asegúrate que tu SP 'sp_ValidarLogin' devuelve una columna llamada EXACTAMENTE 'IdUsuario'
                int idUsuarioLogueado = Convert.ToInt32(userData["IdUsuario"]);

                // Redirigir según el rol
                if (rolUsuario.ToLower() == "cliente")
                {
                    // --- PASAR EL ID AL CONSTRUCTOR DE Principal_Cliente ---
                    Principal_Cliente formClient = new Principal_Cliente(idUsuarioLogueado); // <-- Pasar ID
                    this.Hide();
                    formClient.ShowDialog(); 
                    this.Close(); 
                }
                else 
                {
                  
                    Principal.Principal principal = new Principal.Principal(idUsuarioLogueado); // <-- Pasar ID (si lo necesita)
                    this.Hide();
                    principal.ShowDialog(); 
                    this.Close(); 
                }
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textContraseña.Clear(); 
                textContraseña.Text = "Contraseña"; 
                textContraseña.ForeColor = Color.DimGray;
                textContraseña.UseSystemPasswordChar = false;
                textCorreo.Focus();
            }
        }

        private void linkRegristrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro formRegristro = new Registro();

            this.Hide();

            formRegristro.ShowDialog();
            this.Show();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}









