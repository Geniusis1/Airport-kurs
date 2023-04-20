using Airport_kurs.Attr;

namespace Airport_kurs.Models
{
    public class Airplane
    {
        public int Id { get; set; }
        
        public int AirlineId { get; set; }
        [SkipProperty]
        public Airline Airline { get; set; }

        public string Type { get; set; }
    }
}
