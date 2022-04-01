using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class LocationHolidays
    {
        public DateOnly Holiday { get; set; }
        public long LocationId { get; set; }
        public Locations Location { get; set; }
    }
}
