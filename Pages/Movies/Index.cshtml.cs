using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrialRazor.Data;
using TrialRazor.Models;

namespace TrialRazor.Pages_Movies
{
    public class IndexModel : PageModel
    {
        private readonly TrialRazor.Data.TrialRazorContext _context;

        public IndexModel(TrialRazor.Data.TrialRazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
