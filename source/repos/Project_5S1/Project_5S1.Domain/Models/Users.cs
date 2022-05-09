using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.Models
{
    public class Users
    {
         
        public Guid userId { get; set; }
        public string userName { get; set; }
        public string userRole { get; set; }
        public string email { get; set; }
        public string userimage { get; set; }
        public string userpassword { get; set; }
        public ICollection<notation> notations { get; set; }


    }
}
