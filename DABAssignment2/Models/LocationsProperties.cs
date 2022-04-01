using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class LocationsProperties
    {
        public long LocationsPropertiesId { get; set; }
        public long LocationId { get; set; }
        public Locations Location { get; set; }
        public long PropertyId { get; set; }
        public Properties Property { get; set; }
    }
}
