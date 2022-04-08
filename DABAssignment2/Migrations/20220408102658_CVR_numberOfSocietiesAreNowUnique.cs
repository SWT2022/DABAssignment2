using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class CVR_numberOfSocietiesAreNowUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6183), 1L },
                    { 2L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6188), 2L },
                    { 3L, new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6190), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6193), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6156), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6158), 1L, 1L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6161), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6163), 2L, 2L },
                    { new DateTime(2022, 4, 8, 12, 26, 57, 668, DateTimeKind.Local).AddTicks(6166), new DateTime(2022, 4, 8, 13, 26, 57, 668, DateTimeKind.Local).AddTicks(6168), 3L, 3L }
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

            migrationBuilder.UpdateData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 3L,
                column: "CVR_Number",
                value: 47658L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Societies",
                keyColumn: "SocietyId",
                keyValue: 3L,
                column: "CVR_Number",
                value: 4321L);
        }
    }
}
