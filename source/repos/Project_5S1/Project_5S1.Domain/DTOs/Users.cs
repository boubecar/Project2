using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Domain.DTOs
{
    public class UsersDTO
    {
        [Key]
        public Guid userId { get; set; }
        public String userName { get; set; }
        public String userRole { get; set; }
        public String email { get; set; }
        public String userimage { get; set; }
        public String userpassword { get; set; }

    }
}
