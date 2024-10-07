using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TrialRazor.Areas.Identity.Data;

public class RazorPagesMovieContext : IdentityDbContext<IdentityUser>
{
    public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
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
}
