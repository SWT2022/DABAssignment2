using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class ChairmanNowHasIdentityNumberInHasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8491), 1L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8534), 2L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8536), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8552), 1L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8550) },
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8557), 2L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8555) },
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8560), 3L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8558) }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3L,
                column: "IdentityNumber",
                value: 574839);

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8667), 1L },
                    { 2L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8669), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8671), 2L },
                    { 3L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8673), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8674), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8643), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8646), 1L, 1L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8648), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8650), 2L, 2L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8652), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8653), 3L, 3L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8591), 1L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8593), 2L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8595), 3L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8597), 4L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8599), 5L },
                    { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8600), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8615), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8612), 1L },
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8619), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8617), 2L },
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8622), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8621), 3L },
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8625), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8624), 4L },
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8629), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8627), 5L },
                    { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8632), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8631), 6L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8491), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8534), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8536), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8552), 1L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8557), 2L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8560), 3L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8669), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8673), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8643), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8646), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8648), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8650), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8652), new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8653), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8591), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8593), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8595), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8597), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8599), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8600), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8615), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8612), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8619), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8617), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8622), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8621), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8625), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8624), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8629), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8627), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 15, 25, 534, DateTimeKind.Local).AddTicks(8632), new DateTime(2022, 4, 8, 12, 15, 25, 534, DateTimeKind.Local).AddTicks(8631), 6L });

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

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3L,
                column: "IdentityNumber",
                value: 0);

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(904), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(906), 1L },
                    { 2L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(909), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(910), 2L },
                    { 3L, new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(912), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(914), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(884), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(885), 1L, 1L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(888), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(890), 2L, 2L },
                    { new DateTime(2022, 4, 8, 11, 59, 14, 878, DateTimeKind.Local).AddTicks(892), new DateTime(2022, 4, 8, 12, 59, 14, 878, DateTimeKind.Local).AddTicks(893), 3L, 3L }
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
        }
    }
}
