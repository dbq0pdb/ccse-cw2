namespace ccsecw1.Models
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public Guid HotelId { get; set; }
        public string RoomNumber { get; set; } = "";
        public Guid RoomTypeId { get; set; }
        public decimal RoomPrice { get; set; }

        public Hotel Hotel { get; set; }
    }
}
