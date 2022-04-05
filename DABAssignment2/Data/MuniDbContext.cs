﻿using DABAssignment2.Models;
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
            modelBuilder.Entity<SocietiesMember>()
                .HasOne(sm => sm.Society)
                .WithMany(s => s.SocietiesMembers)
                .HasForeignKey(sm => sm.SocietyId);
            modelBuilder.Entity<SocietiesMember>()
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


            modelBuilder.Entity<Room>()
                .HasOne(l => l.Location)
                .WithMany(r => r.Rooms)
                .HasForeignKey(l => l.LocationId);



            // seeding data
            modelBuilder.Entity<Properties>().HasData(new Properties
                {
                    PropName = "WiFi"
                }
            );

            modelBuilder.Entity<LocationsProperties>().HasData(new LocationsProperties
            {
                LocationsPropertiesId = 1,
                LocationId = 1,
                PropName = "WiFi",

            });

            modelBuilder.Entity<Society>().HasData(new Society
            {
                SocietyId = 1,
                Activity = "Football",
                CVR_Number = 1234,
                Name = "FootballFc"
            });

            modelBuilder.Entity<Member>().HasData(new Member
            {
                MemberId = 1,
                Name = "Jan",
                PhoneNumber = 12345678,
                Email = "jan@email.com",

            });

            modelBuilder.Entity<SocietiesMember>().HasData(new SocietiesMember
            {
                SocietiesMemberId = 1,
                SocietyId = 1,
                MemberId = 1,

            });


            modelBuilder.Entity<Chairmen>().HasData(new Chairmen
            {
                MemberId = 2,
                Name = "Per",
                PhoneNumber = 87654321,
                Email = "per@email.com",
                HomeAdress = "Gadevej 9",
                CPR_number = "1234567890",

            });

            modelBuilder.Entity<Location>().HasData(new Location
            {
                LocationId = 1,
                Name = "FootballClub",
                Capacity = 300,
                Access_code = 4321,
                Address = "Stivej 3",
                Availability = true,


            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                RoomId = 1,
                LocationId = 1,
                Capacity = 30,
                Access_code = 1234,
                Availability = true,

            });

            modelBuilder.Entity<MembersRoomsReservations>().HasData(new MembersRoomsReservations
            {
                MemberId = 1,
                ReservationBegin = DateTime.Now,
                ReservationEnd = DateTime.Now.AddHours(1),
                RoomId = 1,

            });

            modelBuilder.Entity<MembersLocationsReservations>().HasData(new MembersLocationsReservations
            {
                MemberId = 1,
                ReservationBegin = DateTime.Now,
                ReservationEnd = DateTime.Now.AddHours(1),
                LocationId = 1,

            });

        }

    }
}
