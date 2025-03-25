﻿using RestaurantBooking.Web.Enums;

namespace RestaurantBooking.Web.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Customer;
    }
}
