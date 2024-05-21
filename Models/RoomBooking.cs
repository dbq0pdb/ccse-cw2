namespace ccsecw1.Models
{
    public class RoomBooking
    {
        public Guid RoomBookingId { get; set; }
        public Guid RoomId { get; set; }

        // Navigators
        public Room Room { get; set; }
    }
}
