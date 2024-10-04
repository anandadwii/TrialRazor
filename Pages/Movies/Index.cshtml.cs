using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? SearchDate { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {

            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movie
                        select m;
            
            if(!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(x => x.Title.Contains(SearchString));
            }

            if(SearchDate != null)
            {
                movies = movies.Where(x => x.ReleaseDate == SearchDate);
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
