using RestaurantBooking.Web.Enums;

namespace RestaurantBooking.Web.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public DateTime PaymentDate { get; set; }

        public Reservation Reservation { get; set; } = null!;
    }
}
