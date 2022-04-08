using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class UpdatedSolution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocietiesMember");

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1330), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1369), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1372), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1388), 1L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1393), 2L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1397), 3L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1525), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1530), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1534), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1489), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1491), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1494), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1496), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1498), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1500), 3L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1502), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1504), 4L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1506), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1508), 5L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1510), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1512), 6L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1426), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1428), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1431), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1433), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1435), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1437), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1452), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1459), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1457), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1463), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1461), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1467), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1465), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1471), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1469), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1474), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1473), 6L });

            migrationBuilder.DropColumn(
                name: "HomeAdress",
                table: "Members");

            migrationBuilder.AddColumn<long>(
                name: "MemberId",
                table: "Societies",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<int>(
                name: "Access_code",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Key_Address",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdentityNumber",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Access_code",
                table: "Locations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Key_Address",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5018), 1L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5080), 2L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5082), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5102), 1L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5100) },
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5110), 2L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5108) },
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5114), 3L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5112) }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1L,
                columns: new[] { "Access_code", "Key_Address" },
                values: new object[] { null, "Horsesvej 1253262" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4L,
                column: "HomeAddress",
                value: "Gadevej 9");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 5L,
                column: "HomeAddress",
                value: "Gadevej 10");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 6L,
                column: "HomeAddress",
                value: "Gadevej 11");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1L,
                columns: new[] { "HomeAddress", "IdentityNumber" },
                values: new object[] { "Aarhusvej 90", 1234564 });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2L,
                columns: new[] { "HomeAddress", "IdentityNumber" },
                values: new object[] { "SesameStreet 12413", 2142534635 });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3L,
                columns: new[] { "HomeAddress", "IdentityNumber" },
                values: new object[] { "Randersvej 124", 1234251 });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5271), 1L },
                    { 2L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5276), 2L },
                    { 3L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5279), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5281), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5232), 1L, 1L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5235), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5237), 2L, 2L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5239), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5241), 3L, 3L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5246), 4L, 4L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5248), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5250), 5L, 5L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5254), 6L, 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5156), 1L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5159), 2L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5161), 3L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5164), 4L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5166), 5L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5169), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5191), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5189), 1L },
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5196), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5194), 2L },
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5198), 3L },
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5204), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5202), 4L },
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5207), 5L },
                    { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5213), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5211), 6L }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1L,
                columns: new[] { "Access_code", "Key_Address" },
                values: new object[] { null, "Finlandsgade 123" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2L,
                columns: new[] { "Access_code", "Key_Address" },
                values: new object[] { null, "ParkAvenue 123" });

            migrationBuilder.UpdateData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 1L,
                column: "MemberId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 2L,
                column: "MemberId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 3L,
                column: "MemberId",
                value: 3L);

            migrationBuilder.CreateIndex(
                name: "IX_Societies_MemberId",
                table: "Societies",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Societies_Members_MemberId",
                table: "Societies",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Societies_Members_MemberId",
                table: "Societies");

            migrationBuilder.DropIndex(
                name: "IX_Societies_MemberId",
                table: "Societies");

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5018), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5080), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5082), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5102), 1L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5110), 2L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5114), 3L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5279), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5232), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5235), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5237), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5239), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5241), 3L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5246), 4L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5248), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5250), 5L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5254), 6L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5156), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5159), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5161), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5164), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5166), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5169), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5191), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5189), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5196), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5194), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5198), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5204), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5202), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5207), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5213), new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5211), 6L });

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Societies");

            migrationBuilder.DropColumn(
                name: "Key_Address",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "HomeAddress",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Key_Address",
                table: "Locations");

            migrationBuilder.AlterColumn<int>(
                name: "Access_code",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAdress",
                table: "Members",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Access_code",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SocietiesMember",
                columns: table => new
                {
                    SocietiesMemberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    SocietyId = table.Column<long>(type: "bigint", nullable: false)
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
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1330), 1L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1369), 2L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1372), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1388), 1L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1386) },
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1393), 2L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1391) },
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1397), 3L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1395) }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1L,
                column: "Access_code",
                value: 4321);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4L,
                column: "HomeAdress",
                value: "Gadevej 9");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 5L,
                column: "HomeAdress",
                value: "Gadevej 10");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 6L,
                column: "HomeAdress",
                value: "Gadevej 11");

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1525), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1527), 1L },
                    { 2L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1530), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1531), 2L },
                    { 3L, new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1534), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1535), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1489), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1491), 1L, 1L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1494), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1496), 2L, 2L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1498), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1500), 3L, 3L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1502), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1504), 4L, 4L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1506), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1508), 5L, 5L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1510), new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1512), 6L, 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1426), 1L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1428), 2L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1431), 3L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1433), 4L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1435), 5L },
                    { new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1437), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1452), 1L },
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1459), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1457), 2L },
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1463), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1461), 3L },
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1467), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1465), 4L },
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1471), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1469), 5L },
                    { new DateTime(2022, 4, 7, 15, 7, 20, 848, DateTimeKind.Local).AddTicks(1474), new DateTime(2022, 4, 7, 14, 7, 20, 848, DateTimeKind.Local).AddTicks(1473), 6L }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1L,
                column: "Access_code",
                value: 123234);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2L,
                column: "Access_code",
                value: 122134);

            migrationBuilder.InsertData(
                table: "SocietiesMember",
                columns: new[] { "SocietiesMemberId", "MemberId", "SocietyId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 2L, 2L, 1L },
                    { 3L, 3L, 1L },
                    { 4L, 1L, 2L },
                    { 5L, 2L, 2L },
                    { 6L, 3L, 3L },
                    { 7L, 2L, 3L },
                    { 8L, 4L, 1L },
                    { 9L, 5L, 2L }
                });

            migrationBuilder.InsertData(
                table: "SocietiesMember",
                columns: new[] { "SocietiesMemberId", "MemberId", "SocietyId" },
                values: new object[] { 10L, 6L, 3L });

            migrationBuilder.CreateIndex(
                name: "IX_SocietiesMember_MemberId",
                table: "SocietiesMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SocietiesMember_SocietyId",
                table: "SocietiesMember",
                column: "SocietyId");
        }
    }
}
