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
        private ClaseDAL claseDAL = new ClaseDAL(); // Necesitamos esto para obtener la capacidad

        /// <summary>
        /// Valida y guarda una reserva.
        /// </summary>
        /// <param name="reserva">La reserva a guardar.</param>
        /// <returns>True si la reserva se guardó con éxito.</returns>
        /// <exception cref="Exception">Lanza excepciones con mensajes de validación o error.</exception>
        public bool GuardarReserva(ReservaEnti reserva)
        {
            // 1. Validaciones básicas de la entidad
            if (reserva == null)
                throw new ArgumentNullException(nameof(reserva), "La información de la reserva no puede ser nula.");
            if (string.IsNullOrWhiteSpace(reserva.NombreCliente))
                throw new Exception("El nombre del cliente es obligatorio.");
            if (reserva.IdClase <= 0)
                throw new Exception("Debe seleccionar una clase válida.");
            if (reserva.FechaReserva.Date < DateTime.Today) // Comparar solo la fecha
                throw new Exception("No se puede reservar para una fecha pasada.");
            if (string.IsNullOrWhiteSpace(reserva.HoraReserva))
                throw new Exception("Debe seleccionar un horario.");
            if (string.IsNullOrWhiteSpace(reserva.Estado))
                reserva.Estado = "Activa"; // Asignar estado por defecto si no viene
            if (reserva.FechaHoraCreacion == default(DateTime))
                reserva.FechaHoraCreacion = DateTime.Now; // Asignar fecha de creación

            // 2. Validación de Negocio: Verificar Cupo
            int capacidadMaxima = claseDAL.ObtenerCapacidadClase(reserva.IdClase); // ¡ASEGÚRATE QUE ESTE MÉTODO EXISTA EN ClaseDAL!
            if (capacidadMaxima <= 0)
            {
                // Podría ser un error de configuración de la clase, o clase no encontrada
                throw new Exception($"No se pudo obtener una capacidad válida para la clase seleccionada (ID: {reserva.IdClase}).");
            }

            int reservasActuales = reservaDAL.ContarReservasPorClaseYFechaHora(reserva.IdClase, reserva.FechaReserva, reserva.HoraReserva);

            if (reservasActuales >= capacidadMaxima)
            {
                throw new Exception($"No hay cupo disponible para la clase '{reserva.IdClase}' en la fecha y hora seleccionadas ({reserva.FechaReserva.ToShortDateString()} {reserva.HoraReserva}). Cupo: {reservasActuales}/{capacidadMaxima}");
            }

            // 3. (Opcional) Validación adicional: ¿Cliente ya tiene reserva a esa hora?
            // bool clienteYaReservado = reservaDAL.VerificarReservaCliente(reserva.NombreCliente, reserva.FechaReserva, reserva.HoraReserva);
            // if (clienteYaReservado)
            // {
            //     throw new Exception($"El cliente '{reserva.NombreCliente}' ya tiene una reserva para esa fecha y hora.");
            // }


            // 4. Si todo está bien, intentar guardar
            bool exito = reservaDAL.GuardarReserva(reserva);
            if (!exito)
            {
                // El DAL ya debería haber mostrado un MessageBox, pero podemos lanzar excepción si preferimos manejarlo en la UI
                throw new Exception("Ocurrió un error al intentar guardar la reserva en la base de datos.");
            }

            return exito; // Devuelve true si se guardó
        }

        // Podrías añadir más métodos aquí: CancelarReserva, ModificarReserva, ListarReservasCliente, etc.
    }
}

