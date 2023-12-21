using FurnitureStore.Models.DomainModels;

namespace FurnitureStore.Models.DataAccess.Repositories
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
