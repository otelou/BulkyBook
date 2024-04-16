using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [System.ComponentModel.DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 1OO only!!")]
        public int DisplayOrder { get; set; }
        public DateTime createdDateTime { get; set; } = DateTime.Now;
    }
}
