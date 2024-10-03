using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrialRazor.Models
{
    public class Category
    {
        [Key] // must use this if Id is not a primary key
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Use letters and numbers only please")]
        public string Name { get; set; } = String.Empty;
        [Display(Name = "Order Number")]
        [Required]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only")]
        public int DisplayOrder { get; set; }
    }
}