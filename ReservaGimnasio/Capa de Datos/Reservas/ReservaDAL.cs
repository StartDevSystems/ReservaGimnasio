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

        /// <summary>
        /// Guarda una nueva reserva en la base de datos.
        /// </summary>
        /// <param name="reserva">El objeto ReservaEnti con los datos a guardar.</param>
        /// <returns>True si se guardó correctamente, False en caso contrario.</returns>
        public bool GuardarReserva(ReservaEnti reserva)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    // Asumiendo que tienes un Stored Procedure llamado sp_InsertarReserva
                    // Si no, puedes usar un INSERT INTO directo, pero SP es más seguro y organizado.
                    using (SqlCommand cmd = new SqlCommand("usp_RegistrarReservaClase", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Asegúrate que los nombres de parámetros coincidan con tu SP
                        cmd.Parameters.AddWithValue("@IdUsuario", reserva.IdUsuario);
                        cmd.Parameters.AddWithValue("@IdClase", reserva.IdClase);
                        cmd.Parameters.AddWithValue("@FechaClase", reserva.FechaClase); // Guarda solo la fecha
                        cmd.Parameters.AddWithValue("@Horario", reserva.Horario);
                        cmd.Parameters.AddWithValue("@NombreLugarSala", reserva.NombreLugarSala);
                        cmd.ExecuteNonQuery();
                        return true; // Se ejecutó sin errores
                    }
                }
            }
            catch (SqlException ex) // Captura errores específicos de SQL
            {
                MessageBox.Show($"Error de base de datos al guardar reserva: {ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex) // Captura cualquier otro error
            {
                MessageBox.Show($"Error inesperado al guardar reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Asegurarse de cerrar la conexión si no se usó 'using' para la conexión
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Cuenta cuántas reservas existen para una clase, fecha y hora específicas.
        /// </summary>
        /// <param name="idClase">ID de la clase.</param>
        /// <param name="fecha">Fecha de la reserva.</param>
        /// <param name="hora">Hora de la reserva.</param>
        /// <returns>El número de reservas encontradas.</returns>
        public int ContarReservasPorClaseYFechaHora(int idClase, DateTime fecha, string hora)
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    // Consulta para contar reservas activas (puedes ajustar el criterio de Estado)
                    string query = "SELECT COUNT(*) FROM Reservas WHERE IdClase = @IdClase AND FechaReserva = @FechaReserva AND HoraReserva = @HoraReserva AND Estado = 'Activa'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdClase", idClase);
                        cmd.Parameters.AddWithValue("@FechaReserva", fecha.Date); // Comparar solo la fecha
                        cmd.Parameters.AddWithValue("@HoraReserva", hora);

                        object result = cmd.ExecuteScalar(); // ExecuteScalar es eficiente para obtener un solo valor
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
                // En caso de error, podrías devolver -1 o lanzar la excepción para manejarla arriba
                throw; // Relanzar la excepción para que la capa de negocio la maneje
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return count;
        }
    }
}
