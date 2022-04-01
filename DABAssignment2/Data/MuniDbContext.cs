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

        //public DbSet<Municipality> Municipalities { get; set; }

        public DbSet<Societies> Societies { get; set; }

        public DbSet<Members> Members { get; set; }

        public DbSet<Chairmen> Chairmens { get; set; }

        public DbSet<Locations> Locations { get; set; }

        public DbSet<Properties> Properties { get; set; }

        public DbSet<Rooms> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Chairmen
            modelBuilder.Entity<Chairmen>().HasKey(c => new { c.CPR_number });

            // Properties
            modelBuilder.Entity<Properties>().HasKey(p => new { p.PropName });

            // LocationHolidays (one to many)
            modelBuilder.Entity<LocationHolidays>().HasKey(lh => new {lh.Holiday, lh.LocationId});

            modelBuilder.Entity<LocationHolidays>()
                .HasOne(lh => lh.Location)
                .WithMany(l => l.Holidays)
                .HasForeignKey(lh => lh.LocationId);

            // LocationOpeningHours (one to many)
            modelBuilder.Entity<LocationOpeningHours>()
                .HasKey(loh => new { loh.Opening, loh.Closing, loh.LocationId });

            modelBuilder.Entity<LocationOpeningHours>()
                .HasOne(loh => loh.Location)
                .WithMany(l => l.OpeningHours)
                .HasForeignKey(loh => loh.LocationId);

            // MembersLocationsReservations (many to many)
            modelBuilder.Entity<MembersLocationsReservations>()
                .HasKey(mlr => new {mlr.LocationId, mlr.ReservationBegin, mlr.ReservationEnd});

            modelBuilder.Entity<MembersLocationsReservations>()
                .HasOne(mlr => mlr.Location)
                .WithMany(l => l.Reservations)
                .HasForeignKey(mlr => mlr.LocationId);
            modelBuilder.Entity<MembersLocationsReservations>()
                .HasOne(mlr => mlr.Member)
                .WithMany(m => m.Reservations)
                .HasForeignKey(mlr => mlr.MemberId);

            // SocietiesMembers (many to many)
            modelBuilder.Entity<SocietiesMembers>()
                .HasOne(sm => sm.Society)
                .WithMany(s => s.SocietiesMembers)
                .HasForeignKey(sm => sm.SocietyId);
            modelBuilder.Entity<SocietiesMembers>()
                .HasOne(sm => sm.Member)
                .WithMany(m => m.SocietiesMembers)
                .HasForeignKey(sm => sm.MemberId);

            // LocationsProperties (many to many)
            modelBuilder.Entity<LocationsProperties>()
                .HasOne(lp => lp.Location)
                .WithMany(l => l.LocationsProperties)
                .HasForeignKey(lp => lp.LocationId);
            modelBuilder.Entity<LocationsProperties>()
                .HasOne(lp => lp.Property)
                .WithMany(p => p.LocationsProperties)
                .HasForeignKey(lp => lp.PropertyId);
        }

    }
}
