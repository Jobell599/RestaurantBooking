﻿namespace RestaurantBooking.Web.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public Menu Menu { get; set; } = null!;
    }
}
