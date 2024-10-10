using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Room
    {
        public int IdRoom { get; set; }
        public string Type { get; set; }
        public decimal PriceNight { get; set; }
        public string Characteristic { get; set; }
    }
}
