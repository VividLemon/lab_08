using System.Collections.Generic;
namespace Lab_06.Models
{
    public class VideoGenre
    {
        public int VideoGenreId { get; set; }
        public Video Video { get; set; }
        public Genre Genre { get; set; }
    }
}
