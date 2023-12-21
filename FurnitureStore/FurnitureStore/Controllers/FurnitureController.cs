using FurnitureStore.Models.DataAccess.Repositories;
using FurnitureStore.Models.DomainModels;
using FurnitureStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureStore.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly IFurnitureRepository _furnRepository;
        private readonly ICategoryRepository? _catRepository;

        public FurnitureController(IFurnitureRepository furnRepository, ICategoryRepository? catRepository)
        {
            _furnRepository = furnRepository;
            _catRepository = catRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Furniture> furnitures;
            string currentCategory;

            if (string.IsNullOrEmpty(category)) 
            {
                furnitures = _furnRepository.GetInventory
                                .OrderBy(f => f.FurnitureID);
                currentCategory = "All Furniture";
            }
            else
            {
                furnitures = _furnRepository.GetInventory
                                .Where(f => f.Category?.CategoryName == category);
                currentCategory = _catRepository?.GetCategories
                                .FirstOrDefault(currentCategory => currentCategory.CategoryName == category).CategoryName;
            }
            return View(new FurnitureListViewModel
            {
                Furnitures = furnitures,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var furniture = _furnRepository?.GetFurnitureById(id);

            if (furniture == null)
            {
                return NotFound();
            }
            return View(furniture);
        }
    }
}
