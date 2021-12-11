using ConsoleApp11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Configuration
{
    public class OrderDetailConfiguration:IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> modelBuilder)
        {
            //order detail
            modelBuilder.Ignore(x => x.Id);
            modelBuilder.HasKey(x => new { x.OrderId, x.ProductId });
            //// Many to many
            modelBuilder.
                HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            modelBuilder.
              HasOne(od => od.Product)
              .WithMany(o => o.OrderDetails)
              .HasForeignKey(od => od.OrderId);
        }
    }
}
