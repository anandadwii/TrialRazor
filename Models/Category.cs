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
        [RegularExpression(@"^[a-zA-Z0-9_,.\s]*$", ErrorMessage = "illegal characters in name.")]
        public string Name { get; set; } = String.Empty;
        [Display(Name = "Order Number")]
        [Required]
        public int DisplayOrder { get; set; }
    }
}