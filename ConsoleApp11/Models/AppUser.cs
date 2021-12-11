using ConsoleApp11.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        [NotMapped]
        public string RePassword { get; set; }
        public virtual AppUserDetail AppUserDetail { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}
