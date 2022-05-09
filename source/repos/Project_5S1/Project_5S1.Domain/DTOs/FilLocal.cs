using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Project_5S.Domain.Models;

namespace Project_5S.Domain.DTOs
{
    public class FilLocalDTO
    {    [Key]
        public Guid LocallId { get; set; }
        public string localdescription { get; set; }
        public string fliname { get; set; }
    }
}
