namespace RestaurantBooking.Web.Models
{
    public class Customer : Person
    {
        //public int Id { get; set; }
        //public string FullName { get; set; } = string.Empty;
        //public string Email { get; set; } = string.Empty;
        //public string Phone { get; set; } = string.Empty;

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
