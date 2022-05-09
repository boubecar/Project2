using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.Models
{
    public class criteres
    {
         
        public Guid critereId { get; set; }
        public string criterelabel { get; set; }
        public Guid NormeId { get; set; }
        public Normes Normes { get; set; }
        public ICollection<notation> notations { get; set; }

    }
}
