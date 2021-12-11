using ConsoleApp11.Context;
using ConsoleApp11.Models;
using System;

namespace ConsoleApp11
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context=new MyDbContext())
            {
                var user= new Product { Id = 1 };
                context.Attach(user);
                user.Name = "testy";
                context.SaveChanges();
            }
        }
    }
}
