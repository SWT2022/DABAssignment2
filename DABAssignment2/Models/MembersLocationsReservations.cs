using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class MembersLocationsReservations
    {
        public DateTime ReservationBegin { get; set; }
        public DateTime ReservationEnd { get; set; }

        public long MemberId { get; set; }
        public Member Member { get; set; }
        public long LocationId { get; set; }
        public Location Location { get; set; }
    }
}
