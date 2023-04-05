using Microsoft.EntityFrameworkCore;

namespace Airport_kurs.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Airlines> Airlines { get; set; }
        public DbSet<Airplanes> Airplanes { get; set; }
        public DbSet<Countries> Aountries { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
}
