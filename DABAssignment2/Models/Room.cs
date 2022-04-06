using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Room
    {

        public long RoomId { get; set; }


        public int Capacity { get; set; }

        public int Access_code { get; set; }

        public long LocationId { get; set; }

        public Location Location { get; set; }


        public List<MembersRoomsReservations> Reservations { get; set; }

        public List<RoomHolidays> Holidays { get; set; }
        public List<RoomOpeningHours> OpeningHours { get; set; }


    }
}
