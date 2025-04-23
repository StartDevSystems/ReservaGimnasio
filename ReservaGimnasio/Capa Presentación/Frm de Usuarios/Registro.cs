using ReservaGimnasio.Capa_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaGimnasio.Capa_Presentación.Frm_de_Usuarios
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void Regristro_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Cliente");
            cmbRol.Items.Add("Entrenador");
     
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            this.Close();
            formLogin.Show();
        }

        private void btnRegristrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Va a Obtener valores del formulario
                string nombre = txtNombre.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string contraseña = txtContraseña.Text;
                string rol = cmbRol.SelectedItem?.ToString() ?? string.Empty;

                // Va a Crear instancia de la capa de negocio
                UsuariosBL usuariosBL = new UsuariosBL();

                // Va a Intentar registrar el usuario
                bool resultado = usuariosBL.RegistrarUsuario(nombre, correo, contraseña, rol);

                if (resultado== true)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Me va a Crear y mostrar formulario de login
                    Login formLogin = new Login();
                    this.Hide();
                    formLogin.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                // Aqui me validación Errores
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Otros errores también
                MessageBox.Show("Error al registrar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void Regristro_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void Regristro_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    
}
