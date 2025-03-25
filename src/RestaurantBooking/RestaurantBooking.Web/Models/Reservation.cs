using RestaurantBooking.Web.Enums;

namespace RestaurantBooking.Web.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReservationDate { get; set; }
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public Table Table { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
    }
}
