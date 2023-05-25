using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson16
{
    public class StoreNetworkContext: DbContext
    {
        public StoreNetworkContext(): base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Hillel\\Lesson16\\Lesson16\\Test.mdf; Integrated Security = True);");
        }

        public DbSet<StoreNetwork> StoreNetworks { get; set; }
        public DbSet<Store> Stores {get; set; } 
        public DbSet<Product> Products {get; set; }
        public DbSet<StoreProduct> StoreProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoreNetwork>(e =>
            { 
                 e.HasMany(s => s.Stores)
                 .WithOne(n => n.StoreNetwork)
                 .HasForeignKey(s => s.StoreNetwork);
            });
            modelBuilder.Entity<StoreProduct>(e =>
            { 
            e.HasKey(sp => new { sp.StoreId, sp.ProductId });
            });

            modelBuilder.Entity<StoreProduct>(e =>
            {                
           e.HasMany(s => s.Store)
           .HasForeignKey(sp => sp.StoreId);
            });
            modelBuilder.Entity<StoreProduct>(e =>
            {                
                e.HasMany(p => p.Store)
                .HasForeignKey(sp => sp.ProductId);
            });

        }   
        
    }
}
