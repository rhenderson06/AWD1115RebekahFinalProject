using FurnitureStore.Models.DomainModels;

namespace FurnitureStore.Models.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FurnitureContext _context;

        public CategoryRepository(FurnitureContext ctx) => _context = ctx;

        public IEnumerable<Category> GetCategories => _context.Categories;
    }
}
