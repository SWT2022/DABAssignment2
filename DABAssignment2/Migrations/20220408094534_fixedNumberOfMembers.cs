using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DABAssignment2.Migrations
{
    public partial class fixedNumberOfMembers : Migration
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
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2812), 1L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2862), 2L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2869), 3L }
                });

            migrationBuilder.InsertData(
                table: "LocationOpeningHours",
                columns: new[] { "Closing", "LocationId", "Opening" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2885), 1L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2883) },
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2889), 2L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2887) },
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2892), 3L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2891) }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4L,
                column: "Name",
                value: "Per");

            migrationBuilder.InsertData(
                table: "MembersLocationsReservations",
                columns: new[] { "LocationId", "ReservationBegin", "ReservationEnd", "MemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(3006), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(3008), 1L },
                    { 2L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(3012), 2L },
                    { 3L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(3014), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(3015), 3L }
                });

            migrationBuilder.InsertData(
                table: "MembersRoomsReservations",
                columns: new[] { "ReservationBegin", "ReservationEnd", "RoomId", "MemberId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2975), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2977), 1L, 1L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2979), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2980), 2L, 2L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2982), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2984), 3L, 3L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2986), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2987), 4L, 4L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2989), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2991), 5L, 5L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2994), 6L, 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomHolidays",
                columns: new[] { "Holiday", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2919), 1L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2921), 2L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2923), 3L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2925), 4L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2927), 5L },
                    { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2928), 6L }
                });

            migrationBuilder.InsertData(
                table: "RoomOpeningHours",
                columns: new[] { "Closing", "Opening", "RoomId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2941), 1L },
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2947), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2945), 2L },
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2949), 3L },
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2954), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2952), 4L },
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2955), 5L },
                    { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2959), 6L }
                });

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
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2812), 1L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2862), 2L });

            migrationBuilder.DeleteData(
                table: "LocationHolidays",
                keyColumns: new[] { "Holiday", "LocationId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2869), 3L });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2885), 1L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2889), 2L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.DeleteData(
                table: "LocationOpeningHours",
                keyColumns: new[] { "Closing", "LocationId", "Opening" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2892), 3L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 1L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(3006), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 2L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.DeleteData(
                table: "MembersLocationsReservations",
                keyColumns: new[] { "LocationId", "ReservationBegin", "ReservationEnd" },
                keyValues: new object[] { 3L, new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(3014), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2975), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2977), 1L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2979), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2980), 2L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2982), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2984), 3L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2986), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2987), 4L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2989), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2991), 5L });

            migrationBuilder.DeleteData(
                table: "MembersRoomsReservations",
                keyColumns: new[] { "ReservationBegin", "ReservationEnd", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2994), 6L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2919), 1L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2921), 2L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2923), 3L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2925), 4L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2927), 5L });

            migrationBuilder.DeleteData(
                table: "RoomHolidays",
                keyColumns: new[] { "Holiday", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2928), 6L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2941), 1L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2947), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2945), 2L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2949), 3L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2954), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2952), 4L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2955), 5L });

            migrationBuilder.DeleteData(
                table: "RoomOpeningHours",
                keyColumns: new[] { "Closing", "Opening", "RoomId" },
                keyValues: new object[] { new DateTime(2022, 4, 8, 12, 45, 34, 180, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 8, 11, 45, 34, 180, DateTimeKind.Local).AddTicks(2959), 6L });

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

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4L,
                column: "Name",
                value: "Per1");

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CPR_number", "Discriminator", "Email", "HomeAddress", "IdentityNumber", "Name", "PhoneNumber" },
                values: new object[,]
                {
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
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5235), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5237), 2L, 2L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5246), 4L, 4L }
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
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5248), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5250), 5L, 5L },
                    { new DateTime(2022, 4, 8, 11, 10, 2, 837, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 4, 8, 12, 10, 2, 837, DateTimeKind.Local).AddTicks(5254), 6L, 6L }
                });
        }
    }
}
