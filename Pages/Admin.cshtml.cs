using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TrialRazor.Pages
{
    [Authorize(Roles = "Super Administrator,Admin")]

    public class Admin : PageModel
    {
        private readonly ILogger<Admin> _logger;

        public Admin(ILogger<Admin> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}