using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        [Key]
        public Guid  Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Author { get; set; }
        [Required]
        public double Price  { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(50)]
        public string Body { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
    }
}

