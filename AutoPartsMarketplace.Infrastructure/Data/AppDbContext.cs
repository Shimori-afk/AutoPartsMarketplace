using AutoPartsMarketplace.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoPartsMarketplace.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Part> Parts => Set<Part>();
        public DbSet<Category> Categories => Set<Category>();
    }
}