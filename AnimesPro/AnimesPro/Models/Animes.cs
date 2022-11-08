using System.ComponentModel.DataAnnotations;

namespace AnimesPro.Models
{
    public class Animes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public bool DeletedAnime { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
