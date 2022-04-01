using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Members
    {
        public long MemberId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(64)]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public ICollection<SocietiesMembers> SocietiesMembers { get; set; }

        public ICollection<MembersLocationsReservations> Reservations { get; set; }
    }
}
