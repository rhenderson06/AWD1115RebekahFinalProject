namespace FurnitureStore.Models.DomainModels
{
    public class CartItem
    {
        public int CartItemID { get; set; }
        public string? CartID { get; set; }
        public Furniture Furniture { get; set; }
        public int Amount { get; set; }
    }
}
