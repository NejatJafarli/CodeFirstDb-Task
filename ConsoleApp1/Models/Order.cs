using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Order : BaseEntity
    {
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime RequiredDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ShippedDate { get; set; }

        [Column(TypeName = "money")]
        public double Freight { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string ShipName { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string ShipAddress { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string ShipCity { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string ShipRegion { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string ShipPostalCode { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string ShipCountry { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public virtual Employer Employer { get; set; }
        public int EmployerId { get; set; }
        //employer elave et

    }
}
