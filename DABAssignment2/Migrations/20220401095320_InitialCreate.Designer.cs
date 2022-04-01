﻿// <auto-generated />
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
    [Migration("20220401095320_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DABAssignment2.Models.Chairmen", b =>
                {
                    b.Property<long>("ChairmenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ChairmenId"), 1L, 1);

                    b.Property<string>("HomeAdress")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("ChairmenId");

                    b.ToTable("Chairmens");
                });

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

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<long>("_MunicipalityMunicipalityId")
                        .HasColumnType("bigint");

                    b.HasKey("LocationId");

                    b.HasIndex("_MunicipalityMunicipalityId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DABAssignment2.Models.Member", b =>
                {
                    b.Property<long>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MemberId"), 1L, 1);

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
                });

            modelBuilder.Entity("DABAssignment2.Models.Municipality", b =>
                {
                    b.Property<long>("MunicipalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MunicipalityId"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Mayor")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("MunicipalityId");

                    b.ToTable("Municipalities");
                });

            modelBuilder.Entity("DABAssignment2.Models.Property", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("DABAssignment2.Models.Room", b =>
                {
                    b.Property<long>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoomId"), 1L, 1);

                    b.Property<long>("_LocationLocationId")
                        .HasColumnType("bigint");

                    b.HasKey("RoomId");

                    b.HasIndex("_LocationLocationId");

                    b.ToTable("Rooms");
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

                    b.Property<long>("MunicipalitiesMunicipalityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("SocietyId");

                    b.HasIndex("MunicipalitiesMunicipalityId");

                    b.ToTable("Societies");
                });

            modelBuilder.Entity("LocationMember", b =>
                {
                    b.Property<long>("LocationsLocationId")
                        .HasColumnType("bigint");

                    b.Property<long>("MembersMemberId")
                        .HasColumnType("bigint");

                    b.HasKey("LocationsLocationId", "MembersMemberId");

                    b.HasIndex("MembersMemberId");

                    b.ToTable("LocationMember");
                });

            modelBuilder.Entity("LocationProperty", b =>
                {
                    b.Property<long>("LocationsLocationId")
                        .HasColumnType("bigint");

                    b.Property<long>("propertiesId")
                        .HasColumnType("bigint");

                    b.HasKey("LocationsLocationId", "propertiesId");

                    b.HasIndex("propertiesId");

                    b.ToTable("LocationProperty");
                });

            modelBuilder.Entity("MemberSociety", b =>
                {
                    b.Property<long>("MembersMemberId")
                        .HasColumnType("bigint");

                    b.Property<long>("SocietiesSocietyId")
                        .HasColumnType("bigint");

                    b.HasKey("MembersMemberId", "SocietiesSocietyId");

                    b.HasIndex("SocietiesSocietyId");

                    b.ToTable("MemberSociety");
                });

            modelBuilder.Entity("DABAssignment2.Models.Location", b =>
                {
                    b.HasOne("DABAssignment2.Models.Municipality", "_Municipality")
                        .WithMany("Locations")
                        .HasForeignKey("_MunicipalityMunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Municipality");
                });

            modelBuilder.Entity("DABAssignment2.Models.Room", b =>
                {
                    b.HasOne("DABAssignment2.Models.Location", "_Location")
                        .WithMany("Rooms")
                        .HasForeignKey("_LocationLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Location");
                });

            modelBuilder.Entity("DABAssignment2.Models.Society", b =>
                {
                    b.HasOne("DABAssignment2.Models.Municipality", "Municipalities")
                        .WithMany("Societies")
                        .HasForeignKey("MunicipalitiesMunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipalities");
                });

            modelBuilder.Entity("LocationMember", b =>
                {
                    b.HasOne("DABAssignment2.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DABAssignment2.Models.Member", null)
                        .WithMany()
                        .HasForeignKey("MembersMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocationProperty", b =>
                {
                    b.HasOne("DABAssignment2.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DABAssignment2.Models.Property", null)
                        .WithMany()
                        .HasForeignKey("propertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MemberSociety", b =>
                {
                    b.HasOne("DABAssignment2.Models.Member", null)
                        .WithMany()
                        .HasForeignKey("MembersMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DABAssignment2.Models.Society", null)
                        .WithMany()
                        .HasForeignKey("SocietiesSocietyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DABAssignment2.Models.Location", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DABAssignment2.Models.Municipality", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("Societies");
                });
#pragma warning restore 612, 618
        }
    }
}
