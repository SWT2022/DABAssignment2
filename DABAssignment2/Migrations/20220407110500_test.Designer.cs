// <auto-generated />
using System;
using DABAssignment2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DABAssignment2.Migrations
{
    [DbContext(typeof(MuniDbContext))]
    [Migration("20220407110500_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DABAssignment2.Models.Location", b =>
                {
                    b.Property<long>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LocationId"), 1L, 1);

                    b.Property<int>("Access_code")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1L,
                            Access_code = 4321,
                            Address = "Stivej 3",
                            Capacity = 300,
                            Name = "FootballClub"
                        },
                        new
                        {
                            LocationId = 2L,
                            Access_code = 434321,
                            Address = "Stivej 3",
                            Capacity = 30230,
                            Name = "ProgrammerHouse"
                        },
                        new
                        {
                            LocationId = 3L,
                            Access_code = 432341,
                            Address = "Stivej 3",
                            Capacity = 321300,
                            Name = "´GamerHouse"
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.LocationHolidays", b =>
                {
                    b.Property<DateTime>("Holiday")
                        .HasColumnType("datetime2");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.HasKey("Holiday", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("LocationHolidays");

                    b.HasData(
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8274),
                            LocationId = 1L
                        },
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8320),
                            LocationId = 2L
                        },
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8323),
                            LocationId = 3L
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.LocationOpeningHours", b =>
                {
                    b.Property<DateTime>("Opening")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Closing")
                        .HasColumnType("datetime2");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.HasKey("Opening", "Closing", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("LocationOpeningHours");

                    b.HasData(
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8351),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8353),
                            LocationId = 1L
                        },
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8357),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8359),
                            LocationId = 2L
                        },
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8362),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8364),
                            LocationId = 3L
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.LocationsProperties", b =>
                {
                    b.Property<long>("LocationsPropertiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LocationsPropertiesId"), 1L, 1);

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<string>("PropName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("LocationsPropertiesId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PropName");

                    b.ToTable("LocationsProperties");

                    b.HasData(
                        new
                        {
                            LocationsPropertiesId = 1L,
                            LocationId = 1L,
                            PropName = "WiFi"
                        },
                        new
                        {
                            LocationsPropertiesId = 2L,
                            LocationId = 2L,
                            PropName = "WiFi"
                        },
                        new
                        {
                            LocationsPropertiesId = 3L,
                            LocationId = 3L,
                            PropName = "WiFi"
                        },
                        new
                        {
                            LocationsPropertiesId = 4L,
                            LocationId = 1L,
                            PropName = "WC"
                        },
                        new
                        {
                            LocationsPropertiesId = 5L,
                            LocationId = 2L,
                            PropName = "WC"
                        },
                        new
                        {
                            LocationsPropertiesId = 6L,
                            LocationId = 3L,
                            PropName = "WC"
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.Member", b =>
                {
                    b.Property<long>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MemberId"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("MemberId");

                    b.ToTable("Members");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Member");

                    b.HasData(
                        new
                        {
                            MemberId = 1L,
                            Email = "jan@email.com",
                            Name = "Jan",
                            PhoneNumber = 12345678
                        },
                        new
                        {
                            MemberId = 2L,
                            Email = "Ole@email.com",
                            Name = "Ole",
                            PhoneNumber = 23456789
                        },
                        new
                        {
                            MemberId = 3L,
                            Email = "Jens@email.com",
                            Name = "Jens",
                            PhoneNumber = 98765421
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.MembersLocationsReservations", b =>
                {
                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ReservationBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationEnd")
                        .HasColumnType("datetime2");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint");

                    b.HasKey("LocationId", "ReservationBegin", "ReservationEnd");

                    b.HasIndex("MemberId");

                    b.ToTable("MembersLocationsReservations");

                    b.HasData(
                        new
                        {
                            LocationId = 1L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8573),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8576),
                            MemberId = 1L
                        },
                        new
                        {
                            LocationId = 2L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8580),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8582),
                            MemberId = 2L
                        },
                        new
                        {
                            LocationId = 3L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8585),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8587),
                            MemberId = 3L
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.MembersRoomsReservations", b =>
                {
                    b.Property<long>("RoomId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ReservationBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationEnd")
                        .HasColumnType("datetime2");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint");

                    b.HasKey("RoomId", "ReservationBegin", "ReservationEnd");

                    b.HasIndex("MemberId");

                    b.ToTable("MembersRoomsReservations");

                    b.HasData(
                        new
                        {
                            RoomId = 1L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8520),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8523),
                            MemberId = 1L
                        },
                        new
                        {
                            RoomId = 2L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8527),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8529),
                            MemberId = 2L
                        },
                        new
                        {
                            RoomId = 3L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8532),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8534),
                            MemberId = 3L
                        },
                        new
                        {
                            RoomId = 4L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8537),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8539),
                            MemberId = 4L
                        },
                        new
                        {
                            RoomId = 5L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8542),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8544),
                            MemberId = 5L
                        },
                        new
                        {
                            RoomId = 6L,
                            ReservationBegin = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8546),
                            ReservationEnd = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8549),
                            MemberId = 6L
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.Properties", b =>
                {
                    b.Property<string>("PropName")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("PropName");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            PropName = "WiFi"
                        },
                        new
                        {
                            PropName = "WC"
                        },
                        new
                        {
                            PropName = "Coffee Machine"
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.Room", b =>
                {
                    b.Property<long>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoomId"), 1L, 1);

                    b.Property<int>("Access_code")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.HasKey("RoomId");

                    b.HasIndex("LocationId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1L,
                            Access_code = 123234,
                            Capacity = 330,
                            LocationId = 1L
                        },
                        new
                        {
                            RoomId = 2L,
                            Access_code = 122134,
                            Capacity = 340,
                            LocationId = 1L
                        },
                        new
                        {
                            RoomId = 3L,
                            Access_code = 123174,
                            Capacity = 304,
                            LocationId = 2L
                        },
                        new
                        {
                            RoomId = 4L,
                            Access_code = 871234,
                            Capacity = 930,
                            LocationId = 2L
                        },
                        new
                        {
                            RoomId = 5L,
                            Access_code = 178234,
                            Capacity = 730,
                            LocationId = 3L
                        },
                        new
                        {
                            RoomId = 6L,
                            Access_code = 145234,
                            Capacity = 630,
                            LocationId = 3L
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.RoomHolidays", b =>
                {
                    b.Property<DateTime>("Holiday")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoomId")
                        .HasColumnType("bigint");

                    b.HasKey("Holiday", "RoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomHolidays");

                    b.HasData(
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8416),
                            RoomId = 1L
                        },
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8419),
                            RoomId = 2L
                        },
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8422),
                            RoomId = 3L
                        },
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8424),
                            RoomId = 4L
                        },
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8427),
                            RoomId = 5L
                        },
                        new
                        {
                            Holiday = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8429),
                            RoomId = 6L
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.RoomOpeningHours", b =>
                {
                    b.Property<DateTime>("Opening")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Closing")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoomId")
                        .HasColumnType("bigint");

                    b.HasKey("Opening", "Closing", "RoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomOpeningHours");

                    b.HasData(
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8456),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8458),
                            RoomId = 1L
                        },
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8462),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8464),
                            RoomId = 2L
                        },
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8467),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8469),
                            RoomId = 3L
                        },
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8472),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8475),
                            RoomId = 4L
                        },
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8486),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8489),
                            RoomId = 5L
                        },
                        new
                        {
                            Opening = new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8492),
                            Closing = new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8494),
                            RoomId = 6L
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.SocietiesMember", b =>
                {
                    b.Property<long>("SocietiesMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SocietiesMemberId"), 1L, 1);

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint");

                    b.Property<long>("SocietyId")
                        .HasColumnType("bigint");

                    b.HasKey("SocietiesMemberId");

                    b.HasIndex("MemberId");

                    b.HasIndex("SocietyId");

                    b.ToTable("SocietiesMember");

                    b.HasData(
                        new
                        {
                            SocietiesMemberId = 1L,
                            MemberId = 1L,
                            SocietyId = 1L
                        },
                        new
                        {
                            SocietiesMemberId = 2L,
                            MemberId = 2L,
                            SocietyId = 1L
                        },
                        new
                        {
                            SocietiesMemberId = 3L,
                            MemberId = 3L,
                            SocietyId = 1L
                        },
                        new
                        {
                            SocietiesMemberId = 4L,
                            MemberId = 1L,
                            SocietyId = 2L
                        },
                        new
                        {
                            SocietiesMemberId = 5L,
                            MemberId = 2L,
                            SocietyId = 2L
                        },
                        new
                        {
                            SocietiesMemberId = 6L,
                            MemberId = 3L,
                            SocietyId = 3L
                        },
                        new
                        {
                            SocietiesMemberId = 7L,
                            MemberId = 2L,
                            SocietyId = 3L
                        },
                        new
                        {
                            SocietiesMemberId = 8L,
                            MemberId = 4L,
                            SocietyId = 1L
                        },
                        new
                        {
                            SocietiesMemberId = 9L,
                            MemberId = 5L,
                            SocietyId = 2L
                        },
                        new
                        {
                            SocietiesMemberId = 10L,
                            MemberId = 6L,
                            SocietyId = 3L
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.Society", b =>
                {
                    b.Property<long>("SocietyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SocietyId"), 1L, 1);

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<long>("CVR_Number")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("SocietyId");

                    b.ToTable("Societies");

                    b.HasData(
                        new
                        {
                            SocietyId = 1L,
                            Activity = "Football",
                            CVR_Number = 1234L,
                            Name = "FootballFc"
                        },
                        new
                        {
                            SocietyId = 2L,
                            Activity = "Programming",
                            CVR_Number = 4321L,
                            Name = "Programmers"
                        },
                        new
                        {
                            SocietyId = 3L,
                            Activity = "Gaming",
                            CVR_Number = 4321L,
                            Name = "Gamers"
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.Chairmen", b =>
                {
                    b.HasBaseType("DABAssignment2.Models.Member");

                    b.Property<string>("CPR_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("HomeAdress")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasDiscriminator().HasValue("Chairmen");

                    b.HasData(
                        new
                        {
                            MemberId = 4L,
                            Email = "per@email.com",
                            Name = "Per1",
                            PhoneNumber = 87654321,
                            CPR_number = "1234345590",
                            HomeAdress = "Gadevej 9"
                        },
                        new
                        {
                            MemberId = 5L,
                            Email = "per@email.com",
                            Name = "Per2",
                            PhoneNumber = 87654321,
                            CPR_number = "1234567890",
                            HomeAdress = "Gadevej 10"
                        },
                        new
                        {
                            MemberId = 6L,
                            Email = "per@email.com",
                            Name = "Per3",
                            PhoneNumber = 87654321,
                            CPR_number = "1234545690",
                            HomeAdress = "Gadevej 11"
                        });
                });

            modelBuilder.Entity("DABAssignment2.Models.LocationHolidays", b =>
                {
                    b.HasOne("DABAssignment2.Models.Location", "Location")
                        .WithMany("Holidays")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DABAssignment2.Models.LocationOpeningHours", b =>
                {
                    b.HasOne("DABAssignment2.Models.Location", "Location")
                        .WithMany("OpeningHours")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DABAssignment2.Models.LocationsProperties", b =>
                {
                    b.HasOne("DABAssignment2.Models.Location", "Location")
                        .WithMany("LocationsProperties")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DABAssignment2.Models.Properties", "Property")
                        .WithMany("LocationsProperties")
                        .HasForeignKey("PropName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("DABAssignment2.Models.MembersLocationsReservations", b =>
                {
                    b.HasOne("DABAssignment2.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DABAssignment2.Models.Member", "Member")
                        .WithMany("LocationsReservations")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("DABAssignment2.Models.MembersRoomsReservations", b =>
                {
                    b.HasOne("DABAssignment2.Models.Member", "Member")
                        .WithMany("RoomsReservations")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DABAssignment2.Models.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DABAssignment2.Models.Room", b =>
                {
                    b.HasOne("DABAssignment2.Models.Location", "Location")
                        .WithMany("Rooms")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DABAssignment2.Models.RoomHolidays", b =>
                {
                    b.HasOne("DABAssignment2.Models.Room", "Room")
                        .WithMany("Holidays")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DABAssignment2.Models.RoomOpeningHours", b =>
                {
                    b.HasOne("DABAssignment2.Models.Room", "Room")
                        .WithMany("OpeningHours")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DABAssignment2.Models.SocietiesMember", b =>
                {
                    b.HasOne("DABAssignment2.Models.Member", "Member")
                        .WithMany("SocietiesMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DABAssignment2.Models.Society", "Society")
                        .WithMany("SocietiesMembers")
                        .HasForeignKey("SocietyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Society");
                });

            modelBuilder.Entity("DABAssignment2.Models.Location", b =>
                {
                    b.Navigation("Holidays");

                    b.Navigation("LocationsProperties");

                    b.Navigation("OpeningHours");

                    b.Navigation("Reservations");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DABAssignment2.Models.Member", b =>
                {
                    b.Navigation("LocationsReservations");

                    b.Navigation("RoomsReservations");

                    b.Navigation("SocietiesMembers");
                });

            modelBuilder.Entity("DABAssignment2.Models.Properties", b =>
                {
                    b.Navigation("LocationsProperties");
                });

            modelBuilder.Entity("DABAssignment2.Models.Room", b =>
                {
                    b.Navigation("Holidays");

                    b.Navigation("OpeningHours");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("DABAssignment2.Models.Society", b =>
                {
                    b.Navigation("SocietiesMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
