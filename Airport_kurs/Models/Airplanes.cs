using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_kurs.Models
{
    public class Airplanes
    {
        public int Id { get; set; }
        
        public int AirlineId { get; set; }
        public Airlines Airline { get; set; }

        public string Type { get; set; }
    }
}
