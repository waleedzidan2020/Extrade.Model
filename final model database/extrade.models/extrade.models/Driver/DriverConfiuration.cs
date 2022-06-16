using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class driverConfiuration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable("Driver");
            builder.HasKey(p => p.DriverID);
            builder.Property(p => p.DriverID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.DrivernameAr).HasMaxLength(40).IsRequired();
            builder.Property(p => p.DrivernameEn).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Country).HasMaxLength(40).IsRequired();
            builder.Property(p => p.City).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Street).HasMaxLength(40).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.Property(p => p.ModifiedDate).IsRequired().HasColumnType("date default getdate()");



        }
    }
}
