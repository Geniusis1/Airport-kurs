using Airport_kurs.Attr;
using System;

namespace Airport_kurs.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public int InCountryId { get; set; }
        [SkipProperty]
        public Countrie InCountry { get; set; }

        public int ToCountryId { get; set; }
        [SkipProperty]
        public Countrie ToCountry { get; set; }

        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTimeSchedule { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int MaxPeople { get; set; }
        public int People { get; set; }
    }
}
