using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantBooking.Web.Models;

namespace RestaurantBooking.Web.Data
{
    public class RestaurantBookingDbContext : DbContext
    {
        public RestaurantBookingDbContext (DbContextOptions<RestaurantBookingDbContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantBooking.Web.Models.Person> Person { get; set; } = default!;
    }
}
