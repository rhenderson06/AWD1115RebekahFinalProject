using FurnitureStore.Models;
using FurnitureStore.Models.DataAccess.Repositories;
using FurnitureStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FurnitureStore.Controllers
{
    public class HomeController : Controller
    {
        public readonly IFurnitureRepository _furnRepository;

        public HomeController(IFurnitureRepository furnRepository)
        {
            _furnRepository = furnRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Clearance = _furnRepository.GetClearance
            };

            return View(homeViewModel);
        }
    }
}