using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models
{
    [Table("tb_genres")]
    public class Genre
    {
        [Key]
        public int IDGenre { get; set; }

        [Column("Name")]
        public string GenreName { get; set; }

        public int DisplayOrder { get; set; }
    }
}
