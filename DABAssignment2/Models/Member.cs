using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Member
    {
        public long MemberId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(64)]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string HomeAddress { get; set; }

        public int IdentityNumber { get; set; }

        public List<Society> Societies { get; set; }

        public List<MembersLocationsReservations> LocationsReservations { get; set; }

        public List<MembersRoomsReservations> RoomsReservations { get; set; }
    }
}
