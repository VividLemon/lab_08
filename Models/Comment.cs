namespace Lab_06.Models
{
    public class Comment : BaseModel
    {
        public string Text { get; set; }
        public User User { get; set; }
        public Video Video { get; set; }
    }
}
