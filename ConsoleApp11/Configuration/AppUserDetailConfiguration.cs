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
    public class AppUserDetailConfiguration : IEntityTypeConfiguration<AppUserDetail>
    {
        public void Configure(EntityTypeBuilder<AppUserDetail> modelBuilder)
        {
            //modelBuilder.Property(x=>)
        }

    }
}
