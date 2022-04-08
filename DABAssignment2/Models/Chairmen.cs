using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class Chairmen : Member
    {
        [MaxLength(10)]

        public string CPR_number { get; set; }

    }
}
