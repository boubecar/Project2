using System;
using System.Collections.Generic;
using System.Text;
using Project_5S.Domain.DTOs;

namespace Project_5S1.Domain.DTOs
{
   public class groupedCriteresDTO
    {
        public Guid NormeId { get; set; }
        public string normename { get; set; }

        public ICollection<CriteresDTO> criterionDTOs { get; set; }
    }
}
