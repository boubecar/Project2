﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.Models
{
    public class plan_action
    {
    
        public Guid planId { get; set; }
        public notation notation { get; set; }
        public Guid notationid { get; set; }
        public string Plandescription { get; set; }
        public string image { get; set; }
        public DateTime planDate { get; set; }
        
    }
}
