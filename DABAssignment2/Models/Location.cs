using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Location
    {
        public long LocationId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Access_code { get; set; }

        [MaxLength(64)]
        public string Address { get; set; }

        public List<MembersLocationsReservations> Reservations { get; set; }


        public List<LocationsProperties> LocationsProperties { get; set; }

        public List<Room> Rooms { get; set; }

        public bool Availability { get; set; } 

        public List<LocationHolidays> Holidays { get; set; }
        public List<LocationOpeningHours> OpeningHours { get; set; }

    }
}
