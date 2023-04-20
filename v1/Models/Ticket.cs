using Airport_kurs.Attr;

namespace Airport_kurs.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int FlightId { get; set; }
        [SkipProperty]
        public Flight Flight { get; set; }
        
        public int AirplaneId { get; set; }
        [SkipProperty]
        public Airplane Airplane { get; set; }
        
        public int AirlineId { get; set; }
        [SkipProperty]
        public Airline Airline { get; set; }

        public string Class { get; set; }
        public float Cost { get; set; }
    }
}
