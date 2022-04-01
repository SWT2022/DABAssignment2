using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Property
    {
        public long Id { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public ICollection<Location> Locations { get; set; }

    }
}
