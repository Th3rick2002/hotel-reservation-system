using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Reservation
    {
        public int idReservation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IdRoom { get; set; }
        public int IdUser { get; set; }
        public Decimal Price { get; set; }
        public string State { get; set; }
    }
}
