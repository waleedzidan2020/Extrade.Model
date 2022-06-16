using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class MarketDetailsConfiguration : IEntityTypeConfiguration<MarketDetails>
    {
        public void Configure(EntityTypeBuilder<MarketDetails> builder)
        {
            builder.ToTable("MarketDetails");
            builder.HasKey(p=> new {p.ProductID , p.MarketID });
            builder.Property(p => p.ProductID).IsRequired();
            builder.Property(p => p.MarketID).IsRequired();
            builder.Property(p => p.ModifiedDate).IsRequired().HasColumnType("date default getdate()");
        }
    }
}
