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
    public class AppUserConfiguration: IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> modelBuilder)
        {
            //appuser (one to one)

            modelBuilder.
                HasOne(x => x.AppUserDetail).
                WithOne(x => x.AppUser).
                HasForeignKey<AppUserDetail>(aud => aud.AppUserId);
        }
    }
}
