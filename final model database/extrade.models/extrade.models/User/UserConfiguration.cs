using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class UserConfiguration :IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.NameAr).HasMaxLength(30).IsRequired();
            builder.Property(p => p.NameEn).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Country).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Street).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Img).HasMaxLength(200);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.Property(p => p.ModifiedDate).IsRequired().HasColumnType("date default getdate()");


        }

       
    }
}
