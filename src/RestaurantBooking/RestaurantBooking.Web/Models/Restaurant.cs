namespace RestaurantBooking.Web.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Table> Tables { get; set; } = new List<Table>();
        public ICollection<Menu> Menus { get; set; } = new List<Menu>();
    }
}
