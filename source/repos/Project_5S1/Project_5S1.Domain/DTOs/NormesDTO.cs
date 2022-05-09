using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Project_5S.Domain.DTOs
{
    public class NormesDTO
    {
        [Key]
        public Guid normeId { get; set; }
        public String designation { get; set; }
    }
}
