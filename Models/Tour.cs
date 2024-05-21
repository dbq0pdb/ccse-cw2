namespace ccsecw1.Models
{
    public class Tour
    {
        public Guid TourId { get; set; }

        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public string Description { get; set; } = "";
        public int Rating { get; set; }
        public string Location { get; set; } = "";
        public string Address { get; set; } = "";
        public int DurationDays { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal TotalTourPrice { get; set; }

        public int TotalSpaces { get; set; }
        public int TakenSpaces { get; set; }
        public int AvailableSpaces
        {
            get { return TotalSpaces - TakenSpaces; }
        }
    }
}