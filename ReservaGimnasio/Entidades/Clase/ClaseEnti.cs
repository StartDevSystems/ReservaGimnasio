using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaGimnasio.Entidades
{
    class ClaseEnti
    {
        
            public int IdClase { get; set; }
            public string Nombre { get; set; }
            public string Entrenador { get; set; } // Añadir esta propiedad
            public int CapacidadMaxima { get; set; }
            public int Duracion { get; set; }
            public string Salon { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public List<string> Dias { get; set; }
            public string Recurrencia { get; set; }
        
    }
}
