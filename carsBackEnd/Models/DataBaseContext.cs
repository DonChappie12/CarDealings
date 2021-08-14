using Microsoft.EntityFrameworkCore;

namespace carsBackEnd.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Car> car { get; set; }
        public DbSet<Engine> engine { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
    }
}