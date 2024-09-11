using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels
{
    public class Fluent_BookAuthorMap
    {
        [ForeignKey("Book")]
        public int IDBook { get; set; }
        [ForeignKey("Author")]
        public int Author_Id { get; set; }
        public Fluent_Book Book { get; set; }
        public Fluent_Author Author { get; set; }
    }
}
