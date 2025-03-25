namespace RestaurantBooking.Web.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;

        public Customer Customer { get; set; } = null!;
        public Restaurant Restaurant { get; set; } = null!;
    }
}
