using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Project_5S.Domain.Models;
namespace Project_5S.Domain.DTOs
{
    public class PoleDTO
    {
        [Key]
        public Guid PoleId { get; set; }
        public String PoleName { get; set; }
        public String image { get; set; }


    }
}
