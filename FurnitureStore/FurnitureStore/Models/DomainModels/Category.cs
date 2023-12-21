using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.Models.DomainModels
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Enter a category name")]
        public string CategoryName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter the category description")]
        public string CategoryDesc { get; set; } = string.Empty;

        public List<Furniture> Furnitures { get; set; } = null;
    }
}
