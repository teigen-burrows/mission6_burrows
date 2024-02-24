using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission6_burrows.Models
{
    public class MovieForm // creates the form
    {
        [Key] // creates the primary key
        [Required] // makes field required
        public int MovieFormId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, int .MaxValue, ErrorMessage = "The year must be greater than or equal to 1888.")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
