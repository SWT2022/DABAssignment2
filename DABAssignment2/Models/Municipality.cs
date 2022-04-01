using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Municipality
    {
        public long MunicipalityId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(64)]
        public string Country { get; set; }

        [MaxLength(64)]
        public string Mayor { get; set; }

        [MaxLength(64)]
        public string Region { get; set; }

        public List<Society> Societies { get; set; }    

        public List<Location> Locations { get; set; }



    }
}
