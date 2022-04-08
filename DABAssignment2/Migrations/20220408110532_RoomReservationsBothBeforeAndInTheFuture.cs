using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class RoomReservationsBothBeforeAndInTheFuture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "LocationHolidays",
                columns: new[] { "Holiday", "LocationId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4531), 1L },
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4578), 2L },
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4581), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4602), 1L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4600) },
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4607), 2L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4605) },
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4610), 3L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4609) }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4906), new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4909), 1L },
                    { 2L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4912), new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4913), 2L },
                    { 3L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4917), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 7, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4706), new DateTime(2022, 7, 8, 18, 5, 32, 333, DateTimeKind.Local).AddTicks(4709), 1L, 1L },
                    { new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 2L },
                    { new DateTime(2022, 9, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4797), new DateTime(2022, 9, 9, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4887), 3L, 3L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4640), 1L },
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4643), 2L },
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4645), 3L },
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4647), 4L },
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4649), 5L },
                    { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4652), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4667), 1L },
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4674), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4672), 2L },
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4677), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4676), 3L },
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4681), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4679), 4L },
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4685), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4683), 5L },
                    { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4688), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4687), 6L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4531), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4578), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4581), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4602), 1L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4607), 2L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4610), 3L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4906), new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4912), new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 7, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4706), new DateTime(2022, 7, 8, 18, 5, 32, 333, DateTimeKind.Local).AddTicks(4709), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 9, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4797), new DateTime(2022, 9, 9, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4887), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4640), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4643), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4645), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4647), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4649), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4652), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4667), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4674), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4672), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4677), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4676), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4681), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4679), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4685), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4683), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 14, 5, 32, 333, DateTimeKind.Local).AddTicks(4688), new DateTime(2022, 4, 8, 13, 5, 32, 333, DateTimeKind.Local).AddTicks(4687), 6L });

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
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(34), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(35), 1L },
                    { 2L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(38), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(39), 2L },
                    { 3L, new DateTime(2022, 4, 8, 12, 44, 21, 430, DateTimeKind.Local).AddTicks(41), new DateTime(2022, 4, 8, 13, 44, 21, 430, DateTimeKind.Local).AddTicks(42), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9957), 1L, 1L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9959), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9961), 2L, 2L },
                    { new DateTime(2022, 4, 8, 12, 44, 21, 429, DateTimeKind.Local).AddTicks(9963), new DateTime(2022, 4, 8, 13, 44, 21, 429, DateTimeKind.Local).AddTicks(9964), 3L, 3L }
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
        }
    }
}
