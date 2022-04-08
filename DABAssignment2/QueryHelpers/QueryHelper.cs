using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DABAssignment2.Models;
using Microsoft.EntityFrameworkCore;

namespace DABAssignment2.QueryHelpers
{
    public class QueryHelper
    {
        public async void ListRoomsNAddresses(MuniDbContext context)
        {
            var rooms = await context.Rooms.Select(r => new
            {
                Id = r.RoomId,
                Address = r.Location.Address,
            }).ToListAsync();


            var locations = await context.Locations.ToListAsync();

            Console.WriteLine("Rooms:");
            foreach (var room in rooms)
            {

                Console.WriteLine($"Id: {room.Id} Address: {room.Address}");
            }

            Console.WriteLine("Locations:");
            foreach (var location in locations)
            {
                Console.WriteLine($"Name: {location.Name} Address: {location.Address}");
            }
        }

        public async void ListSocietiesByActivity(MuniDbContext context)
        {

            var societies = await context.Societies.OrderBy(s => s.Activity).Select(s => new
            {
                CVR = s.CVR_Number,
                Address = s.Address,
                Activity = s.Activity,
                Key_Responsable = s.Member.Name,
            }).ToListAsync();

            Console.WriteLine("Societies:");
            foreach (var society in societies)
            {
                Console.WriteLine($"Activity: {society.Activity} CVR: {society.CVR}" +
                                  $" Address: {society.Address} name: {society.Key_Responsable}");
            }

        }

        public async void ListBookings(MuniDbContext context)
        {
            var reservations = await context.MembersRoomsReservations.Select(mrr => new
            {
                startTime = mrr.ReservationBegin,
                endTime = mrr.ReservationEnd,
                RoomAddress = mrr.Room.Location.Address,
                RoomId = mrr.Room.RoomId,
                SocietyName = mrr.Member.Societies.Select(s =>  s.Name).ToList(),
                Key_Responsable = mrr.Member,
            }).ToListAsync();

            foreach (var reservation in reservations)
            {
                Console.WriteLine($"Room with Id {reservation.RoomId} at address {reservation.RoomAddress} is reserved" +
                                  $" between {reservation.startTime} - {reservation.endTime} by {String.Join("\n", reservation.SocietyName)} " +
                                  $"whose key responsable is " + (reservation.Key_Responsable.Name != null ? reservation.Key_Responsable.Name : "non existing.") + "\n");
            }
        }
        public async void ListFutureBookings(MuniDbContext context)
        {
            var futureBookings = await context.MembersRoomsReservations
                .Where(mrr => mrr.ReservationBegin > DateTime.Now)
                .Select(mrr => new
                {
                    startTime = mrr.ReservationBegin,
                    endTime = mrr.ReservationEnd,
                    RoomAddress = mrr.Room.Location.Address,
                    RoomId = mrr.Room.RoomId,
                    Access_code = mrr.Room.Access_code,
                    Key_addr = mrr.Room.Key_Address,
                }).ToListAsync();

            foreach (var booking in futureBookings)
            {
                Console.WriteLine($"Room with Id {booking.RoomId} at address {booking.RoomAddress} is reserved" +
                                  $" between {booking.startTime} - {booking.endTime}. " + "Access by " +
                                   (booking.Access_code == null ? ("key picked up at " + booking.Key_addr) : ("pin code " + booking.Access_code)) + "\n");
            }
        }
    }
}
