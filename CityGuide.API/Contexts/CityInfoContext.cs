using CityGuide.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityGuide.API.Contexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<PointOfInterest> PointsOfInterests { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
