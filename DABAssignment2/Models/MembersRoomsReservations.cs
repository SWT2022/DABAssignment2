using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class MembersRoomsReservations
    {
        public DateTime ReservationBegin { get; set; }
        public DateTime ReservationEnd { get; set; }

        public long MemberId { get; set; }
        public Member Member { get; set; }
        public long RoomId { get; set; }
        public Room Room { get; set; }
    }
}
