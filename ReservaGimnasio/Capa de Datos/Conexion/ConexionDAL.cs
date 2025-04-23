using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaGimnasio.Capa_de_Datos.Conexion
{
    public class ConexionDAL
    {
        private readonly string connectionString = "Server=YOKOHAMABLENDY\\SQLEXPRESS;Database=GymManagerDB;Trusted_Connection=True;";
        private SqlConnection conexion;

        public SqlConnection AbrirConexion()
        {
            if (conexion == null)
                conexion = new SqlConnection(connectionString);

            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
