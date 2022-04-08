using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class RemovedLastSocietyAndMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(5923), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(5992), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(5995), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6021), 1L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6026), 2L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6030), 3L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6190), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6156), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6158), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6161), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6163), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6166), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6168), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6066), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6069), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6072), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6074), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6076), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6079), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6108), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6106), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6114), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6112), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6119), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6116), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6122), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6134), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6132), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6139), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6137), 6L });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(5923), 1L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(5992), 2L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(5995), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6021), 1L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6019) },
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6026), 2L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6024) },
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6030), 3L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6029) }
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
                    { 1L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6183), 1L },
                    { 2L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6188), 2L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6156), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6158), 1L, 1L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6161), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6163), 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6066), 1L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6069), 2L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6072), 3L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6074), 4L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6076), 5L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6079), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6108), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6106), 1L },
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6114), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6112), 2L },
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6119), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6116), 3L },
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6122), 4L },
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6134), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6132), 5L },
                    { new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6139), new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6137), 6L }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[] { 3L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6190), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6193), 3L });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[] { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6166), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6168), 3L, 3L });

            migrationBuilder.InsertData(
                table: "Societies",
                columns: new[] { "SocietyId", "Activity", "Address", "CVR_Number", "MemberId", "Name" },
                values: new object[] { 3L, "Gaming", "Aarhusvej 14", 47658L, 3L, "Gamers" });
        }
    }
}
