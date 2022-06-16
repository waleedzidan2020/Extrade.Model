using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class MarketConfiguration : IEntityTypeConfiguration<Market>
    {
        public void Configure(EntityTypeBuilder<Market> builder)
        {
            builder.ToTable("Market");
            builder.HasKey(p=>p.ID);
            builder.Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.MarkterID).IsRequired();
            builder.Property(p => p.NameAr).HasDefaultValue(30).IsRequired();
            builder.Property(p => p.NameEN).HasDefaultValue(30).IsRequired();
            builder.Property(p => p.Code).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.Property(p => p.ModifiedDate).IsRequired().HasColumnType("date default getdate()");

        }
    }
}
