namespace ccsecw1.Models
{
    public class Hotel
    {
        public Guid HotelId { get; set; }
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public string Description { get; set; } = "";
        public int Rating { get; set; }
        public string Location { get; set; } = "";
        public string Address { get; set; } = "";

        public int SingleRoomPrice { get; set; }
        public int DoubleRoomPrice { get; set; }
        public int FamilyRoomPrice { get; set; }

        public IList<Room> Rooms { get; set; }

    }
}
 