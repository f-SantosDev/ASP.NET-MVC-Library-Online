using System.ComponentModel.DataAnnotations;

namespace ASP_Net_MVC_Library_Online.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string? Title { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        [Range(1000, int.MaxValue, ErrorMessage = "The year must be greater than 1000.")]
        public int YearOfPublish { get; set; }
        [Required]
        public string? Genre { get; set; }
    }
}
