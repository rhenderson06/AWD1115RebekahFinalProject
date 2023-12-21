using Microsoft.AspNetCore.Mvc;

namespace FurnitureStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
