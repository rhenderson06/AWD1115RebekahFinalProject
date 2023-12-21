using FurnitureStore.Models.DomainModels;

namespace FurnitureStore.Models.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FurnitureContext _context;
        private readonly Cart _cart;

        public OrderRepository(FurnitureContext ctx, Cart cart)
        {
            _context = ctx;
            _cart = cart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _cart.GetCartTotal();

            _context.Orders.Add(order);
            _context.SaveChanges();

            var cartItems = _cart.GetCartItems();

            foreach (var cartItem in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = cartItem.Amount,
                    Price = cartItem.Furniture.FurniturePrice,
                    FurnitureID = cartItem.Furniture.FurnitureID,
                    OrderID = order.OrderID
                };

                _context.OrderDetails.Add(orderDetail);
            }

            _context.SaveChanges();
        }
    }
}
