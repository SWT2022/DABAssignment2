using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class fixedMemberIdsAsOnlyKeyResponsableMembersAreStored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 3L);

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(731), 1L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(777), 2L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(779), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(792), 1L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(791) },
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(796), 2L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(795) },
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(800), 3L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(798) }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CPR_number", "Discriminator", "Email", "HomeAddress", "IdentityNumber", "Name", "PhoneNumber" },
                values: new object[] { 3L, "1234345590", "Chairmen", "per@email.com", "Gadevej 9", 0, "Per", 87654321 });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(904), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(906), 1L },
                    { 2L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(909), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(910), 2L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(884), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(885), 1L, 1L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(888), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(890), 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(825), 1L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(827), 2L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(829), 3L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(831), 4L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(832), 5L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(835), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(849), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(847), 1L },
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(858), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(856), 2L },
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(861), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(859), 3L },
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(864), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(863), 4L },
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(867), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(865), 5L },
                    { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(870), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(868), 6L }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[] { 3L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(912), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(914), 3L });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(892), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(893), 3L, 3L });

            migrationBuilder.CreateIndex(
                name: "IX_Societies_CVR_Number",
                table: "Societies",
                column: "CVR_Number",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Societies_CVR_Number",
                table: "Societies");

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(731), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(777), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(779), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(792), 1L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(796), 2L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(800), 3L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(904), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(909), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(912), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(884), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(885), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(888), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(890), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(892), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(893), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(825), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(827), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(829), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(831), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(832), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(835), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(849), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(847), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(858), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(856), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(861), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(859), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(864), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(863), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(867), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(865), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(870), new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(868), 6L });

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3L);

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

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CPR_number", "Discriminator", "Email", "HomeAddress", "IdentityNumber", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 4L, "1234345590", "Chairmen", "per@email.com", "Gadevej 9", 0, "Per1", 87654321 },
                    { 5L, "1234567890", "Chairmen", "per@email.com", "Gadevej 10", 0, "Per2", 87654321 },
                    { 6L, "1234545690", "Chairmen", "per@email.com", "Gadevej 11", 0, "Per3", 87654321 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Discriminator", "Email", "HomeAddress", "IdentityNumber", "Name", "PhoneNumber" },
                values: new object[] { 3L, "Member", "Jens@email.com", "Randersvej 124", 1234251, "Jens", 98765421 });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5271), 1L },
                    { 2L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5276), 2L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5232), 1L, 1L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5235), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5237), 2L, 2L }
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

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[] { 3L, new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5279), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5281), 3L });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5239), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5241), 3L, 3L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5246), 4L, 4L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5248), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5250), 5L, 5L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5254), 6L, 6L }
                });
        }
    }
}
