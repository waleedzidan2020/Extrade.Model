using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    internal class CientPhoneconfiguration : IEntityTypeConfiguration<CientPhone>
    {
        public void Configure(EntityTypeBuilder<CientPhone> builder)
        {
            builder.ToTable("CientPhone");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.ClientID).IsRequired();
            builder.Property(p => p.Number).IsRequired();
        }
    }
}
