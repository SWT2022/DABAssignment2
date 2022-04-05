using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class RoomHolidays
    {
        public DateTime Holiday { get; set; }
        public long RoomId { get; set; }
        public Room Room { get; set; }
    }
}
