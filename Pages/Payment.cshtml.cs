using System;
using System.Threading.Tasks;
using ccsecw1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ccsecw1.Pages
{
    public class PaymentModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext; 

        [BindProperty]
        public decimal PaymentAmount { get; set; }

        public PaymentModel(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Add logic to process the payment and update the booking/payment details in the database

            return RedirectToPage("/customerDashboard");
        }
    }
}
