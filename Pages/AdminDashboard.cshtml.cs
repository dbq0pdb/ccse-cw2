using ccsecw1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ccsecw1.Pages
{
    [Authorize(Roles = "admin")]
    public class AdminDashboardModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUser? appUser;

        public AdminDashboardModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet()
        {
            var task = _userManager.GetUserAsync(User);
            task.Wait();
            appUser = task.Result;
        }
    }
}