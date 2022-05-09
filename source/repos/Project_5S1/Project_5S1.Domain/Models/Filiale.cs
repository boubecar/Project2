using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.Models
{
    public class Filiale
    {
        
        public Guid FilialId { get; set;}
        public string filialName { get; set;}
        public ICollection<FilLocal> FilLocals { get; set; }
        public Pole pole { get; set; }

        public Guid poleId { get; set; }


    }
}
