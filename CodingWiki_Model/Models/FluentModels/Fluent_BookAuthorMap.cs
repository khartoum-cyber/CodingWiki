using System.ComponentModel.DataAnnotations;

namespace CodingWiki_Model.Models.FluentModels
{
    public class Fluent_BookAuthorMap
    {
        [Key]
        public int IDBook { get; set; }
        public int Author_Id { get; set; }
        public Fluent_Book Book { get; set; }
        public Fluent_Author Author { get; set; }
    }
}
