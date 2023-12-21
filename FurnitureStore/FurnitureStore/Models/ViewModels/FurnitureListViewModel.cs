using FurnitureStore.Models.DomainModels;

namespace FurnitureStore.Models.ViewModels
{
    public class FurnitureListViewModel
    {
        public IEnumerable<Furniture>? Furnitures { get; set; }

        public string? CurrentCategory { get; set; }
    }
}