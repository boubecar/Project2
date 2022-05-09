using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.DTOs
{
    public class SaisieFilialeDTO
    {
        
        public Guid FilialId { get; set;}
        public String filialName { get; set;}

        public string polename { get; set; }

    }
}
