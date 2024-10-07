using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrialRazor.Models;

namespace TrialRazor.Data
{
    public class TrialRazorContext : IdentityDbContext<IdentityUser>
    {
        public TrialRazorContext (DbContextOptions<TrialRazorContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var SuperAdministrator = new IdentityRole("Super Administrator")
            {
                NormalizedName = "SUPER ADMINISTRATOR"
            };

            var Administrator = new IdentityRole("Administrator")
            {
                NormalizedName = "ADMINISTRATOR"
            };

            var User = new IdentityRole("User")
            {
                NormalizedName = "USER"
            };

            var Maintainer = new IdentityRole("Maintainer")
            {
                NormalizedName = "MAINTAINER"
            };
            builder.Entity<IdentityRole>().HasData(SuperAdministrator, Administrator, User, Maintainer);


        }

        public DbSet<TrialRazor.Models.Movie> Movie { get; set; } = default!;

        public DbSet<TrialRazor.Models.Category> Category { get; set; } = default!;

        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;


    }
}
