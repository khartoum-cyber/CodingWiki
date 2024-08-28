using System.ComponentModel.DataAnnotations;

namespace CodingWiki_Model.Models
{
    public class Genre
    {
        [Key]
        public int IDGenre { get; set; }

        public string GenreName { get; set; }

        public int DisplayOrder { get; set; }
    }
}
