using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TrialRazor.Data;
using TrialRazor.Models;

namespace TrialRazor.Pages.Categories
{
    public class Index : PageModel
    {
        private readonly TrialRazorContext _context;
        public IList<Category> Category { get; set; } = default!;

        public Index(TrialRazorContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }

        
    }
}