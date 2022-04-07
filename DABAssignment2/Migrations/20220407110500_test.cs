using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9790), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9842), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9846), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9877), 1L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9884), 2L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9889), 3L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(105), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(113), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(118), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(49), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(53), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(61), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(64), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(66), 3L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(69), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(72), 4L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(75), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(77), 5L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(83), 6L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9942), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9946), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9949), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9952), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9955), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9958), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9987), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9984), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9993), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9991), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9996), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(4), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(2), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(11), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(8), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(16), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(14), 6L });

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

            migrationBuilder.UpdateData(
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 2L,
                column: "LocationId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 3L,
                column: "LocationId",
                value: 3L);

            migrationBuilder.InsertData(
                table: "LocationsProperties",
                columns: new[] { "LocationsPropertiesId", "LocationId", "PropName" },
                values: new object[,]
                {
                    { 4L, 1L, "WC" },
                    { 5L, 2L, "WC" },
                    { 6L, 3L, "WC" }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4L,
                column: "Name",
                value: "Per1");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 5L,
                columns: new[] { "HomeAdress", "Name" },
                values: new object[] { "Gadevej 10", "Per2" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 6L,
                columns: new[] { "HomeAdress", "Name" },
                values: new object[] { "Gadevej 11", "Per3" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 6L);

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

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9790), 1L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9842), 2L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9846), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9877), 1L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9873) },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9884), 2L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9881) },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9889), 3L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9887) }
                });

            migrationBuilder.UpdateData(
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 2L,
                column: "LocationId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 3L,
                column: "LocationId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4L,
                column: "Name",
                value: "Per");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 5L,
                columns: new[] { "HomeAdress", "Name" },
                values: new object[] { "Gadevej 9", "Per" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 6L,
                columns: new[] { "HomeAdress", "Name" },
                values: new object[] { "Gadevej 9", "Per" });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(105), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(109), 1L },
                    { 2L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(113), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(115), 2L },
                    { 3L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(118), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(121), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(49), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(53), 1L, 1L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(61), 2L, 2L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(64), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(66), 3L, 3L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(69), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(72), 4L, 4L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(75), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(77), 5L, 5L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(83), 6L, 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9942), 1L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9946), 2L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9949), 3L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9952), 4L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9955), 5L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9958), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9987), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9984), 1L },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9993), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9991), 2L },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9996), 3L },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(4), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(2), 4L },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(11), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(8), 5L },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(16), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(14), 6L }
                });
        }
    }
}
