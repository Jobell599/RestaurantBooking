using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RestaurantBooking.Web.Models;

namespace RestaurantBooking.Web.Data
{
    public class RestaurantBookingDbContext: DbContext
    {
        public RestaurantBookingDbContext(DbContextOptions<RestaurantBookingDbContext> options) : base(options)
        { }
            public DbSet<Person> People { get; set; }
        
    }
}
