using Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<BoxStorage> BoxStorage { get; set; }
        public DbSet<BoxType> BoxTypes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DOC> DOCs { get; set; }
        public DbSet<Print> Prints { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBox> ProductBoxes { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BoxStorage>().HasKey(m => m.Id);
            builder.Entity<BoxType>().HasKey(m => m.Id);
            builder.Entity<Client>().HasKey(m => m.Id);
            builder.Entity<DOC>()
                .HasKey(m => m.Id);

            builder.Entity<DOC>()
                .Property(b => b.BoxesIn)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<Dictionary<BoxType, int>>(v));

            builder.Entity<Print>().HasKey(m => m.Id);
            builder.Entity<Product>().HasKey(m => m.Id);
            builder.Entity<ProductBox>().HasKey(m => m.Id);
            builder.Entity<Report>().HasKey(m => m.Id);

            base.OnModelCreating(builder);
        }
    }
}

