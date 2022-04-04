using Lab_06.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace Lab_06.Models
{
    public class EFVideoRepository : IVideoRepository
    {
        private ApplicationDbContext Context;
        public EFVideoRepository(ApplicationDbContext ctx)
        {
            Context = ctx;
        }
        public IQueryable<Video> Videos => Context.Videos.Where(el => el.IsDeleted == false);
        public IQueryable<Video> VideosWithUser => this.Videos
                .Include(el => el.User)
                .Include(el => el.VideoGenres)
                    .ThenInclude(el => el.Genre);

        public IQueryable<Video> VideosGetAll => this.Videos
            .Include(el => el.User)
            .Include(el => el.Comments).ThenInclude(el => el.User)
            .Include(el => el.VideoGenres)
                .ThenInclude(el => el.Genre);

        public async Task DeleteVideo(int id)
        {
            var video = await Context.Videos.FirstOrDefaultAsync(el => el.VideoId == id);
            if(video != null)
            {
                video.IsDeleted = true;
                Context.Update(video);
                await Context.SaveChangesAsync();
            }
        }

        public async Task<Video> SaveVideo(Video video)
        {
            var old = await Context.Videos.FirstOrDefaultAsync(el => el.VideoId == video.VideoId);
            if(old != null)
            {
                if(video.Name != null)
                {
                    old.Name = video.Name;
                }
                if(video.Description != null)
                {
                    old.Description = video.Description;
                }
                if(video.Price != null)
                {

                old.Price = video.Price;
                }
                if(video.Comments != null)
                {

                old.Comments = video.Comments ;
                }
                if(video.User != null)
                {

                old.User = video.User ;
                }
                if(video.EmbedHtml != null)
                {

                old.EmbedHtml = video.EmbedHtml;
                }
                if(video.Path != null)
                {

                old.Path = video.Path;
                }
                if(video.VideoGenres != null)
                {

                old.VideoGenres = video.VideoGenres;
                }
                old.UpdatedAt = System.DateTime.Now;
                Context.Videos.Update(old);
                await Context.SaveChangesAsync();
                return old;
            }
            return video;
        }

        public async Task<Video> CreateVideo(Video video)
        {
            video.User = await Context.Users.FirstOrDefaultAsync();
            await Context.Videos.AddAsync(video);
            await Context.SaveChangesAsync();
            return video;
        }

        // TODO Seed data. Controller View results for 11 & 12. Certain fields in models are nullable
    }
}
