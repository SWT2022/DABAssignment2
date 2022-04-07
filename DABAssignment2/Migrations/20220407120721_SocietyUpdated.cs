using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class SocietyUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8274), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8320), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8323), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8353), 1L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8359), 2L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8364), 3L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8573), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8523), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8527), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8529), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8532), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8534), 3L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8537), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8539), 4L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8542), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8544), 5L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8546), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8549), 6L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8416), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8419), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8422), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8424), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8427), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8429), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8458), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8456), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8464), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8462), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8469), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8467), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8475), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8472), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8489), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8486), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8494), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8492), 6L });

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Societies",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

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
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 1L,
                column: "Address",
                value: "Aarhusvej 10");

            migrationBuilder.UpdateData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 2L,
                column: "Address",
                value: "Aarhusvej 12");

            migrationBuilder.UpdateData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 3L,
                column: "Address",
                value: "Aarhusvej 14");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Address",
                table: "Societies");

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8274), 1L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8320), 2L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8323), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8353), 1L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8351) },
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8359), 2L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8357) },
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8364), 3L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8362) }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8573), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8576), 1L },
                    { 2L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8582), 2L },
                    { 3L, new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8587), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8523), 1L, 1L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8527), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8529), 2L, 2L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8532), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8534), 3L, 3L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8537), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8539), 4L, 4L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8542), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8544), 5L, 5L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8546), new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8549), 6L, 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8416), 1L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8419), 2L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8422), 3L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8424), 4L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8427), 5L },
                    { new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8429), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8458), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8456), 1L },
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8464), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8462), 2L },
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8469), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8467), 3L },
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8475), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8472), 4L },
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8489), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8486), 5L },
                    { new DateTime(2022, 4, 7, 14, 4, 59, 197, DateTimeKind.Local).AddTicks(8494), new DateTime(2022, 4, 7, 13, 4, 59, 197, DateTimeKind.Local).AddTicks(8492), 6L }
                });
        }
    }
}
