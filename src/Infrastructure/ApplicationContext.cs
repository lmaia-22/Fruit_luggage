using Domain;
using Microsoft.EntityFrameworkCore;

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
    }
}

