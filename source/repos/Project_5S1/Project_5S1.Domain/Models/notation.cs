using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.Models
{
    public class notation
    {
         
        public Guid Id { get; set; }
        public float note { get; set; }
        public string comment { get; set; }
        public string image { get; set; }
        public DateTime date_notation { get; set; }
        public criteres criteres { get; set; }
        public Guid critereid { get; set; }
        public Users User { get; set; }
        public Guid Userid { get; set; }
        //public Guid evaluer { get; set; }
        public FilLocal FilLocal { get; set; }
        public Guid FilLocalid { get; set; }
        public ICollection<plan_action> plan_Actions { get; set; }

    }
}
