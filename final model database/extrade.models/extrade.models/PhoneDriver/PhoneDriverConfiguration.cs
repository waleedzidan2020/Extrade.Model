using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class phonedriverConfiguration : IEntityTypeConfiguration<PhoneDriver>
    {
        public void Configure(EntityTypeBuilder<PhoneDriver> builder)
        {
            builder.ToTable("PhoneDriver");
            builder.HasKey(p=>p.ID);
            builder.Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Number).IsRequired();
            builder.Property(p => p.Driverid).IsRequired();

        }
    }
}
