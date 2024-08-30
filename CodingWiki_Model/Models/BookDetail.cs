using System.ComponentModel.DataAnnotations;

namespace CodingWiki_Model.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetailId { get; set; }
        [Required]
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public string Weight { get; set; }
    }
}
