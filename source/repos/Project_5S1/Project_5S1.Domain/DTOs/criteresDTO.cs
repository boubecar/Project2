using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Project_5S.Domain.Models;
namespace Project_5S.Domain.DTOs


{
    public class CriteresDTO
    {

        public Guid critereId { get; set; }
        public string criterelabel { get; set; }
        public int Index { get; set; }
        public Guid NormeId { get; set; }
        public string normename
        {
            get; set;

        }
        public CriteresDTO(criteres criterion, int index)
        {
            this.critereId = criterion.critereId;
            this.criterelabel = criterion.criterelabel;
            this.NormeId = criterion.NormeId;
            this.normename = criterion.Normes.designation;
            this.Index = index;
        }
        public CriteresDTO()
        {
        }
    }
   /* class groupedCriteresDTO
    {
        public Guid NormeId { get; set; }
        public string normename { get; set; }

        public ICollection<CriteresDTO> criterionDTOs { get; set; }
    }*/
}