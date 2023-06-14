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
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Hillel\\Lesson16\\Lesson16\\Test.mdf;Integrated Security=True");
        }

        public DbSet<StoreNetwork> StoreNetworks { get; set; }
        public DbSet<Store> Stores {get; set; } 
        public DbSet<Product> Products {get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>()
          .HasOne(s => s.StoreNetwork)
          .WithMany(sn => sn.Stores)
          .HasForeignKey(s => s.StoreNetworkId);

            modelBuilder.Entity<Store>()
                .HasMany(s => s.Products)
                .WithMany(p => p.Stores)
                .UsingEntity(j => j.ToTable("StoreProduct"));

        }   
        
    }
}
