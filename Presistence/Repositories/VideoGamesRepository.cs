using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using repository_pattern.Domain.Models;
using repository_pattern.Domain.Repositories;

namespace repository_pattern.Presistence.Repositories
{
    public class VideoGamesRepository : Repository<VideoGame>, IVideoGameRepository
    {
        public VideoGamesRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<VideoGame>> TopSellingGames(int pageSize)
        {
            return await AppDbContext.VideoGames.OrderBy(v => v.Sales).Take(pageSize).ToListAsync();
        }
    }
}