using ccsecw1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ccsecw1.Pages
{
    [Authorize(Roles = "manager")]
    public class ManagerDashboardModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _dbContext;

        public ApplicationUser? appUser;
        public IEnumerable<Booking> Bookings { get; set; }

        public ManagerDashboardModel(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
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
                Bookings = _dbContext.Bookings;
            }
        }
    }
}