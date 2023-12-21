using FurnitureStore.Models.DomainModels;

namespace FurnitureStore.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Furniture>? Clearance { get; set; }
    }
}
