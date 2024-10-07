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
    [Authorize(Roles = "Maintainer")]
    public class Maintainer : PageModel
    {
        private readonly ILogger<Maintainer> _logger;

        public Maintainer(ILogger<Maintainer> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}