using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class DataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocietiesMembers");

            migrationBuilder.CreateTable(
                name: "SocietiesMember",
                columns: table => new
                {
                    SocietiesMemberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocietyId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocietiesMember", x => x.SocietiesMemberId);
                    table.ForeignKey(
                        name: "FK_SocietiesMember_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocietiesMember_Societies_SocietyId",
                        column: x => x.SocietyId,
                        principalTable: "Societies",
                        principalColumn: "SocietyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Access_code", "Address", "Availability", "Capacity", "Name" },
                values: new object[] { 1L, 4321, "Stivej 3", true, 300, "FootballClub" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CPR_number", "Discriminator", "Email", "HomeAdress", "Name", "PhoneNumber" },
                values: new object[] { 2L, "1234567890", "Chairmen", "per@email.com", "Gadevej 9", "Per", 87654321 });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Discriminator", "Email", "Name", "PhoneNumber" },
                values: new object[] { 1L, "Member", "jan@email.com", "Jan", 12345678 });

            migrationBuilder.InsertData(
                table: "Properties",
                column: "PropName",
                value: "WiFi");

            migrationBuilder.InsertData(
                table: "Societies",
                columns: new[] { "SocietyId", "Activity", "CVR_Number", "Name" },
                values: new object[] { 1L, "Football", 1234L, "FootballFc" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Access_code", "Availability", "Capacity", "LocationId" },
                values: new object[] { 1L, 1234, true, 30, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_SocietiesMember_MemberId",
                table: "SocietiesMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SocietiesMember_SocietyId",
                table: "SocietiesMember",
                column: "SocietyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocietiesMember");

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropName",
                keyValue: "WiFi");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1L);

            migrationBuilder.CreateTable(
                name: "SocietiesMembers",
                columns: table => new
                {
                    SocietiesMembersId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    SocietyId = table.Column<long>(type: "bigint", nullable: false)
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
                name: "IX_SocietiesMembers_MemberId",
                table: "SocietiesMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SocietiesMembers_SocietyId",
                table: "SocietiesMembers",
                column: "SocietyId");
        }
    }
}
