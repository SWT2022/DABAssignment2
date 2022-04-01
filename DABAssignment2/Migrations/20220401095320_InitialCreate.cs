using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    MunicipalityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Mayor = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.MunicipalityId);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Access_code = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    _MunicipalityMunicipalityId = table.Column<long>(type: "bigint", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locations_Municipalities__MunicipalityMunicipalityId",
                        column: x => x._MunicipalityMunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "MunicipalityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Societies",
                columns: table => new
                {
                    SocietyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Activity = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CVR_Number = table.Column<long>(type: "bigint", nullable: false),
                    MunicipalitiesMunicipalityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societies", x => x.SocietyId);
                    table.ForeignKey(
                        name: "FK_Societies_Municipalities_MunicipalitiesMunicipalityId",
                        column: x => x.MunicipalitiesMunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "MunicipalityId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _LocationLocationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_Locations__LocationLocationId",
                        column: x => x._LocationLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
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

            migrationBuilder.CreateIndex(
                name: "IX_LocationMember_MembersMemberId",
                table: "LocationMember",
                column: "MembersMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationProperty_propertiesId",
                table: "LocationProperty",
                column: "propertiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations__MunicipalityMunicipalityId",
                table: "Locations",
                column: "_MunicipalityMunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberSociety_SocietiesSocietyId",
                table: "MemberSociety",
                column: "SocietiesSocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms__LocationLocationId",
                table: "Rooms",
                column: "_LocationLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Societies_MunicipalitiesMunicipalityId",
                table: "Societies",
                column: "MunicipalitiesMunicipalityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chairmens");

            migrationBuilder.DropTable(
                name: "LocationMember");

            migrationBuilder.DropTable(
                name: "LocationProperty");

            migrationBuilder.DropTable(
                name: "MemberSociety");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Societies");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Municipalities");
        }
    }
}
