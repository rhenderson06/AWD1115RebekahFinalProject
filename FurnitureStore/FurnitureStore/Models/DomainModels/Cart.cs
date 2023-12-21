using FurnitureStore.Models.DataAccess;

namespace FurnitureStore.Models.DomainModels
{
    public class Cart
    {
        private readonly FurnitureContext _context;
        public string? CartID { get; set; }
        public List<CartItem> CartItems { get; set; }

        public Cart(FurnitureContext context) => _context = context;

        public static Cart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<FurnitureContext>();
            //create a shopping cart if one doesn't exist
            string cartID = session.GetString("CartID") ?? Guid.NewGuid().ToString();
            session.SetString("CartID", cartID);

            return new Cart(context)
            {
                CartID = cartID
            };
        }

        public void AddtoCart(Furniture furn, int amount)
        {
            var cartItem = _context.CartItems.SingleOrDefault(
                c => c.Furniture.FurnitureID == furn.FurnitureID && c.CartID == CartID);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    CartID = CartID,
                    Furniture = furn,
                    Amount = amount
                };

                _context.CartItems.Add(cartItem);
            }
            else
            {
                cartItem++;
            }
        }

        public int RemoveFromCart(Furniture furn)
        {
            var cartItem = _context.CartItems.SingleOrDefault(
                                c => c.Furniture.FurnitureID == furn.FurnitureID && c.CartID == CartID);

            var localAmount = 0;

            if (cartItem != null)
            {
                if (cartItem.Amount > 1)
                {
                    cartItem.Amount--;
                    localAmount = cartItem.Amount;
                }
                else
                {
                    CartItems.Remove(cartItem);
                }
            }

            _context.SaveChanges();

            return localAmount;
        }

        public List<CartItem> GetCartItems()
        {
            return CartItems ?? (CartItems = _context.CartItems
                                                     .Where(f => f.CartID == CartID)
                                                     .Include(f => f.Furniture)
                                                     .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _context.CartItems
                                    .Where(c => c.CartID == CartID);

            _context.CartItems.RemoveRange(cartItems);

            _context.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var total = _context.CartItems
                                    .Where(c => c.CartID == CartID)
                                    .Select(c => c.Furniture.FurniturePrice * c.Amount).Sum();
            return total;
        }
    }
}
