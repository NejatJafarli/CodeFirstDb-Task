using ConsoleApp11.Configuration;
using ConsoleApp11.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserDetail> AppUserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        //Data Source=DESKTOP-E5M7S6J;Initial Catalog=PhoneShop;Integrated Security=True;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-E5M7S6J;Initial Catalog=PhoneShop;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<OrderDetail>().Ignore("Id");
            //modelBuilder.Entity<OrderDetail>().HasKey("OrderId", "ProductId");

            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration());
            //modelBuilder.ApplyConfiguration(new AppUserDetailConfiguration());



            base.OnModelCreating(modelBuilder);
        }
    }
}
