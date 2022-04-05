using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class RoomsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Municipalities__MunicipalityMunicipalityId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Locations__LocationLocationId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Societies_Municipalities_MunicipalitiesMunicipalityId",
                table: "Societies");

            migrationBuilder.DropTable(
                name: "Chairmens");

            migrationBuilder.DropTable(
                name: "LocationMember");

            migrationBuilder.DropTable(
                name: "LocationProperty");

            migrationBuilder.DropTable(
                name: "MemberSociety");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropIndex(
                name: "IX_Societies_MunicipalitiesMunicipalityId",
                table: "Societies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Locations__MunicipalityMunicipalityId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "MunicipalitiesMunicipalityId",
                table: "Societies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "_MunicipalityMunicipalityId",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "_LocationLocationId",
                table: "Rooms",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms__LocationLocationId",
                table: "Rooms",
                newName: "IX_Rooms_LocationId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Properties",
                newName: "PropName");

            migrationBuilder.AddColumn<int>(
                name: "Access_code",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CPR_number",
                table: "Members",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HomeAdress",
                table: "Members",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "PropName");

            migrationBuilder.CreateTable(
                name: "LocationHolidays",
                columns: table => new
                {
                    Holiday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationHolidays", x => new { x.Holiday, x.LocationId });
                    table.ForeignKey(
                        name: "FK_LocationHolidays_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationOpeningHours",
                columns: table => new
                {
                    Opening = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Closing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationOpeningHours", x => new { x.Opening, x.Closing, x.LocationId });
                    table.ForeignKey(
                        name: "FK_LocationOpeningHours_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationsProperties",
                columns: table => new
                {
                    LocationsPropertiesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    PropName = table.Column<string>(type: "nvarchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationsProperties", x => x.LocationsPropertiesId);
                    table.ForeignKey(
                        name: "FK_LocationsProperties_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationsProperties_Properties_PropName",
                        column: x => x.PropName,
                        principalTable: "Properties",
                        principalColumn: "PropName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MembersLocationsReservations",
                columns: table => new
                {
                    ReservationBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersLocationsReservations", x => new { x.LocationId, x.ReservationBegin, x.ReservationEnd });
                    table.ForeignKey(
                        name: "FK_MembersLocationsReservations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MembersLocationsReservations_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MembersRoomsReservations",
                columns: table => new
                {
                    ReservationBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersRoomsReservations", x => new { x.RoomId, x.ReservationBegin, x.ReservationEnd });
                    table.ForeignKey(
                        name: "FK_MembersRoomsReservations_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MembersRoomsReservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomHolidays",
                columns: table => new
                {
                    Holiday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomHolidays", x => new { x.Holiday, x.RoomId });
                    table.ForeignKey(
                        name: "FK_RoomHolidays_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomOpeningHours",
                columns: table => new
                {
                    Opening = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Closing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomOpeningHours", x => new { x.Opening, x.Closing, x.RoomId });
                    table.ForeignKey(
                        name: "FK_RoomOpeningHours_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocietiesMembers",
                columns: table => new
                {
                    SocietiesMembersId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocietyId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocietiesMembers", x => x.SocietiesMembersId);
                    table.ForeignKey(
                        name: "FK_SocietiesMembers_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocietiesMembers_Societies_SocietyId",
                        column: x => x.SocietyId,
                        principalTable: "Societies",
                        principalColumn: "SocietyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationHolidays_LocationId",
                table: "LocationHolidays",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationOpeningHours_LocationId",
                table: "LocationOpeningHours",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationsProperties_LocationId",
                table: "LocationsProperties",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationsProperties_PropName",
                table: "LocationsProperties",
                column: "PropName");

            migrationBuilder.CreateIndex(
                name: "IX_MembersLocationsReservations_MemberId",
                table: "MembersLocationsReservations",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MembersRoomsReservations_MemberId",
                table: "MembersRoomsReservations",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomHolidays_RoomId",
                table: "RoomHolidays",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomOpeningHours_RoomId",
                table: "RoomOpeningHours",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SocietiesMembers_MemberId",
                table: "SocietiesMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SocietiesMembers_SocietyId",
                table: "SocietiesMembers",
                column: "SocietyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Locations_LocationId",
                table: "Rooms",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Locations_LocationId",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "LocationHolidays");

            migrationBuilder.DropTable(
                name: "LocationOpeningHours");

            migrationBuilder.DropTable(
                name: "LocationsProperties");

            migrationBuilder.DropTable(
                name: "MembersLocationsReservations");

            migrationBuilder.DropTable(
                name: "MembersRoomsReservations");

            migrationBuilder.DropTable(
                name: "RoomHolidays");

            migrationBuilder.DropTable(
                name: "RoomOpeningHours");

            migrationBuilder.DropTable(
                name: "SocietiesMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Access_code",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CPR_number",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "HomeAdress",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Rooms",
                newName: "_LocationLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_LocationId",
                table: "Rooms",
                newName: "IX_Rooms__LocationLocationId");

            migrationBuilder.RenameColumn(
                name: "PropName",
                table: "Properties",
                newName: "Name");

            migrationBuilder.AddColumn<long>(
                name: "MunicipalitiesMunicipalityId",
                table: "Societies",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "_MunicipalityMunicipalityId",
                table: "Locations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Chairmens",
                columns: table => new
                {
                    ChairmenId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeAdress = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chairmens", x => x.ChairmenId);
                });

            migrationBuilder.CreateTable(
                name: "LocationMember",
                columns: table => new
                {
                    LocationsLocationId = table.Column<long>(type: "bigint", nullable: false),
                    MembersMemberId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationMember", x => new { x.LocationsLocationId, x.MembersMemberId });
                    table.ForeignKey(
                        name: "FK_LocationMember_Locations_LocationsLocationId",
                        column: x => x.LocationsLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationMember_Members_MembersMemberId",
                        column: x => x.MembersMemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationProperty",
                columns: table => new
                {
                    LocationsLocationId = table.Column<long>(type: "bigint", nullable: false),
                    propertiesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationProperty", x => new { x.LocationsLocationId, x.propertiesId });
                    table.ForeignKey(
                        name: "FK_LocationProperty_Locations_LocationsLocationId",
                        column: x => x.LocationsLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationProperty_Properties_propertiesId",
                        column: x => x.propertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberSociety",
                columns: table => new
                {
                    MembersMemberId = table.Column<long>(type: "bigint", nullable: false),
                    SocietiesSocietyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberSociety", x => new { x.MembersMemberId, x.SocietiesSocietyId });
                    table.ForeignKey(
                        name: "FK_MemberSociety_Members_MembersMemberId",
                        column: x => x.MembersMemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberSociety_Societies_SocietiesSocietyId",
                        column: x => x.SocietiesSocietyId,
                        principalTable: "Societies",
                        principalColumn: "SocietyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    MunicipalityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Mayor = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.MunicipalityId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Societies_MunicipalitiesMunicipalityId",
                table: "Societies",
                column: "MunicipalitiesMunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations__MunicipalityMunicipalityId",
                table: "Locations",
                column: "_MunicipalityMunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationMember_MembersMemberId",
                table: "LocationMember",
                column: "MembersMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationProperty_propertiesId",
                table: "LocationProperty",
                column: "propertiesId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberSociety_SocietiesSocietyId",
                table: "MemberSociety",
                column: "SocietiesSocietyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Municipalities__MunicipalityMunicipalityId",
                table: "Locations",
                column: "_MunicipalityMunicipalityId",
                principalTable: "Municipalities",
                principalColumn: "MunicipalityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Locations__LocationLocationId",
                table: "Rooms",
                column: "_LocationLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Societies_Municipalities_MunicipalitiesMunicipalityId",
                table: "Societies",
                column: "MunicipalitiesMunicipalityId",
                principalTable: "Municipalities",
                principalColumn: "MunicipalityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
