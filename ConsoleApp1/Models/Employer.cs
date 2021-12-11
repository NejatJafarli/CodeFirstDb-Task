using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Employer:BaseEntity
    {
        [Column(TypeName ="nvarchar(10)")]
        [Required]
        public string FirstName { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        [Required]
        public string LastName {  get; set; }
        [Column(TypeName ="nvarchar(30)")]
        public string Title { get; set; }
        [Column(TypeName ="nvarchar(25)")]
        public string TitleOfCourtesy { get; set; }
        [Column(TypeName ="datetime")]
        public DateTime BirthDate { get; set; }
        [Column(TypeName ="datetime")]
        public DateTime HireDate { get; set; }
        [Column(TypeName ="nvarchar(60)")]
        public string Address { get; set; }
        [Column(TypeName ="nvarchar(15)")]
        public string City { get; set; }
        [Column(TypeName ="nvarchar(15)")]
        public string Region { get; set; }
        [Column(TypeName ="nvarchar(10)")]
        public string PostalCode { get; set; }
        [Column(TypeName ="nvarchar(15)")]
        public string Country { get; set; }
        [Column(TypeName ="nvarchar(24)")]
        public string HomePhone { get; set; }
        [Column(TypeName ="nvarchar(4)")]
        public string Extension { get; set; }
        [Column(TypeName ="ntext")]
        public string Notes { get; set; }
        [Column(TypeName ="nvarchar(255)")]
        public string PhotoPath { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}
