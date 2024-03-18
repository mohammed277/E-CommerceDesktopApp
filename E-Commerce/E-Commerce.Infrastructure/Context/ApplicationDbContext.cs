using E_Commerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TDQADM2\\AHMEDSABER;Initial Catalog=EcommerceDesktopDB;Integrated Security=True;encrypt=false");
           // optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=EcommerceDesktopDB;Trusted_Connection=True;MultipleActiveResultSets=true;encrypt=false");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Order>().Property(e => e.ID).ValueGeneratedOnAdd();
            //modelBuilder.Entity<User>().Property(e => e.ID).ValueGeneratedOnAdd();
            //modelBuilder.Entity<Category>().Property(e => e.ID).ValueGeneratedOnAdd();
            //modelBuilder.Entity<Product>().Property(e => e.ID).ValueGeneratedOnAdd();
            //modelBuilder.Entity<OrderDetails>().Property(e => e.ID).ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);
        }
    }
}
