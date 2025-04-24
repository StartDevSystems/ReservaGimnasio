using ReservaGimnasio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservaGimnasio.Capa_de_Datos.Conexion;

namespace ReservaGimnasio.Capa_de_Datos.Clases
{
    class ClaseDAL
    {
        public bool GuardarClase(ClaseEnti clase)
        {
            try
            {
                ConexionDAL con = new ConexionDAL();
                using (SqlCommand cmd = new SqlCommand("sp_InsertarClase", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Convertir la lista de días a una cadena separada por comas
                    string diasString = string.Join(",", clase.Dias);

                    cmd.Parameters.AddWithValue("@Nombre", clase.Nombre);
                    cmd.Parameters.AddWithValue("@Entrenador", clase.Entrenador);
                    cmd.Parameters.AddWithValue("@CapacidadMaxima", clase.CapacidadMaxima);
                    cmd.Parameters.AddWithValue("@Duracion", clase.Duracion);
                    cmd.Parameters.AddWithValue("@Salon", clase.Salon);
                    cmd.Parameters.AddWithValue("@FechaInicio", clase.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", clase.FechaFin);
                    cmd.Parameters.AddWithValue("@Dias", diasString);
                    cmd.Parameters.AddWithValue("@Recurrencia", clase.Recurrencia);

                    cmd.ExecuteNonQuery();
                    con.CerrarConexion();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la clase: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable FiltrarClasePorDia_Entrenador_Salon(string _dia, string _nombreEntrenador, string _salon)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexionDAL con = new ConexionDAL();

                using (SqlCommand cmd = new SqlCommand("FiltrarClasesD_E_S", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Dias", _dia);
                    cmd.Parameters.AddWithValue("@Entrenador", _nombreEntrenador);
                    cmd.Parameters.AddWithValue("@Salon", _salon);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt); // Llena el DataTable con los datos
                    }
                }

                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        public DataTable MostrarTodasClases()
        {
            DataTable dt = new DataTable();
            try
            {
                ConexionDAL con = new ConexionDAL();
                SqlConnection conn = con.AbrirConexion();

                string query = "SELECT * FROM Clases";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clases: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable BuscarPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                ConexionDAL con = new ConexionDAL();
                SqlConnection conn = con.AbrirConexion();

                string query = "SELECT * FROM Clases WHERE Nombre LIKE @Nombre";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clase: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public bool ModificarClase(int id, ClaseEnti clase)
        {
            try
            {
                ConexionDAL con = new ConexionDAL();
                using (SqlCommand cmd = new SqlCommand("sp_ModificarClase", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    string diasString = string.Join(",", clase.Dias);

                    cmd.Parameters.AddWithValue("@idClase", id);
                    cmd.Parameters.AddWithValue("@Nombre", clase.Nombre);
                    cmd.Parameters.AddWithValue("@Entrenador", clase.Entrenador);
                    cmd.Parameters.AddWithValue("@CapacidadMaxima", clase.CapacidadMaxima);
                    cmd.Parameters.AddWithValue("@Duracion", clase.Duracion);
                    cmd.Parameters.AddWithValue("@Salon", clase.Salon);
                    cmd.Parameters.AddWithValue("@FechaInicio", clase.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", clase.FechaFin);
                    cmd.Parameters.AddWithValue("@Dias", diasString);
                    cmd.Parameters.AddWithValue("@Recurrencia", clase.Recurrencia);

                    cmd.ExecuteNonQuery();
                    con.CerrarConexion();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la clase: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarClase(int id)
        {
            try
            {
                ConexionDAL con = new ConexionDAL();
                using (SqlCommand cmd = new SqlCommand("sp_EliminarClase", con.AbrirConexion()))
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
                MessageBox.Show("Error al eliminar la clase: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }





        public int ObtenerCapacidadClase(int idClase)
        {
            int capacidad = 0;
            try
            {
                ConexionDAL con = new ConexionDAL();
                using (SqlConnection conn = con.AbrirConexion())
                {
                    string query = "SELECT CapacidadMaxima FROM Clases WHERE idClase = @idClase";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idClase", idClase);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            capacidad = Convert.ToInt32(result);
                        }
                    }
                }
                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener capacidad de la clase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Manejar error apropiadamente
            }
            return capacidad;
        }










    }
}
