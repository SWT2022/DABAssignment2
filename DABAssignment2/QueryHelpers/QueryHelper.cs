//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DABAssignment2.Models;
//using Microsoft.EntityFrameworkCore;

//namespace DABAssignment2.QueryHelpers
//{
//    public class QueryHelper
//    {
//        public async void ListRoomsNAddresses(MuniDbContext context)
//        {
//            var rooms = await context.Rooms.Select(r => new
//            {
//                Id = r.RoomId,
//                Address = r.Location.Address,
//            }).ToListAsync();


//            var locations = await context.Locations.ToListAsync();

//            Console.WriteLine("Rooms:");
//            foreach (var room in rooms)
//            {

//                Console.WriteLine($"Id: {room.Id} Address: {room.Address}");
//            }

//            Console.WriteLine("Locations:");
//            foreach (var location in locations)
//            {
//                Console.WriteLine($"Name: {location.Name} Address: {location.Address}");
//            }
//        }

//        public async void ListSocietiesByActivity(MuniDbContext context)
//        {
//            //var chairmen = await context.Chairmens.Select(c => new
//            //{
//            //    address = c.HomeAdress,
//            //    CVR = c.SocietiesMembers.Select(sm => new
//            //    {
//            //        CVR = sm.Society.CVR_Number,
//            //    }).ToList(),
//            //    activity = c.SocietiesMembers.Select(sm => new
//            //    {
//            //        activity = sm.Society.Activity,
//            //    }).ToList(),
//            //    name = c.Name,

//            //}).ToListAsync();

//            //var societies = await context.Chairmens.Select(c => new
//            //{
//            //    cvr = c.SocietiesMembers.Where(sm => sm.MemberId == c.MemberId).Select(sm => new
//            //    {
//            //        cvr = sm.Society.CVR_Number,
//            //    }).FirstOrDefault(),

//            //    activity = c.SocietiesMembers.Where(sm => sm.MemberId == c.MemberId).Select(sm => new
//            //    {
//            //        activity = sm.Society.Activity,
//            //    }).FirstOrDefault(),
//            //    name = c.Name,
//            //    address = c.HomeAdress,

//            //}).ToListAsync();

//            var chairmen = await context.Chairmens.Select(c => new
//            {
//                name = c.SocietiesMembers.Where(sm => sm.MemberId == c.MemberId),
//            }).ToListAsync();

//            var societies = await context.Societies.OrderBy(s => s.Activity).Select(s => new
//            {
//                name = s.SocietiesMembers.Where(sm => sm.MemberId == s.Society).Select(sm => new
//                {
//                    name = sm.Member.Name,
//                }).FirstOrDefault(),
//                //name = s.SocietiesMembers.Where(sm => sm.SocietyId == s.SocietyId).Select(sm => new
//                //{
//                //    name = sm.Member.Name,
//                //}).FirstOrDefault(),

//                cvr = s.CVR_Number,
//                address = s.Address,
//                activity = s.Activity

//            }).ToListAsync();

            



//            Console.WriteLine("Societies:");
//            foreach (var society in societies)
//            {

//                Console.WriteLine($"Activity: {society.activity} CVR: {society.cvr}" +
//                    $" Address: {society.address} name: {society.name.name}");
//            }

//        }

//        public async void ListBookings(MuniDbContext context)
//        {
//            // Get all room Ids and their address
//            //var rooms = await context.Rooms.Select(r => new
//            //{
//            //    Id = r.RoomId,
//            //    Address = r.Location.Address,
//            //}).ToListAsync();

//            //// Dont think works
//            //var societies = await context.Societies.Select(s => new
//            //{
//            //    Name = s.Name,
//            //    Members = s.SocietiesMembers.Where(sm => sm.SocietyId == s.SocietyId)
//            //        .Select(sm => new
//            //    {
//            //            Member = sm.Member,
//            //    }).ToList(),
//            //}).ToListAsync();

//            var reservations = await context.MembersRoomsReservations.Select(mrr => new
//            {
//                startTime = mrr.ReservationBegin,
//                endTime = mrr.ReservationEnd,
//                RoomAddress = mrr.Room.Location.Address,
//                RoomId = mrr.Room.RoomId,
//                SocietyName = mrr.Member.SocietiesMembers.Where(sm => sm.MemberId == mrr.MemberId).Select(sm => new
//                {
//                    SocietyName = sm.Society.Name,
//                }).FirstOrDefault(),
//                Reserver = mrr.Member.Name,
//            }).ToListAsync();

//            foreach (var reservation in reservations)
//            {
//                Console.WriteLine($"Room with Id {reservation.RoomId} at address {reservation.RoomAddress} is reserved in the" +
//                                  $" between {reservation.startTime} - {reservation.endTime} by {reservation.SocietyName.SocietyName}. " +
//                                  $"Reservation was made by {reservation.Reserver}");
//            }
//        }
//    }
//}
