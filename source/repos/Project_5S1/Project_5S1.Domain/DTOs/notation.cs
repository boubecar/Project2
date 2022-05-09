using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Project_5S.Domain.Models;
using System.Threading.Tasks;
namespace Project_5S.Domain.DTOs
    
{
    public class notationDTO
    {
        [Key]
        public Guid Id { get; set; }
        public float note { get; set; }
        public String comment { get; set; }
        public String image { get; set; }
        public DateTime date_notation { get; set; }
        public Guid Userid { get; set; }

        public FilLocal FilLocal { get; set; }

        //public Guid Userid { get; set; }
        //public Guid evaluer { get; set; }
        public Guid critereid { get; set; }

    }
}
