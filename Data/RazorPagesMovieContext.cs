using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrialRazor.Models;

namespace TrialRazor.Data
{
    public class TrialRazorContext : DbContext
    {
        public TrialRazorContext (DbContextOptions<TrialRazorContext> options)
            : base(options)
        {
        }

        public DbSet<TrialRazor.Models.Movie> Movie { get; set; } = default!;

        public DbSet<TrialRazor.Models.Category> Category { get; set; } = default!;
    }
}
