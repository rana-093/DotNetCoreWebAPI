using DotNetCoreWebAPI.entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebAPI.DbContexts
{
    public class CityContext: DbContext
    {
        public DbSet<City> cities { get; set; }

        public DbSet<PointOfInterest> pointsOfInterests { get;set; }

        public CityContext(DbContextOptions<CityContext> options) : base(options) { 
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
            new City(){
                Id = 1,
                Name = "Dhaka",
                description = "Oldest city in BD"
            }, new City()
            {
                Id = 2,
                Name = "Ctg",
                description = "Port City"
            }, new City()
            {
                Id = 3,
                Name = "Sylhet",
                description = "Peaceful city ever"
            });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest() { Id = 1, cityId = 1, Name = "Khilkhet" },
                new PointOfInterest() { Id = 2, cityId = 1, Name = "Uttara"},
                new PointOfInterest() { Id = 3, cityId = 2, Name = "Halisohor"},
                new PointOfInterest() { Id = 4, cityId = 3, Name = "Hobigonj"});

            base.OnModelCreating(modelBuilder);
        }
    }
}
