using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CodingWiki_Model.Models
{
    public class Book
    {
        [Key]
        public int IDBook { get; set; }
        public string Title { get; set; }
        [MaxLength(20)]
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        [NotMapped] 
        public string PriceRange { get; set; }
        public BookDetail BookDetail { get; set; }
        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }
        public List<Author> Authors { get; set; }
    }
}
