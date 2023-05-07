namespace Airport_kurs.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        
        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; }
        
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }

        public string Class { get; set; }
        public float Cost { get; set; }
    }
}
