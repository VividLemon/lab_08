using System.Linq;
namespace Lab_06.Models
{
    public interface IVideoRepository
    {
        IQueryable<Video> Videos { get; }
    }
}
