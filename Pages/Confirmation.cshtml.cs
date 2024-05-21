using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ccsecw1.Models;

namespace ccsecw1.Pages
{
    public class ConfirmationModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        [BindProperty(SupportsGet = true)]
        public Guid BookingId { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            // Retrieve the booking reference number for the selected user
            var booking = await _dbContext.Bookings.FirstOrDefaultAsync(b => b.BookingId == BookingId);
            if (booking != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/Error"); // Redirect to an error page if the booking is not found
            }
        }
    }
}
