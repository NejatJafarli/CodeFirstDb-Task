using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Category:BaseEntity
    {
        [Column (TypeName ="nvarchar(15)")]
        [Required]
        public string CategoryName { get; set; }

        [Column (TypeName ="ntext")]
        public string Description { get; set; }

        public  virtual List<Product> Products { get; set; }
    }
}
