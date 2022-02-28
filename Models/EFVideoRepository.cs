using Lab_06.Data;
using System.Linq;
namespace Lab_06.Models
{
    public class EFVideoRepository : IVideoRepository
    {
        private ApplicationDbContext Context;
        public EFVideoRepository(ApplicationDbContext ctx)
        {
            Context = ctx;
        }
        public IQueryable<Video> Videos => Context.Videos;
        // TODO Seed data. Controller View results for 11 & 12. Certain fields in models are nullable
    }
}
