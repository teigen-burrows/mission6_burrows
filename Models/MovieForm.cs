using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission6_burrows.Models
{
    public class MovieForm // creates the form
    {
        [Key] // creates the primary key
        [Required] // makes field required
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // allows database to generate the primary key on creation
        public int MovieFormId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
    }
}
