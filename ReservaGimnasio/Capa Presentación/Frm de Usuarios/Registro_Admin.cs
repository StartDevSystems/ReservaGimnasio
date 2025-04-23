using ReservaGimnasio.Capa_de_Negocio;
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

namespace ReservaGimnasio.Capa_Presentación.Frm_de_Usuarios
{
    public partial class Regristro_Admin : Form
    {
        public Regristro_Admin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Regristro_Admin_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Cliente");
            cmbRol.Items.Add("Entrenador");
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

                if (resultado == true)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Limpiar los campos del formulario
                    txtNombre.Clear();
                    txtCorreo.Clear();
                    txtContraseña.Clear();
                    cmbRol.SelectedIndex = -1;
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
    }
}
