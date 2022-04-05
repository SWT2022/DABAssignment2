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
        public Location Location { get; set; }
        public string PropName { get; set; }
        public Properties Property { get; set; }
    }
}
