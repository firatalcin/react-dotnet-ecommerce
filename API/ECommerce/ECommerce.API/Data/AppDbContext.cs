﻿using ECommerce.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                 new List<Product>
                 {
                    new Product
                    {
                        Id = 1,
                        Name = "IPhone 15",
                        Description = "Telefon Açıklaması",
                        Price = 70000,
                        IsActive = true,
                        ImageUrl = "1.jpg",
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "IPhone 16",
                        Description = "Telefon Açıklaması",
                        Price = 80000,
                        IsActive = true,
                        ImageUrl = "2.jpg",
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "IPhone 16 Pro",
                        Description = "Telefon Açıklaması",
                        Price = 90000,
                        IsActive = true,
                        ImageUrl = "3.jpg",
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "IPhone 16 Pro Max",
                        Description = "Telefon Açıklaması",
                        Price = 100000,
                        IsActive = true,
                        ImageUrl = "4.jpg",
                        Stock = 100
                    } 
                 });
                
        }
    }
}
