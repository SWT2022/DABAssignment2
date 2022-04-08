using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class ChairmenId3AddedAgainPlusSocietyId3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9777), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9825), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9827), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9844), 1L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9848), 2L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9851), 3L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9954), new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9958), new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9934), new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9936), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9939), new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9941), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9880), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9882), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9884), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9886), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9887), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9889), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9905), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9903), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9909), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9907), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9912), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9911), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9915), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9914), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9918), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9917), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9921), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9920), 6L });

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9808), 1L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9852), 2L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9854), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9869), 1L, new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9867) },
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9875), 2L, new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9873) },
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9878), 3L, new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9876) }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CPR_number", "Discriminator", "Email", "HomeAddress", "IdentityNumber", "Name", "PhoneNumber" },
                values: new object[] { 3L, "1234345590", "Chairmen", "per@email.com", "Gadevej 9", 574839, "Per", 87654321 });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(34), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(35), 1L },
                    { 2L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(38), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(39), 2L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9957), 1L, 1L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9959), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9961), 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9903), 1L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9906), 2L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9908), 3L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9909), 4L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9911), 5L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9913), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9926), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9925), 1L },
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9930), 2L },
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9934), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9933), 3L },
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9937), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9936), 4L },
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9941), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9939), 5L },
                    { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9944), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9942), 6L }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[] { 3L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(41), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(42), 3L });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9963), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9964), 3L, 3L });

            migrationBuilder.InsertData(
                table: "Societies",
                columns: new[] { "SocietyId", "Activity", "Address", "CVR_Number", "MemberId", "Name" },
                values: new object[] { 3L, "Gaming", "Aarhusvej 14", 47658L, 3L, "Gamers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9808), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9852), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9854), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9869), 1L, new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9875), 2L, new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9878), 3L, new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(34), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(38), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(41), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9957), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9959), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9961), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9963), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9964), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9903), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9906), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9908), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9909), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9911), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9913), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9926), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9925), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9930), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9934), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9933), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9937), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9936), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9941), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9939), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9944), new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9942), 6L });

            migrationBuilder.DeleteData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3L);

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9777), 1L },
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9825), 2L },
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9827), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9844), 1L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9842) },
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9848), 2L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9847) },
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9851), 3L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9850) }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9954), new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9956), 1L },
                    { 2L, new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9958), new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9960), 2L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9934), new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9936), 1L, 1L },
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9939), new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9941), 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9880), 1L },
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9882), 2L },
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9884), 3L },
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9886), 4L },
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9887), 5L },
                    { new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9889), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9905), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9903), 1L },
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9909), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9907), 2L },
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9912), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9911), 3L },
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9915), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9914), 4L },
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9918), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9917), 5L },
                    { new DateTime(2022, 4, 8, 13, 41, 36, 274, DateTimeKind.Local).AddTicks(9921), new DateTime(2022, 4, 8, 12, 41, 36, 274, DateTimeKind.Local).AddTicks(9920), 6L }
                });
        }
    }
}
