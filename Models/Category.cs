using System.ComponentModel.DataAnnotations;

namespace mission6_burrows.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
