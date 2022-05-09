using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.Models
{
    public class FilLocal
    {     
        public Guid LocallId { get; set; }
        public string localdescription { get; set; }
        public  Guid Filialeid { get; set; }
        public  Filiale Filiale { get; set; }
        public ICollection<notation> notations { get; set; }

    }
}
