using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.Models.DomainModels
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(20)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter your address")]
        [Display(Name = "Address")
        [StringLength(50)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter your city")]
        [Display(Name = "City")]
        [StringLength(25)]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter your state abbreviation")]
        [Display(Name = "State")]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter your zip code")]
        [Display(Name = "Zip Code")]
        [StringLength(5, MinimumLength = 5)]
        public string Zip { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [StringLength(5, MinimumLength = 5)]
        public string Phone { get; set; } = string.Empty;

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; } = 0.0m;

        [BindNever]
        public DateTime OrderPlaced { get; set; } = DateTime.Now;




    }
}
