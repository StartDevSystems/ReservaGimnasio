using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ReservaGimnasio.Capa_de_Datos.Conexion;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using ReservaGimnasio.Entidades;

namespace ReservaGimnasio.Capa_de_Datos.Conexion
{
    public class UsuarioDAL
    {
        public DataTable ValidarLogin(string correo, string contraseña)
        {
            ConexionDAL con = new ConexionDAL();
            using (SqlCommand cmd = new SqlCommand("sp_ValidarLogin", con.AbrirConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                con.CerrarConexion();
                return dt;
            }


        }


        //*///////////////////*///////////////////**********//////////****************////////*********

        public bool RegistrarUsuario(string nombre, string correo, string contraseña, string rol)
        {
            try
            {
                ConexionDAL con = new ConexionDAL();
                using (SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    cmd.ExecuteNonQuery();
                    con.CerrarConexion();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en RegistrarUsuario: " + ex.Message);
                return false;
            }
        }
        //*///////////////////*///////////////////**********//////////****************////////*********
        public DataTable BuscarPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                ConexionDAL con = new ConexionDAL();
                SqlConnection conn = con.AbrirConexion(); // Abrimos la conexión

                string query = "SELECT * FROM Usuarios WHERE Nombre LIKE @Nombre";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                con.CerrarConexion(); // Cerramos después de todo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }


        public DataTable MostrarTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                ConexionDAL con = new ConexionDAL();
                SqlConnection conn = con.AbrirConexion(); // Abre conexión manualmente

                string query = "SELECT * FROM Usuarios";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                con.CerrarConexion(); // La cierra después de todo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }



        public bool ModificarUsuario(int id, string nombre, string correo, string contraseña, string rol)
        {
            try
            {
                ConexionDAL con = new ConexionDAL();
                using (SqlCommand cmd = new SqlCommand("sp_EditarUsuario", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    cmd.ExecuteNonQuery();
                    con.CerrarConexion();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
                return false;
            }
        }





        public bool EliminarUsuario(int id)
        {
            try
            {
                ConexionDAL con = new ConexionDAL();
                using (SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    con.CerrarConexion();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                return false;
            }
        }





        ////////////////////////////////////////////////////////////////////////////////////////////////////

        











    }
}


