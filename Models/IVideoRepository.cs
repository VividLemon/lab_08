using System.Linq;
using System.Threading.Tasks;
namespace Lab_06.Models
{
    public interface IVideoRepository
    {
        IQueryable<Video> Videos { get; }
        IQueryable<Video> VideosWithUser { get; }
        IQueryable<Video> VideosGetAll { get; }

        Task<Video> CreateVideo(Video video);
        Task<Video> SaveVideo(Video video);
        Task DeleteVideo(int videoId);
    }
}
