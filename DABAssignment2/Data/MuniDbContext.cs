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

        public DbSet<Society> Societies { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Chairmen> Chairmens { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Properties> Properties { get; set; }

        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Chairmen
            //modelBuilder.Entity<Chairmen>().HasKey(c => new { c.CPR_number });

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

            // RoomHolidays (one to many)
            modelBuilder.Entity<RoomHolidays>().HasKey(lh => new { lh.Holiday, lh.RoomId });

            modelBuilder.Entity<RoomHolidays>()
                .HasOne(lh => lh.Room)
                .WithMany(l => l.Holidays)
                .HasForeignKey(lh => lh.RoomId);

            // RoomOpeningHours (one to many)
            modelBuilder.Entity<RoomOpeningHours>()
                .HasKey(loh => new { loh.Opening, loh.Closing, loh.RoomId });

            modelBuilder.Entity<RoomOpeningHours>()
                .HasOne(loh => loh.Room)
                .WithMany(l => l.OpeningHours)
                .HasForeignKey(loh => loh.RoomId);

            // MembersLocationsReservations (many to many)
            modelBuilder.Entity<MembersLocationsReservations>()
                .HasKey(mlr => new {mlr.LocationId, mlr.ReservationBegin, mlr.ReservationEnd});

            modelBuilder.Entity<MembersLocationsReservations>()
                .HasOne(mlr => mlr.Location)
                .WithMany(l => l.Reservations)
                .HasForeignKey(mlr => mlr.LocationId);
            modelBuilder.Entity<MembersLocationsReservations>()
                .HasOne(mlr => mlr.Member)
                .WithMany(m => m.LocationsReservations)
                .HasForeignKey(mlr => mlr.MemberId);

            // MembersRoomsReservations (many to many)
            modelBuilder.Entity<MembersRoomsReservations>()
                .HasKey(mlr => new { mlr.RoomId, mlr.ReservationBegin, mlr.ReservationEnd });

            modelBuilder.Entity<MembersRoomsReservations>()
                .HasOne(mlr => mlr.Room)
                .WithMany(l => l.Reservations)
                .HasForeignKey(mlr => mlr.RoomId);
            modelBuilder.Entity<MembersRoomsReservations>()
                .HasOne(mlr => mlr.Member)
                .WithMany(m => m.RoomsReservations)
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
                .HasForeignKey(lp => lp.PropName);


            //modelBuilder.Entity<Society>().HasData(new Society { SocietyId = }) 
        }

    }
}
