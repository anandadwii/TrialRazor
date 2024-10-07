using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TrialRazor.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; } = string.Empty;
        public int IsActive { get; set; } = 1;

        public DateTime? LastLogin { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        
    }
}