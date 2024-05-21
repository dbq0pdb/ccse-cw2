using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace ccsecw1.Models
{
    public class ApplicationUser : IdentityUser
    {
        // table columns
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
        public string PassPortNumber { get; set; } = "";
        
        // added randomized guid for the customer number
        public Guid CustomerNumber { get; set; }
        public DateTime CreatedAt { get; set; }


        public List<Booking> Bookings { get; set; }
    }
}
