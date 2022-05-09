using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.Models
{
    public class Normes
    {
        
        public Guid normeId { get; set; }
        public string designation { get; set; }
        public ICollection<criteres> criteress { get; set; }
    }
}
