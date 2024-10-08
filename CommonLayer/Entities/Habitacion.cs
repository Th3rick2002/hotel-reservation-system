using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Habitacion
    {
        public int IdHabitacion {  get; set; }
        public string Tipo { get; set; }
        public decimal PrecioNoche { get; set; }
        public string Caracteristicas { get; set; }
    }
}
