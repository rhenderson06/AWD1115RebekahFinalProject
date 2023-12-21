﻿namespace FurnitureStore.Models.DomainModels
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int FurnitureID { get; set; }
        public Furniture Furniture { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
    }
}
