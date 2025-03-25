namespace RestaurantBooking.Web.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<MenuItem> Items { get; set; } = new List<MenuItem>();

        public Restaurant Restaurant { get; set; } = null!;
    }
}
