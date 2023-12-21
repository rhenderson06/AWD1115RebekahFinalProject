using FurnitureStore.Models.DataAccess.Configuration;
using FurnitureStore.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.Models.DataAccess
{
    public class FurnitureContext : DbContext
    {
        public FurnitureContext(DbContextOptions<FurnitureContext> options) : base(options) { }

        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new FurnitureConfig());
        }

    }
}
