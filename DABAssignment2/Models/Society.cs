using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Society
    {
        public long SocietyId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(64)]
        public string Activity { get; set; }

        public long CVR_Number { get; set; }


        public List<SocietiesMember> SocietiesMembers { get; set; }

    }
}
