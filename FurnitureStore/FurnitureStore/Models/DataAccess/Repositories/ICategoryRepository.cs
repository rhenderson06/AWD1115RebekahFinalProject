using FurnitureStore.Models.DomainModels;

namespace FurnitureStore.Models.DataAccess.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
