using ECommerce.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
