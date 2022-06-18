using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace extrade.models
{
    public class ExtradeContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<MarketDetails> MarketDetails { get; set; }
        public DbSet<Markter> Markters { get; set; }
        public DbSet<ClientPhone> ClientPhones { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorImage> VendorImgs { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<MarkterClient> MarkterClients { get; set; }
        public DbSet<PhoneDriver> PhoneDrivers { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new VendorImageConfiguration().Configure(modelBuilder.Entity<VendorImage>());
            new CartConfiguration().Configure(modelBuilder.Entity<Cart>());
            new categoryConfiguration().Configure(modelBuilder.Entity<Category>());
            new ClientPhoneconfiguration().Configure(modelBuilder.Entity<ClientPhone>());
            new driverConfiuration().Configure(modelBuilder.Entity<Driver>());
            new favouriteConfiguratin().Configure(modelBuilder.Entity<Favourite>());
            new MarketConfiguration().Configure(modelBuilder.Entity<Market>());
            new MarketDetailsConfiguration().Configure(modelBuilder.Entity<MarketDetails>());
            new MarkterConfiguration().Configure(modelBuilder.Entity<Markter>());
            new MarkterClientConficguration().Configure(modelBuilder.Entity<MarkterClient>());
            new OrderConfiguration().Configure(modelBuilder.Entity<Order>());
            new orderdetailsConfiguration().Configure(modelBuilder.Entity<OrderDetails>());
            new PhoneConfiguration().Configure(modelBuilder.Entity<Phone>());
            new productConfiguration().Configure(modelBuilder.Entity<Product>());
            new ratingConfiguration().Configure(modelBuilder.Entity<Rating>());
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new VendorConfiguration().Configure(modelBuilder.Entity<Vendor>());
            new phonedriverConfiguration().Configure(modelBuilder.Entity<PhoneDriver>());

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS; Initial Catalog = Extrade.Model; Integrated Security = True");
        }














    }
}
