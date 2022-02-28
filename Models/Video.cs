using System.Collections.Generic;
namespace Lab_06.Models
{
    public class Video : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
