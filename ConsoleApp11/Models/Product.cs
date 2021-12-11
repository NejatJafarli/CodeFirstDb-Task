using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal? UnitPrice { get; set; }
        public short UnitInStock { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
