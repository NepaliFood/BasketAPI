﻿namespace BasketAPI.Entities
{
    public class ShoppingCartItem
    {
        public int Quantity { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
}