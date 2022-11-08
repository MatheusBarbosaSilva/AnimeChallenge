using System.ComponentModel.DataAnnotations;

namespace AnimesPro.Models.Entities.Animes
{
    public class PostAnimesRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Director { get; set; }
    }
}
