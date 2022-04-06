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
                Address = context.Locations.Where(l => l.LocationId == r.LocationId)
                    .Select(l => l.Address).ToList(),
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

        public void ListBookings(MuniDbContext context)
        {

        }
    }
}
