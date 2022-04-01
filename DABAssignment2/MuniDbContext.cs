using DABAssignment2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2
{
    public class MuniDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "TrustServerCertificate=true; Data Source=localhost; Initial Catalog=Muni; Persist Security Info=True; User ID=sa;Password=<YourStrong@Passw0rd>;");
        }

        public DbSet<Municipality> Municipalities { get; set; }

        public DbSet<Society> Societies { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Chairmen> Chairmens { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<Room> Rooms { get; set; }


    }
}
