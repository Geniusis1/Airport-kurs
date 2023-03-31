using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_kurs.Models
{
    public class Tickets
    {
        public int Id { get; set; }

        public int FlightId { get; set; }
        public Flights Flight { get; set; }
        
        public int AirplaneId { get; set; }
        public Airplanes Airplane { get; set; }
        
        public int AirlineId { get; set; }
        public Airlines Airline { get; set; }

        public string Class { get; set; }
        public float Cost { get; set; }
    }
}
