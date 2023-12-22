using FurnitureStore.Models.DataAccess.Repositories;
using FurnitureStore.Models.DomainModels;
using FurnitureStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureStore.Controllers
{
    public class CartController : Controller
    {
        private readonly IFurnitureRepository _furnRepository;
        private readonly Cart _cart;

        public CartController(IFurnitureRepository furnRepository, Cart cart)
        {
            _furnRepository = furnRepository;
            _cart = cart;
        }

        public ViewResult Index()
        {
            _cart.CartItems = _cart.GetCartItems();

            var CartViewModel = new CartViewModel
            {
                Cart = _cart,
                CartTotal = _cart.GetCartTotal()
            };

            return View(CartViewModel);
        }

        public RedirectToActionResult AddToCart(int furnId)
        {
            var selectedItem = _furnRepository.GetInventory
                                .FirstOrDefault(f => f.FurnitureID == furnId);

            if (selectedItem != null)
            {
                _cart.AddtoCart(selectedItem, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult DeleteFromCart(int furnId)
        {
            var selectedItem = _furnRepository.GetInventory
                                .FirstOrDefault(f => f.FurnitureID == furnId);

            if (selectedItem != null)
            {
                _cart.RemoveFromCart(selectedItem);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _cart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
