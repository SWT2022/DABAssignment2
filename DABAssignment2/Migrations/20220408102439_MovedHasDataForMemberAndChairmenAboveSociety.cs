using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class MovedHasDataForMemberAndChairmenAboveSociety : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3912), 1L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3953), 2L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3956), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(3971), 1L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3969) },
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(3975), 2L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3973) },
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(3978), 3L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3977) }
                });

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4092), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4094), 1L },
                    { 2L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4097), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4098), 2L },
                    { 3L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4102), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4068), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4070), 1L, 1L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4074), 2L, 2L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4076), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4078), 3L, 3L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4003), 1L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4006), 2L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4008), 3L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4009), 4L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4012), 5L },
                    { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4013), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4031), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4029), 1L },
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4036), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4034), 2L },
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4039), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4038), 3L },
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4042), 4L },
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4048), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4047), 5L },
                    { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4052), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4051), 6L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3912), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3953), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3956), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(3971), 1L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(3975), 2L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(3978), 3L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4092), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4097), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4068), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4070), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4074), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4076), new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4078), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4003), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4006), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4008), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4009), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4012), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4013), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4031), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4029), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4036), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4034), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4039), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4038), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4042), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4048), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4047), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 13, 24, 39, 158, DateTimeKind.Local).AddTicks(4052), new DateTime(2022, 4, 8, 12, 24, 39, 158, DateTimeKind.Local).AddTicks(4051), 6L });

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
    }
}
