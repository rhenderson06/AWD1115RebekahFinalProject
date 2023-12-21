using FurnitureStore.Models.DomainModels;

namespace FurnitureStore.Models.ViewModels
{
    public class CartViewModel
    {
        public Cart? Cart { get; set; }
        public decimal CartTotal { get; set; } = 0.0m;
    }
}
