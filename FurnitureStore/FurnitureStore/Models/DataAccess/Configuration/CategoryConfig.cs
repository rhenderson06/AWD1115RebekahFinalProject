using FurnitureStore.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace FurnitureStore.Models.DataAccess.Configuration
{
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasData(
                new Category { CategoryID = 1, CategoryName = "Couches" },
                new Category { CategoryID = 2, CategoryName = "Accent Chairs" },
                new Category { CategoryID = 3, CategoryName = "Side Tables" },
                new Category { CategoryID = 4, CategoryName = "Consoles/Cabinets" },
                new Category { CategoryID = 5, CategoryName = "Dining Tables" },
                new Category { CategoryID = 6, CategoryName = "Dining Chairs" },
                new Category { CategoryID = 7, CategoryName = "Dining Benches" },
                new Category { CategoryID = 8, CategoryName = "Bedframes" },
                new Category { CategoryID = 9, CategoryName = "Dressers" },
                new Category { CategoryID = 10, CategoryName = "Nightstands" },
                new Category { CategoryID = 11, CategoryName = "Dining Sets" },
                new Category { CategoryID = 12, CategoryName = "Desks" },
                new Category { CategoryID = 13, CategoryName = "Office Chairs" }
            );
        }
    }
}
