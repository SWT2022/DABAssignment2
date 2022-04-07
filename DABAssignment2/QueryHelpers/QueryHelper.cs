using System;
using System.Collections.Generic;
using System.Linq;
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

        public void ListSocietiesByActivity(MuniDbContext context)
        {

        }

        public async void ListBookings(MuniDbContext context)
        {
            // Get all room Ids and their address
            //var rooms = await context.Rooms.Select(r => new
            //{
            //    Id = r.RoomId,
            //    Address = r.Location.Address,
            //}).ToListAsync();

            //// Dont think works
            //var societies = await context.Societies.Select(s => new
            //{
            //    Name = s.Name,
            //    Members = s.SocietiesMembers.Where(sm => sm.SocietyId == s.SocietyId)
            //        .Select(sm => new
            //    {
            //            Member = sm.Member,
            //    }).ToList(),
            //}).ToListAsync();

            var reservations = await context.MembersRoomsReservations.Select(mrr => new
            {
                startTime = mrr.ReservationBegin,
                endTime = mrr.ReservationEnd,
                RoomAddress = mrr.Room.Location.Address,
                RoomId = mrr.Room.RoomId,
                SocietyName = mrr.Member.SocietiesMembers.Where(sm => sm.MemberId == mrr.MemberId).Select(sm => new
                {
                    SocietyName = sm.Society.Name,
                }).FirstOrDefault(),
                Reserver = mrr.Member.Name,
            }).ToListAsync();

            foreach (var reservation in reservations)
            {
                Console.WriteLine($"Room with Id {reservation.RoomId} at address {reservation.RoomAddress} is reserved in the" +
                                  $" between {reservation.startTime} - {reservation.endTime} by {reservation.SocietyName.SocietyName}. " +
                                  $"Reservation was made by {reservation.Reserver}");
            }
        }
    }
}
