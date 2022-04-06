using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class DatabaseSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 5, 13, 34, 10, 549, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 4, 5, 14, 34, 10, 549, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 5, 13, 34, 10, 549, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 4, 5, 14, 34, 10, 549, DateTimeKind.Local).AddTicks(90), 1L });

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Locations");

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9790), 1L });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9877), 1L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Access_code", "Address", "Capacity", "Name" },
                values: new object[,]
                {
                    { 2L, 434321, "Stivej 3", 30230, "ProgrammerHouse" },
                    { 3L, 432341, "Stivej 3", 321300, "´GamerHouse" }
                });

            migrationBuilder.InsertData(
                table: "LocationsProperties",
                columns: new[] { "LocationsPropertiesId", "LocationId", "PropName" },
                values: new object[,]
                {
                    { 2L, 1L, "WiFi" },
                    { 3L, 1L, "WiFi" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CPR_number", "Discriminator", "Email", "HomeAdress", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 4L, "1234345590", "Chairmen", "per@email.com", "Gadevej 9", "Per", 87654321 },
                    { 5L, "1234567890", "Chairmen", "per@email.com", "Gadevej 9", "Per", 87654321 },
                    { 6L, "1234545690", "Chairmen", "per@email.com", "Gadevej 9", "Per", 87654321 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Discriminator", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 2L, "Member", "Ole@email.com", "Ole", 23456789 },
                    { 3L, "Member", "Jens@email.com", "Jens", 98765421 }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[] { 1L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(105), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(109), 1L });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(49), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(53), 1L, 1L });

            migrationBuilder.InsertData(
                table: "Properties",
                column: "PropName",
                values: new object[]
                {
                    "Coffee Machine",
                    "WC"
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9942), 1L });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9987), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9984), 1L });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1L,
                columns: new[] { "Access_code", "Capacity" },
                values: new object[] { 123234, 330 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Access_code", "Capacity", "LocationId" },
                values: new object[] { 2L, 122134, 340, 1L });

            migrationBuilder.InsertData(
                table: "Societies",
                columns: new[] { "SocietyId", "Activity", "CVR_Number", "Name" },
                values: new object[,]
                {
                    { 2L, "Programming", 4321L, "Programmers" },
                    { 3L, "Gaming", 4321L, "Gamers" }
                });

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9842), 2L },
                    { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9846), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9884), 2L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9881) },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9889), 3L, new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9887) }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 2L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(113), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(115), 2L },
                    { 3L, new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(118), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(121), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(61), 2L, 2L });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[] { new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9946), 2L });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[] { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9993), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9991), 2L });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Access_code", "Capacity", "LocationId" },
                values: new object[,]
                {
                    { 3L, 123174, 304, 2L },
                    { 4L, 871234, 930, 2L },
                    { 5L, 178234, 730, 3L },
                    { 6L, 145234, 630, 3L }
                });

            migrationBuilder.InsertData(
                table: "SocietiesMember",
                columns: new[] { "SocietiesMemberId", "MemberId", "SocietyId" },
                values: new object[,]
                {
                    { 2L, 2L, 1L },
                    { 3L, 3L, 1L },
                    { 4L, 1L, 2L },
                    { 5L, 2L, 2L },
                    { 6L, 3L, 3L },
                    { 7L, 2L, 3L },
                    { 8L, 4L, 1L },
                    { 9L, 5L, 2L },
                    { 10L, 6L, 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
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
                    { new DateTime(2022, 4, 6, 14, 29, 30, 105, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 4, 6, 13, 29, 30, 105, DateTimeKind.Local).AddTicks(9996), 3L },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(4), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(2), 4L },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(11), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(8), 5L },
                    { new DateTime(2022, 4, 6, 14, 29, 30, 106, DateTimeKind.Local).AddTicks(16), new DateTime(2022, 4, 6, 13, 29, 30, 106, DateTimeKind.Local).AddTicks(14), 6L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "LocationsProperties",
                keyColumn: "LocationsPropertiesId",
                keyValue: 3L);

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
                table: "Properties",
                keyColumn: "PropName",
                keyValue: "Coffee Machine");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropName",
                keyValue: "WC");

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

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "SocietiesMember",
                keyColumn: "SocietiesMemberId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3L);

            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Locations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1L,
                column: "Availability",
                value: true);

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CPR_number", "Discriminator", "Email", "HomeAdress", "Name", "PhoneNumber" },
                values: new object[] { 2L, "1234567890", "Chairmen", "per@email.com", "Gadevej 9", "Per", 87654321 });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[] { 1L, new DateTime(2022, 4, 5, 13, 34, 10, 549, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 4, 5, 14, 34, 10, 549, DateTimeKind.Local).AddTicks(160), 1L });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[] { new DateTime(2022, 4, 5, 13, 34, 10, 549, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 4, 5, 14, 34, 10, 549, DateTimeKind.Local).AddTicks(90), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1L,
                columns: new[] { "Access_code", "Availability", "Capacity" },
                values: new object[] { 1234, true, 30 });
        }
    }
}
