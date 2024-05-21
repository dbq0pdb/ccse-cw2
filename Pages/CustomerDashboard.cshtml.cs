using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ccsecw1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ccsecw1.Pages
{
    [Authorize(Roles = "customer")]
    public class UserDashboardModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _dbContext;

        public ApplicationUser? appUser;
        public List<Booking> UserBookings { get; set; }

        public UserDashboardModel(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public async Task OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                appUser = user;
                UserBookings = await _dbContext.Bookings
                    .Where(b => b.ApplicationUser.Id == user.Id)
                    .ToListAsync();
            }
        }

        public async Task<IActionResult> EditBooking(Guid bookingId)
        {
            var booking = await _dbContext.Bookings.FindAsync(bookingId);
            if (booking != null)
            {
                // Implement logic to allow the user to edit the booking
                // For example, you can redirect to a page where the user can modify the booking details
                return RedirectToPage("/EditBooking", new { id = bookingId });
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> CancelBooking(Guid bookingId)
        {
            var booking = await _dbContext.Bookings.FindAsync(bookingId);
            if (booking != null)
            {
                // Implement logic to cancel the booking
                booking.Cancelled = true;
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("/CustomerDashboard"); // Redirect back to the user dashboard page
            }
            else
            {
                return NotFound();
            }
        }
    }
}
