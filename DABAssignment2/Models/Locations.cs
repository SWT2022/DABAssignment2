using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Locations
    {
        public long LocationId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Access_code { get; set; }

        [MaxLength(64)]
        public string Address { get; set; }

        public ICollection<MembersLocationsReservations> Reservations { get; set; }

        // public Municipality _Municipality { get; set; }

        public ICollection<LocationsProperties> LocationsProperties { get; set; }

        public List<Rooms> Rooms { get; set; }

        public bool Availability { get; set; } 

        public ICollection<LocationHolidays> Holidays { get; set; }
        public ICollection<LocationOpeningHours> OpeningHours { get; set; }

    }
}
