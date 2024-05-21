using System;
using System.Threading.Tasks;
using ccsecw1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ccsecw1.Pages
{
    public class EditBookingModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        [BindProperty]
        public Booking Booking { get; set; }

        public EditBookingModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> OnGet(Guid id)
        {
            Booking = await _dbContext.Bookings.FindAsync(id);
            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dbContext.Attach(Booking).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return RedirectToPage("/CustomerDashboard");
        }
    }
}
