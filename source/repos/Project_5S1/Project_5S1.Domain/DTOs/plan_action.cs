using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Project_5S.Domain.Models;
namespace Project_5S.Domain.DTOs
{
    public class plan_actionDTO
    {
        [Key]
        public Guid planId { get; set; }
        public notation notation { get; set; }
        public String Plandescription { get; set; }
        public String image { get; set; }
        public DateTime planDate { get; set; }
        
    }
}
