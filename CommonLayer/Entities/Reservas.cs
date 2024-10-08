using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Reservas
    {
        public int IdReserva { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public int idHabitacion { get; set; }
        public int idUsuario { get; set; }
        public bool Estado {  get; set; }
    }
}
