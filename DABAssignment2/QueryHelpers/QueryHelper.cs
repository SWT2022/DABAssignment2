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
            var rooms = await context.Rooms.ToListAsync();
            foreach (var room in rooms)
            {
                Console.WriteLine($"Name: {room.RoomId} Address: {room.Location.Address}");
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
