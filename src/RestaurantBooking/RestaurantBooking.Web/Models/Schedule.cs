namespace RestaurantBooking.Web.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }

        public Restaurant Restaurant { get; set; } = null!;
    }
}
