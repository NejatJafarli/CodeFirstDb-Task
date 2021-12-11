using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    public class Order:BaseEntity
    {
        public int AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
