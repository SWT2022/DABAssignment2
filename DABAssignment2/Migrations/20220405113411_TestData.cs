using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LocationsProperties",
                columns: new[] { "LocationsPropertiesId", "LocationId", "PropName" },
                values: new object[] { 1L, 1L, "WiFi" });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[] { 1L, new DateTime(2022, 4, 5, 13, 34, 10, 549, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 4, 5, 14, 34, 10, 549, DateTimeKind.Local).AddTicks(160), 1L });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[] { new DateTime(2022, 4, 5, 13, 34, 10, 549, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 4, 5, 14, 34, 10, 549, DateTimeKind.Local).AddTicks(90), 1L, 1L });

            migrationBuilder.InsertData(
                table: "SocietiesMember",
                columns: new[] { "SocietiesMemberId", "MemberId", "SocietyId" },
                values: new object[] { 1L, 1L, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 5, 13, 34, 10, 549, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 4, 5, 14, 34, 10, 549, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 5, 13, 34, 10, 549, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 4, 5, 14, 34, 10, 549, DateTimeKind.Local).AddTicks(90), 1L });

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 1L);
        }
    }
}
