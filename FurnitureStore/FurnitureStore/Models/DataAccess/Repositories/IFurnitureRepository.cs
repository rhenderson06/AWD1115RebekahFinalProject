using FurnitureStore.Models.DomainModels;

namespace FurnitureStore.Models.DataAccess.Repositories
{
    public interface IFurnitureRepository
    {
        IEnumerable<Furniture> GetInventory { get; }

        IEnumerable<Furniture> GetClearance { get; }

        Furniture GetFurnitureById(int furnId);
    }
}
