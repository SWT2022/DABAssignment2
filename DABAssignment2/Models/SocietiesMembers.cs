﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DABAssignment2.Models
{
    public class SocietiesMembers
    {
        public long SocietiesMembersId { get; set; }
        public long SocietyId { get; set; }
        public Societies Society { get; set; }
        public long MemberId { get; set; }
        public Members Member { get; set; }

    }
}