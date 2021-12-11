using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Customer : BaseEntity
    {
        [Column(TypeName = "nvarchar(40)")]
        [Required]
        public string CompanyName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string ContactName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string ContactTitle { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string City { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string Region { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string PostalCode { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string Country { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public string Fax { get; set; }

        public  virtual List<Order> Orders { get; set; }
    }
}
