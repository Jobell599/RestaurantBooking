namespace RestaurantBooking.Web.Models
{
    public class RestaurantStaff
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        public Restaurant Restaurant { get; set; } = null!;
    }
}
