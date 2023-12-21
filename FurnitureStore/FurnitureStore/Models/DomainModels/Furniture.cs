using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.Models.DomainModels
{
    public class Furniture
    {
        public int FurnitureID { get; set; }

        [Required(ErrorMessage = "Enter the furniture name")]
        public string FurnitureName { get; set; } = string.Empty;

        public string FurnitureDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter the furniture price")]
        [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
        public decimal FurniturePrice { get; set; }

        public string FurnitureImgUrl { get; set; } = string.Empty;

        public string FurnImgThumbNailUrl { get; set; } = string.Empty;

        public bool Clearance { get; set; } = false;

        public int CategoryID { get; set; }
        public Category? Category { get; set; }

    }
}
