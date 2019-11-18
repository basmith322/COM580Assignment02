using COM580Assignment02.Models;
using Microsoft.EntityFrameworkCore;

namespace COM580Assignment02.Repository
{
    public class AnimalDBContext : DbContext
    {
        public AnimalDBContext()
        {
        }

        public AnimalDBContext(DbContextOptions<AnimalDBContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AnimalsDB;Trusted_Connection=True;");
        }
        public void Initialise()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
