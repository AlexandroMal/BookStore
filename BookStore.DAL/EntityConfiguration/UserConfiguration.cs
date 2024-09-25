using BookStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.Surname).HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);

        }
    }
}
