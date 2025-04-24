using ReservaGimnasio.Capa_de_Datos.Conexion;
using ReservaGimnasio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaGimnasio.Capa_de_Datos
{
    class ReservaDAL
    {
        private ConexionDAL conexion = new ConexionDAL();

        
        
        
       
        public bool GuardarReserva(ReservaEnti reserva)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    
                    using (SqlCommand cmd = new SqlCommand("usp_RegistrarReservaClase", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        cmd.Parameters.AddWithValue("@IdUsuario", reserva.IdUsuario);
                        cmd.Parameters.AddWithValue("@IdClase", reserva.IdClase);
                        cmd.Parameters.AddWithValue("@FechaClase", reserva.FechaClase); 
                        cmd.Parameters.AddWithValue("@Horario", reserva.Horario);
                        cmd.Parameters.AddWithValue("@NombreLugarSala", reserva.NombreLugarSala);
                        cmd.ExecuteNonQuery();
                        return true; 
                    }
                }
            }
            catch (SqlException ex) 
            {
                MessageBox.Show($"Error de base de datos al guardar reserva: {ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error inesperado al guardar reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                
                conexion.CerrarConexion();
            }
        }

       
        
        public int ContarReservasPorClaseYFechaHora(int idClase, DateTime fecha, string hora)
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    
                    string query = "SELECT COUNT(*) FROM Reservas WHERE IdClase = @IdClase AND FechaReserva = @FechaReserva AND HoraReserva = @HoraReserva AND Estado = 'Activa'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdClase", idClase);
                        cmd.Parameters.AddWithValue("@FechaReserva", fecha.Date); 
                        cmd.Parameters.AddWithValue("@HoraReserva", hora);

                        object result = cmd.ExecuteScalar(); 
                        if (result != null && result != DBNull.Value)
                        {
                            count = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al contar reservas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                throw; 
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return count;
        }
    }
}
