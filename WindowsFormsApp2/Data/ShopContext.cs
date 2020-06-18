using Microsoft.EntityFrameworkCore;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Data
{ 
    public class ShopContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ShopAppDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().ToTable("Shop");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Item>().ToTable("Item");
        }
    }
}
