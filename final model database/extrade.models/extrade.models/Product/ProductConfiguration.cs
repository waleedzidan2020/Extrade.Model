﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extrade.models
{
    public class productConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p=>p.ID);
            builder.Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.productnameAr).HasMaxLength(40).IsRequired();
            builder.Property(p => p.ProductnameEn).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.ProductDescription).HasMaxLength(800).IsRequired();
            builder.Property(p => p.CategeroyID).IsRequired();
            builder.Property(p => p.VendorID).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.Property(p => p.ModifiedDate).IsRequired().HasColumnType("date default getdate()");




        }
    }
}