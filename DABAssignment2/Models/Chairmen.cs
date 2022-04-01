using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Chairmen
    {
        public long ChairmenId { get; set; }

        [MaxLength(64)]
        public string HomeAdress { get; set; }


    }
}
