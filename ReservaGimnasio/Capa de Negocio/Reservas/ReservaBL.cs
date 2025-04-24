using ReservaGimnasio.Capa_de_Datos;
using ReservaGimnasio.Capa_de_Datos.Clases;
using ReservaGimnasio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaGimnasio.Capa_de_Negocio
{
    class ReservaBL
    {
        private ReservaDAL reservaDAL = new ReservaDAL();
        private ClaseDAL claseDAL = new ClaseDAL(); 

        
        
        public bool GuardarReserva(ReservaEnti reserva)
        {
            // 1. Validaciones básicas de la entidad
            if (reserva.IdUsuario == 0)
                throw new ArgumentNullException(nameof(reserva), "La información de la reserva no puede ser nula.");
            if (reserva.IdClase==0)
                throw new Exception("El id del clase es obligatorio.");
            if (reserva.IdClase <= 0)
                throw new Exception("Debe seleccionar una clase válida.");
            if (reserva.FechaClase.Date < DateTime.Today) // Comparar solo la fecha
                throw new Exception("No se puede reservar para una fecha pasada.");
            if (string.IsNullOrWhiteSpace(reserva.Horario))
                throw new Exception("Debe seleccionar un horario.");
            if (reserva.FechaRegistroActual== default(DateTime))
                reserva.FechaRegistroActual = DateTime.Now; // Asignar fecha de creación

            // 2. Validación de Negocio: Verificar Cupo
            int capacidadMaxima = claseDAL.ObtenerCapacidadClase(reserva.IdClase); 
            if (capacidadMaxima <= 0)
            {
              
                throw new Exception($"No se pudo obtener una capacidad válida para la clase seleccionada (ID: {reserva.IdClase}).");
            }

            int reservasActuales = reservaDAL.ContarReservasPorClaseYFechaHora(reserva.IdClase, reserva.FechaClase, reserva.Horario);

            if (reservasActuales >= capacidadMaxima)
            {
                throw new Exception($"No hay cupo disponible para la clase '{reserva.IdClase}' en la fecha y hora seleccionadas ({reserva.FechaClase.ToShortDateString()} {reserva.Horario}). Cupo: {reservasActuales}/{capacidadMaxima}");
            }

           
            bool exito = reservaDAL.GuardarReserva(reserva);
            if (!exito)
            {
               
                throw new Exception("Ocurrió un error al intentar guardar la reserva en la base de datos.");
            }

            return exito; // Devuelve true si se guardó
        }

       
    }
}

