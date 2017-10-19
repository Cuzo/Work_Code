using CarApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class CarContext : DbContext
    {
        //This class creates the database properties from the models in the code. This means that we are going
        //to use a code first approach to write the application.
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
        }
    }
}