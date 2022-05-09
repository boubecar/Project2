using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.Models
{
    public class Pole
    {
        
        public Guid PoleId { get; set;}
        public string PoleName { get; set;}
        public string image { get; set; }
        public ICollection<Filiale> Filiales { get; set; }



    }
}
