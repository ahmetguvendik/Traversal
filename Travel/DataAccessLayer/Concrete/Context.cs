using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=//; database=TravelDb;Integrated Security=true;");
        }

         public DbSet<About> Abouts { get; set; }
         public DbSet<AboutCity> AboutCities { get; set; }
         public DbSet<CustomerComment> CustomerComments { get; set; }
         public DbSet<Destination> Destinations { get; set; }
         public DbSet<Guide> Guides { get; set; }
         public DbSet<PopulerDestination> PopulerDestinations { get; set; }
         public DbSet<PopulerPlace> PopulerPlaces { get; set; }
    }
}

