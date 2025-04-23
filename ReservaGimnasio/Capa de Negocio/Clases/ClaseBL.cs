using ReservaGimnasio.Capa_de_Datos.Clases;
using ReservaGimnasio.Capa_de_Datos.Conexion;
using ReservaGimnasio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaGimnasio.Capa_de_Negocio
{
    class ClaseBL
    {
        private ClaseDAL claseDAL = new ClaseDAL();

        public bool GuardarClase(ClaseEnti clase)
        {
            // Validaciones de negocio (las que ya tenías)
            if (string.IsNullOrEmpty(clase.Nombre))
                throw new Exception("El nombre de la clase es obligatorio");

            if (string.IsNullOrEmpty(clase.Entrenador))
                throw new Exception("Debe seleccionar un entrenador");

            if (clase.CapacidadMaxima <= 0)
                throw new Exception("La capacidad máxima debe ser mayor a cero");

            if (clase.Duracion <= 0)
                throw new Exception("La duración debe ser mayor a cero");

            if (string.IsNullOrEmpty(clase.Salon))
                throw new Exception("Debe seleccionar un salón o área");

            if (clase.FechaInicio > clase.FechaFin)
                throw new Exception("La fecha de inicio no puede ser posterior a la fecha final");

            if (clase.Dias == null || clase.Dias.Count == 0)
                throw new Exception("Debe seleccionar al menos un día de la semana");

            // Si pasa todas las validaciones, guardar la clase
            return claseDAL.GuardarClase(clase);
        }

        public DataTable MostrarTodasClases()
        {
            return claseDAL.MostrarTodasClases();
        }

        public DataTable BuscarPorNombre(string nombre)
        {
            return claseDAL.BuscarPorNombre(nombre);
        }

        public bool ModificarClase(int id, ClaseEnti clase)
        {
            // Las mismas validaciones que en GuardarClase (las que ya tenías)
            if (string.IsNullOrEmpty(clase.Nombre))
                throw new Exception("El nombre de la clase es obligatorio");

            if (string.IsNullOrEmpty(clase.Entrenador))
                throw new Exception("Debe seleccionar un entrenador");

            if (clase.CapacidadMaxima <= 0)
                throw new Exception("La capacidad máxima debe ser mayor a cero");

            if (clase.Duracion <= 0)
                throw new Exception("La duración debe ser mayor a cero");

            if (string.IsNullOrEmpty(clase.Salon))
                throw new Exception("Debe seleccionar un salón o área");

            if (clase.FechaInicio > clase.FechaFin)
                throw new Exception("La fecha de inicio no puede ser posterior a la fecha final");

            if (clase.Dias == null || clase.Dias.Count == 0)
                throw new Exception("Debe seleccionar al menos un día de la semana");

            return claseDAL.ModificarClase(id, clase);
        }

        public bool EliminarClase(int id)
        {
            return claseDAL.EliminarClase(id);
        }
    }
}