using System.ComponentModel.DataAnnotations;

namespace CodingWiki_Model.Models.FluentModels
{
    public class Fluent_Book
    {
        [Key]
        public int IDBook { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public string PriceRange { get; set; }

        public Fluent_BookDetail BookDetail { get; set; }

        //[ForeignKey("Publisher")]
        //public int Publisher_Id { get; set; }
        //public Fluent_Publisher Publisher { get; set; }
        //public List<Fluent_Author> Authors { get; set; }
    }
}
