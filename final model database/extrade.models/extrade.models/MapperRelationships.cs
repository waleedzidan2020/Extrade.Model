using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace extrade.models
{
    public class MapperRelationships
    {
        public static void MapeRelationships(ModelBuilder builder)
        {
            //user=>phone
            builder.Entity<Phone>()
                 .HasOne(p => p.User).
                 WithMany(p => p.Phone).
                 HasForeignKey(p => p.UserID).
                 OnDelete(DeleteBehavior.Cascade);
            // vendor => vendor_image
            builder.Entity<VendorImage>()
                .HasOne(p => p.Vendor).
                WithMany(p => p.VendorImage).
                HasForeignKey(p => p.VendorID).
                OnDelete(DeleteBehavior.Cascade);
            //// vendor => users
            //builder.Entity<vendor>()
            //   .HasOne(p => p.users).
            //   WithOne(p => p.vendor).

            //   OnDelete(DeleteBehavior.Cascade);
            //// marketer=> users
            //builder.Entity<Markter>()
            // .HasOne(p => p.users).
            //    WithOne(p => p.markter)
            //    .HasForeignKey("u_id").
            // OnDelete(DeleteBehavior.Cascade);
            //// 

            //user=>marketer
            builder.Entity<User>()
            .HasOne<Markter>(i => i.Markter)
            .WithOne(ad => ad.User)
            .HasForeignKey<Markter>(ad => ad.UserID);

            
            //user=>vendor
            builder.Entity<User>()
           .HasOne<Vendor>(i => i.Vendor)
           .WithOne(ad => ad.User)
           .HasForeignKey<Vendor>(ad => ad.UserID);

            //user=>client

            builder.Entity<User>()
         .HasOne<MarkterClient>(i =>i.MarkterClient )
         .WithOne(ad => ad.User)
         .HasForeignKey<MarkterClient>(ad => ad.UserID);

            //product=>category


            builder.Entity<Product>()
                .HasOne(p => p.Category).
                WithMany(p => p.Product).
                HasForeignKey(p => p.CategeroyID).
                OnDelete(DeleteBehavior.Cascade);

            //product=>vendor

            builder.Entity<Product>()
              .HasOne(p => p.Vendor).
              WithMany(p => p.Product).
              HasForeignKey(p => p.VendorID).
              OnDelete(DeleteBehavior.Cascade);

            //market=>marketer
            builder.Entity<Market>()
                 .HasOne(p => p.Markter).
                 WithMany(p => p.Market).
                 HasForeignKey(p => p.MarkterID).
                 OnDelete(DeleteBehavior.Cascade);
            //marketDetails => market
            builder.Entity<MarketDetails>()
                 .HasOne(p => p.Market).
                 WithMany(p => p.MarketDetails).
                 HasForeignKey(p => p.MarketID).
                 OnDelete(DeleteBehavior.Cascade);

            //marketDetails => product
            builder.Entity<MarketDetails>()
                 .HasOne(p => p.Product).
                 WithMany(p => p.MarketDetails).
                 HasForeignKey(p => p.MarketID).
                 OnDelete(DeleteBehavior.Cascade);
             //clientphone => marketclient
            builder.Entity<ClientPhone>()
                 .HasOne(p => p.MarkterClient).
                 WithMany(p => p.ClientPhone).
                 HasForeignKey(p => p.ClientID).
                 OnDelete(DeleteBehavior.Cascade);
             //phonedriver => driver
            builder.Entity<PhoneDriver>()
                 .HasOne(p => p.Driver).
                 WithMany(p => p.PhoneDriver).
                 HasForeignKey(p => p.DriverID).
                 OnDelete(DeleteBehavior.Cascade);
            //oreder => user,driver
            builder.Entity<Order>()
                  .HasOne(p => p.User).WithMany(p => p.Order).
                  HasForeignKey(p => p.UserID).
                  OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>()
                .HasOne(p => p.Driver).
                WithMany(p => p.Order).
                HasForeignKey(p => p.DriverID).
                OnDelete(DeleteBehavior.Cascade);

            //orderdetails =>order,product
            builder.Entity<OrderDetails>()
                .HasOne(p => p.Order).
                WithMany(p => p.OrderDetails).
                HasForeignKey(p => p.OrderId).
                OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OrderDetails>().HasOne(p => p.Product).
               WithMany(p => p.OrderDetails).
               HasForeignKey(p => p.ProductId).
               OnDelete(DeleteBehavior.NoAction);


            //rating => product , user
            builder.Entity<Rating>().HasOne(p => p.Product).
                WithMany(p => p.Rating).
                HasForeignKey(p => p.ProductID).
                OnDelete(DeleteBehavior.NoAction);


            builder.Entity<Rating>().HasOne(p => p.User).
               WithMany(p => p.Rating).
               HasForeignKey(p => p.UserID  ).
               OnDelete(DeleteBehavior.Cascade);

            //Favourite => product , users
            builder.Entity<Favourite>().
                HasOne(p => p.Product).
                WithMany(p => p.Favourite).
                HasForeignKey(p => p.ProductID).
                OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Favourite>().
               HasOne(p => p.User).
               WithMany(p => p.Favourite).
               HasForeignKey(p => p.UserID).OnDelete(DeleteBehavior.Cascade);


            //cart => product , users
            builder.Entity<Cart>().
              HasOne(p => p.User).
              WithMany(p => p.Cart).
              HasForeignKey(p => p.UserID).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Cart>().
             HasOne(p => p.Product).
             WithMany(p => p.Cart).
             HasForeignKey(p=>p.ProductID).
             OnDelete(DeleteBehavior.NoAction);
             









        }
    }
}
