using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Product : BaseEntity
    {
        [Column(TypeName ="nvarchar(40)") ]
        [Required]
        public string ProductName { get; set; }

        [Column(TypeName ="nvarchar(20)") ]
        public string QuantityPerUnit { get; set; }

        [Column(TypeName ="money") ]
        public double UnitPrice { get; set; }

        [Column(TypeName ="smallint") ]
        public int UnitInStock { get; set; }

        [Column(TypeName ="smallint") ]
        public int UnitOnOrder { get; set; }

        [Column(TypeName ="smallint") ]
        public double ReorderLevel { get; set; }

        [Column(TypeName ="bit") ]
        public bool Discotinued { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public  virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
