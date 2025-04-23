using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservaGimnasio.Capa_de_Negocio; 

namespace ReservaGimnasio.Capa_Presentación.Frm_de_Usuarios
{
    public partial class Gestion_Usuarios : Form
    {
        private UsuariosBL usuariosBL = new UsuariosBL(); 

        public Gestion_Usuarios()
        {
            InitializeComponent();
        }

        private void Gestion_Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios(); 
        }

        private void CargarUsuarios()
        {
            DataTable datos = usuariosBL.MostrarTodosLosUsuarios();
            dataGridListaUsuarios.DataSource = datos;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }




        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridListaUsuarios.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridListaUsuarios.SelectedRows[0].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    UsuariosBL usuariosBL = new UsuariosBL();
                    bool eliminado = usuariosBL.EliminarUsuario(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios(); 
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable resultado = usuariosBL.BuscarUsuarioPorNombre(nombre); 

            if (resultado.Rows.Count > 0)
            {
                dataGridListaUsuarios.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
    
}
