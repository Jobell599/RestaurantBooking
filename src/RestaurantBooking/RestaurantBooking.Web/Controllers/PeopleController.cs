using Microsoft.AspNetCore.Mvc;
using RestaurantBooking.Web.Data;
using RestaurantBooking.Web.Models;

namespace RestaurantBooking.Web.Controllers
{
    public class PeopleController : Controller
    {
        private readonly RestaurantBookingDbContext _context;

        public PeopleController(RestaurantBookingDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var query = _context.People.Where(p => !p.Deleted);
            //query = query.Where(p => p.FullName.Contains("juan"));

            var general = new General();
            var people = query.ToList();

            ViewBag.Header = "This ";
            ViewBag.PeopleFromViewBag = people;
            general.People = people;
            return View(general);
        }
    }
}
