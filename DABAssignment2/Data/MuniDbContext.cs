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
            #endregion


            #region Database seeding



            modelBuilder.Entity<Properties>().HasData(
                new { PropName = "WiFi" },
                new { PromName = "WC" },
                new { PropName = "Coffee Machine"}
            );


            modelBuilder.Entity<LocationsProperties>().HasData(
                new
                {
                    LocationsPropertiesId = 1,
                    LocationId = 1,
                    PropName = "WiFi",
                },
                new
                {
                    LocationsPropertiesId = 2,
                    LocationId = 1,
                    PropName = "WiFi",

                },
                new
                {
                    LocationsPropertiesId = 3,
                    LocationId = 1,
                    PropName = "WiFi",
                });

 
            modelBuilder.Entity<Society>().HasData(
                new
                {
                    SocietyId = 1,
                    Activity = "Football",
                    CVR_Number = 1234,
                    Name = "FootballFc"
                },
                new
                {
                    SocietyId = 2,
                    Activity = "Programming",
                    CVR_Number = 4321,
                    Name = "Programmers"
                },
                new
                {
                    SocietyId = 3,
                    Activity = "Gaming",
                    CVR_Number = 4321,
                    Name = "Gamers"
                }
                );


            modelBuilder.Entity<Member>().HasData(
                new
                {
                    MemberId = 1,
                    Name = "Jan",
                    PhoneNumber = 12345678,
                    Email = "jan@email.com",

                },
                new
                {
                    MemberId = 2,
                    Name = "Ole",
                    PhoneNumber = 23456789,
                    Email = "Ole@email.com",

                },
                new
                {
                    MemberId = 3,
                    Name = "Jens",
                    PhoneNumber = 98765421,
                    Email = "Jens@email.com",

                }
                );

            modelBuilder.Entity<SocietiesMember>().HasData(
                new
                {
                    SocietiesMemberId = 1,
                    SocietyId = 1,
                    MemberId = 1,

                },
                new
                {
                    SocietiesMemberId = 2,
                    SocietyId = 1,
                    MemberId = 2,
                },
                new
                {
                    SocietiesMemberId = 3,
                    SocietyId = 1,
                    MemberId = 3,
                },
                new
                {
                    SocietiesMemberId = 4,
                    SocietyId = 2,
                    MemberId = 1,
                },
                new
                {
                    SocietiesMemberId = 5,
                    SocietyId = 2,
                    MemberId = 2,
                },
                new
                {
                    SocietiesMemberId = 6,
                    SocietyId = 3,
                    MemberId = 3,
                },
                new
                {
                    SocietiesMemberId = 7,
                    SocietyId = 3,
                    MemberId = 2,
                },
                new
                {
                    SocietiesMemberId = 7,
                    SocietyId = 1,
                    MemberId = 4,
                },
                new
                {
                    SocietiesMemberId = 8,
                    SocietyId = 2,
                    MemberId = 5,

                },
                new
                {
                    SocietiesMemberId = 9,
                    SocietyId = 3,
                    MemberId = 6,

                });

            modelBuilder.Entity<Chairmen>().HasData(
                new
                {
                    MemberId = 4,
                    Name = "Per",
                    PhoneNumber = 87654321,
                    Email = "per@email.com",
                    HomeAdress = "Gadevej 9",
                    CPR_number = "1234345590",
                },
                new
                {
                    MemberId = 5,
                    Name = "Per",
                    PhoneNumber = 87654321,
                    Email = "per@email.com",
                    HomeAdress = "Gadevej 9",
                    CPR_number = "1234567890",
                },
                new
                {
                    MemberId = 6,
                    Name = "Per",
                    PhoneNumber = 87654321,
                    Email = "per@email.com",
                    HomeAdress = "Gadevej 9",
                    CPR_number = "1234545690",
                });

            modelBuilder.Entity<Location>().HasData(
                new
                {
                    LocationId = 1,
                    Name = "FootballClub",
                    Capacity = 300,
                    Access_code = 4321,
                    Address = "Stivej 3",

                },
                new
                {
                    LocationId = 2,
                    Name = "ProgrammerHouse",
                    Capacity = 30230,
                    Access_code = 434321,
                    Address = "Stivej 3",

                },
                new
                {
                    LocationId = 3,
                    Name = "´GamerHouse",
                    Capacity = 321300,
                    Access_code = 432341,
                    Address = "Stivej 3",

                });

            modelBuilder.Entity<LocationHolidays>().HasData(
                new
                {
                    Holiday = DateTime.Now,
                    LocationId = 1,
                },
                new
                {
                    Holiday = DateTime.Now,
                    LocationId = 2,
                },
                new
                {
                    Holiday = DateTime.Now,
                    LocationId = 3,
                });

            modelBuilder.Entity<LocationHolidays>().HasData(
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    LocationId = 1,
                },
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    LocationId = 2,
                },
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    LocationId = 3,
                });


            modelBuilder.Entity<Room>().HasData(
                new
                {
                    RoomId = 1,
                    LocationId = 1,
                    Capacity = 330,
                    Access_code = 123234,
                },
                new
                {
                    RoomId = 2,
                    LocationId = 1,
                    Capacity = 340,
                    Access_code = 122134,
                },
                new
                {
                    RoomId = 3,
                    LocationId = 2,
                    Capacity = 304,
                    Access_code = 123174,
                },
                new
                {
                    RoomId = 4,
                    LocationId = 2,
                    Capacity = 930,
                    Access_code = 871234,
                },
                new
                {
                    RoomId = 5,
                    LocationId = 3,
                    Capacity = 730,
                    Access_code = 178234,
                },
                new
                {
                    RoomId = 6,
                    LocationId = 3,
                    Capacity = 630,
                    Access_code = 145234,
                }
                );

            modelBuilder.Entity<LocationHolidays>().HasData(
                new
                {
                    Holiday = DateTime.Now,
                    RoomId = 1,
                },
                new
                {
                    Holiday = DateTime.Now,
                    RoomId = 2,
                },
                new
                {
                    Holiday = DateTime.Now,
                    RoomId = 3,
                },
                new
                {
                    Holiday = DateTime.Now,
                    RoomId = 4,
                },
                new
                {
                    Holiday = DateTime.Now,
                    RoomId = 5,
                },
                new
                {
                    Holiday = DateTime.Now,
                    RoomId = 6,
                });

            modelBuilder.Entity<LocationHolidays>().HasData(
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 1,
                },
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 2,
                },
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 3,
                },
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 4,
                },
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 5,
                },
                new
                {
                    Opening = DateTime.Now,
                    Closing = DateTime.Now.AddHours(1),
                    RoomId = 6,
                });



            modelBuilder.Entity<MembersRoomsReservations>().HasData(
                new
                {
                    MemberId = 1,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 1,

                },
                new
                {
                    MemberId = 2,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 2,

                },
                new
                {
                    MemberId = 3,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 3,

                },
                new
                {
                    MemberId = 4,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 4,

                },
                new
                {
                    MemberId = 5,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 5,

                },
                new
                {
                    MemberId = 6,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    RoomId = 6,

                });

            modelBuilder.Entity<MembersLocationsReservations>().HasData(
                new
                {
                    MemberId = 1,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    LocationId = 1,

                },
                new
                {
                    MemberId = 2,
                    ReservationBegin = DateTime.Now,
                    ReservationEnd = DateTime.Now.AddHours(1),
                    LocationId = 2,

                },
                new
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
