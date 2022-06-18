using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace extrade.models
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("vendor");
            builder.HasKey(p => p.VendorID);
            builder.Property(p => p.UserID).IsRequired(); 
            builder.Property(p => p.BrandNameAr).HasMaxLength(20).IsRequired();
            builder.Property(p => p.BrandNameEr).HasMaxLength(20).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            

        }
    }
}
