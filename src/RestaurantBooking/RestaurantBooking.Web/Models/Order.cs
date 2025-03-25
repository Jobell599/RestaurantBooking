namespace RestaurantBooking.Web.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Customer Customer { get; set; } = null!;
        public Restaurant Restaurant { get; set; } = null!;
    }
}
