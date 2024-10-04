using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrialRazor.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public required string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Invalid Genre")]
        [Required]
        [StringLength(30)]
        public required string Genre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 999999999)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Invalid Rating")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; } = string.Empty;
    }
}