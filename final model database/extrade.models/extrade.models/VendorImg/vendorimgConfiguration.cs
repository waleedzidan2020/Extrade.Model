using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class vendorimgConfiguration : IEntityTypeConfiguration<VendorImg>
    {
        public void Configure(EntityTypeBuilder<VendorImg> builder)
        {
            builder.ToTable("VendorImg");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.IDVendorImg).IsRequired();
            builder.Property(p => p.ImgWork).HasMaxLength(400).IsRequired();
            
            
        }
    }
}
