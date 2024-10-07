using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TrialRazor.Models;

namespace TrialRazor.Pages
{
    [Authorize]
    public class User : PageModel
    {
        private readonly ILogger<User> _logger;

        public ApplicationUser? appUser;
        private readonly UserManager<ApplicationUser> userManager;

        public User(ILogger<User> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        public void OnGet()
        {
            var task = userManager.GetUserAsync(User);
            task.Wait();
            ViewData["User"] = task.Result;
            appUser = task.Result;
        }
    }
}