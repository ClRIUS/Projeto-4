using BurguerMania.Models;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    }
}