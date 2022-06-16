using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class orderdetailsConfiguration : IEntityTypeConfiguration<order_details>
    {
        public void Configure(EntityTypeBuilder<order_details> builder)
        {
            builder.ToTable("order_details");
            builder.Property(p => p.ID);
            builder.Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.OrderId).IsRequired();
            builder.Property(p => p.TotalPrice).IsRequired();


        }
    }
}
