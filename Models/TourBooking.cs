namespace ccsecw1.Models
{
    public class TourBooking
    {
        public Guid TourBookingId { get; set; }
        public Guid TourId { get; set; }


        // Navigators
        public Tour Tour { get; set; }
    }
}
