using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class LocationOpeningHours
    {
        public TimeOnly Opening { get; set; }
        public TimeOnly Closing { get; set; }
        public long LocationId { get; set; }
        public Locations Location { get; set; }
    }
}
