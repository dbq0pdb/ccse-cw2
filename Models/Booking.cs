using ccsecw1.Models;

namespace ccsecw1.Models
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public string CustomerNumber { get; set; } = "";

        public Guid RoomBookingId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Guid TourBookingId { get; set; }
        public DateTime TourCheckInDate { get; set; }
        public DateTime TourCheckOutDate { get; set; }

        public int DiscountPercentage { get; set; }
        public int TotalPrice { get; set; }

        public bool Cancelled { get; set; } = false;
        public bool Fulfilled { get; set; } = false;
        public bool fulfilled { get; set; } = false;

        // Navigators
        public ApplicationUser ApplicationUser { get; set; }
    }
}