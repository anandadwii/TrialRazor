using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TrialRazor.Data;
using TrialRazor.Models;

namespace TrialRazor.Pages.Categories
{
    public class Create : PageModel
    {
        

        private readonly TrialRazorContext _context;

        public Create(TrialRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(Category.Name == Category.DisplayOrder.ToString()){
                ModelState.AddModelError(string.Empty, "The DisplayOrder cannot exactly match the Name.");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }
            var existingCategory = _context.Category.FirstOrDefault(x => x.Name == Category.Name && x.DisplayOrder == Category.DisplayOrder);

            if (existingCategory != null)
            {
                ModelState.AddModelError("Category.DisplayOrder", "Order Number already exists.");
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();
            TempData["success"] = "Category created successfully.";

            return RedirectToPage("./Index");
        }
    }
}