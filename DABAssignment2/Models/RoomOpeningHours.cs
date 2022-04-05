using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class RoomOpeningHours
    {
        public DateTime Opening { get; set; }
        public DateTime Closing { get; set; }
        public long RoomId { get; set; }
        public Room Room { get; set; }
    }
}
