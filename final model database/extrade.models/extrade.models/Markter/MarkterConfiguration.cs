using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class MarkterConfiguration : IEntityTypeConfiguration<Markter>
    {
        public void Configure(EntityTypeBuilder<Markter> builder)
        {
            builder.ToTable("Markter");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.UserID).IsRequired();
            builder.Property(p => p.TaxCard).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Salary).HasDefaultValue(0);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
               
        }
    }
}
