using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.QueryHelpers
{
    public class QueryHelper
    {
        public void ListRoomsNAddresses(MuniDbContext context)
        {
            var rooms = context.Rooms.ToList();
            foreach (var room in rooms)
            {
                Console.WriteLine($"Name: {room.Name} Address: {room.Address}");
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
