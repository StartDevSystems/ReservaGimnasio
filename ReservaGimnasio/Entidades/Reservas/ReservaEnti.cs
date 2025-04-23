using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaGimnasio.Entidades
{
    class ReservaEnti
    {
        public int IdReserva { get; set; } // Autoincremental en BD

        public int IdUsuario { get; set; } // O IdCliente (int) si tienes tabla de clientes
        public int IdClase { get; set; }
        public DateTime FechaClase { get; set; }
        public string Horario { get; set; } // O DateTime si combinas fecha y hora
        public string NombreLugarSala{ get; set; } // Ej: "Activa", "Cancelada", "Completada"
        public DateTime FechaRegistroActual { get; set; }

    }
}
