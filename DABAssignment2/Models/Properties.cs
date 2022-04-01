using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Properties
    {
        [MaxLength(64)]
        public string PropName { get; set; }

        public ICollection<LocationsProperties> LocationsProperties { get; set; }

    }
}
