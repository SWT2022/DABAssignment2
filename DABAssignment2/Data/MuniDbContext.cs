using DABAssignment2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DABAssignment2
{
    public class MuniDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=DAB_Assignment2;Persist Security Info=True;User ID=SA;Password=Docker_Jacob#7953;TrustServerCertificate=True");
        }

        //public DbSet<Municipality> Municipalities { get; set; }

        public DbSet<Society> Societies { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Chairmen> Chairmens { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Properties> Properties { get; set; }

        public DbSet<Room> Rooms { get; set; }

        //public DbSet<SocietiesMember> SocietiesMember { get; set; }

        public DbSet<MembersLocationsReservations> MembersLocationsReservations { get; set; }

        public DbSet<MembersRoomsReservations> MembersRoomsReservations { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Society
            modelBuilder.Entity<Society>().HasIndex(s => new { s.CVR_Number })
                .IsUnique();

            #region Relationships
            // Properties
            modelBuilder.Entity<Properties>().HasKey(p => new { p.PropName });

            // RoomHolidays (one to many)
            modelBuilder.Entity<RoomHolidays>().HasKey(lh => new { lh.Holiday, lh.RoomId });

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

            //// SocietiesMembers (many to many)
            //modelBuilder.Entity<SocietiesMember>()
            //    .HasOne(sm => sm.Society)
            //    .WithMany(s => s.SocietiesMembers)
            //    .HasForeignKey(sm => sm.SocietyId);
            //modelBuilder.Entity<SocietiesMember>()
            //    .HasOne(sm => sm.Member)
            //    .WithMany(m => m.SocietiesMembers)
            //    .HasForeignKey(sm => sm.MemberId);

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

            modelBuilder.Entity<Society>()
                .HasOne(m => m.Member)
                .WithMany(l => l.Societies)
                .HasForeignKey(m => m.MemberId);

            #endregion


            #region Database seeding



            modelBuilder.Entity<Properties>().HasData(
                new Properties { PropName = "WiFi" },
                new Properties { PropName = "WC" },
                new Properties { PropName = "Coffee Machine"}
            );


            modelBuilder.Entity<LocationsProperties>().HasData(
                new LocationsProperties
                {
                    LocationsPropertiesId = 1,
                    LocationId = 1,
                    PropName = "WiFi",
                },
                new LocationsProperties
                {
                    LocationsPropertiesId = 2,
                    LocationId = 2,
                    PropName = "WiFi",

                },
                new LocationsProperties
                {
                    LocationsPropertiesId = 3,
                    LocationId = 3,
                    PropName = "WiFi",
                },
                new LocationsProperties
                {
                    LocationsPropertiesId = 4,
                    LocationId = 1,
                    PropName = "WC",
                },
                new LocationsProperties
                {
                    LocationsPropertiesId = 5,
                    LocationId = 2,
                    PropName = "WC",

                },
                new LocationsProperties
                {
                    LocationsPropertiesId = 6,
                    LocationId = 3,
                    PropName = "WC",
                });

 
            modelBuilder.Entity<Society>().HasData(
                new Society
                {
                    MemberId = 1,
                    SocietyId = 1,
                    Activity = "Football",
                    CVR_Number = 1234,
                    Name = "FootballFc",
                    Address = "Aarhusvej 10"
                },
                new Society
                {
                    MemberId = 2,
                    SocietyId = 2,
                    Activity = "Programming",
                    CVR_Number = 4321,
                    Name = "Programmers",
                    Address = "Aarhusvej 12"
                },
                new Society
                {
                    MemberId = 3,
                    SocietyId = 3,
                    Activity = "Gaming",
                    CVR_Number = 4321,
                    Name = "Gamers",
                    Address = "Aarhusvej 14"
                }
                );


            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    HomeAddress = "Aarhusvej 90",
                    IdentityNumber = 1234564,
                    MemberId = 1,
                    Name = "Jan",
                    PhoneNumber = 12345678,
                    Email = "jan@email.com",


                },
                new Member
                {
                    HomeAddress = "SesameStreet 12413",
                    IdentityNumber = 2142534635,
                    MemberId = 2,
                    Name = "Ole",
                    PhoneNumber = 23456789,
                    Email = "Ole@email.com",

                });

            //modelBuilder.Entity<SocietiesMember>().HasData(
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 1,
            //        SocietyId = 1,
            //        MemberId = 1,

            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 2,
            //        SocietyId = 1,
            //        MemberId = 2,
            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 3,
            //        SocietyId = 1,
            //        MemberId = 3,
            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 4,
            //        SocietyId = 2,
            //        MemberId = 1,
            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 5,
            //        SocietyId = 2,
            //        MemberId = 2,
            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 6,
            //        SocietyId = 3,
            //        MemberId = 3,
            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 7,
            //        SocietyId = 3,
            //        MemberId = 2,
            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 8,
            //        SocietyId = 1,
            //        MemberId = 4,
            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 9,
            //        SocietyId = 2,
            //        MemberId = 5,

            //    },
            //    new SocietiesMember
            //    {
            //        SocietiesMemberId = 10,
            //        SocietyId = 3,
            //        MemberId = 6,

            //    });

            modelBuilder.Entity<Chairmen>().HasData(
                new Chairmen
                {

                    MemberId = 4,
                    Name = "Per",
                    PhoneNumber = 87654321,
                    Email = "per@email.com",
                    HomeAddress = "Gadevej 9",
                    CPR_number = "1234345590",
                });
  

            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Key_Address = "Horsesvej 1253262",
                   
                    LocationId = 1,
                    Name = "FootballClub",
                    Capacity = 300,
                    Access_code = null,
                    Address = "Stivej 3",

                },
                new Location
                {
                    Key_Address = null,
                    LocationId = 2,
                    Name = "ProgrammerHouse",
                    Capacity = 30230,
                    Access_code = 434321,
                    Address = "Stivej 3",

                },
                new Location
                {
                    Key_Address = null,
                    LocationId = 3,
                    Name = "´GamerHouse",
                    Capacity = 321300,
                    Access_code = 432341,
                    Address = "Stivej 3",

                });

            modelBuilder.Entity<LocationHolidays>().HasData(
                new LocationHolidays
                {
                    Holiday = DateTime.Now,
                    LocationId = 1,
                },
                new LocationHolidays
                {
                    Holiday = DateTime.Now,
                    LocationId = 2,
                },
                new LocationHolidays
                {
                    Holiday = DateTime.Now,
                    LocationId = 3,
                });

            modelBuilder.Entity<LocationOpeningHours>().HasData(
                new LocationOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    LocationId = 1,
                },
                new LocationOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    LocationId = 2,
                },
                new LocationOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    LocationId = 3,
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Key_Address = "Finlandsgade 123",
                    RoomId = 1,
                    LocationId = 1,
                    Capacity = 330,
                    Access_code = null,
                },
                new Room
                {
                    Key_Address = "ParkAvenue 123",
                    RoomId = 2,
                    LocationId = 1,
                    Capacity = 340,
                    Access_code = null,
                },
                new Room
                {
                    RoomId = 3,
                    LocationId = 2,
                    Capacity = 304,
                    Access_code = 123174,
                },
                new Room
                {
                    RoomId = 4,
                    LocationId = 2,
                    Capacity = 930,
                    Access_code = 871234,
                },
                new Room
                {
                    RoomId = 5,
                    LocationId = 3,
                    Capacity = 730,
                    Access_code = 178234,
                },
                new Room
                {
                    RoomId = 6,
                    LocationId = 3,
                    Capacity = 630,
                    Access_code = 145234,
                }
                );

            modelBuilder.Entity<RoomHolidays>().HasData(
                new RoomHolidays
                {
                    Holiday = DateTime.Now,
                    RoomId = 1,
                },
                new RoomHolidays
                {
                    Holiday = DateTime.Now,
                    RoomId = 2,
                },
                new RoomHolidays
                {
                    Holiday = DateTime.Now,
                    RoomId = 3,
                },
                new RoomHolidays
                {
                    Holiday = DateTime.Now,
                    RoomId = 4,
                },
                new RoomHolidays
                {
                    Holiday = DateTime.Now,
                    RoomId = 5,
                },
                new RoomHolidays
                {
                    Holiday = DateTime.Now,
                    RoomId = 6,
                });

            modelBuilder.Entity<RoomOpeningHours>().HasData(
                new RoomOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 1,
                },
                new RoomOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 2,
                },
                new RoomOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 3,
                },
                new RoomOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 4,
                },
                new RoomOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 5,
                },
                new RoomOpeningHours
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 6,
                });



            modelBuilder.Entity<MembersRoomsReservations>().HasData(
                new MembersRoomsReservations
                {
                    MemberId = 1,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 1,

                },
                new MembersRoomsReservations
                {
                    MemberId = 2,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 2,

                },
                new MembersRoomsReservations
                {
                    MemberId = 3,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 3,

                },
                new MembersRoomsReservations
                {
                    MemberId = 4,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 4,

                },
                new MembersRoomsReservations
                {
                    MemberId = 5,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 5,

                },
                new MembersRoomsReservations
                {
                    MemberId = 6,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 6,

                });

            modelBuilder.Entity<MembersLocationsReservations>().HasData(
                new MembersLocationsReservations
                {
                    MemberId = 1,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    LocationId = 1,

                },
                new MembersLocationsReservations
                {
                    MemberId = 2,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    LocationId = 2,

                },
                new MembersLocationsReservations
                {
                    MemberId = 3,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    LocationId = 3,

                });

            #endregion

        }

    }
}
