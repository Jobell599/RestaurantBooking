using System.ComponentModel.DataAnnotations;

namespace RestaurantBooking.Web.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public bool Deleted { get; set; }
    }
}
