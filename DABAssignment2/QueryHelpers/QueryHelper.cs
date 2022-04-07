using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //var chairmen = await context.Chairmens.Select(c => new
            //{
            //    address = c.HomeAdress,
            //    CVR = c.SocietiesMembers.Select(sm => new
            //    {
            //        CVR = sm.Society.CVR_Number,
            //    }).ToList(),
            //    activity = c.SocietiesMembers.Select(sm => new
            //    {
            //        activity = sm.Society.Activity,
            //    }).ToList(),
            //    name = c.Name,

            //}).ToListAsync();

            var societies = await context.Societies.Select(s => new
            {
                cvr = s.CVR_Number,
                activity = s.Activity,
                name = s.SocietiesMembers.Where(sm => sm.SocietyId == s.SocietyId),

            }).ToListAsync();

            Console.WriteLine("Societies:");
            foreach (var society in societies)
            {

                Console.WriteLine($"Activity: {society.activity} CVR: {society.cvr}");
            }

        }

        public void ListBookings(MuniDbContext context)
        {

        }
    }
}
