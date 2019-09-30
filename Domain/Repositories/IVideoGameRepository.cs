using System.Collections.Generic;
using System.Threading.Tasks;
using repository_pattern.Domain.Models;

namespace repository_pattern.Domain.Repositories
{
    public interface IVideoGameRepository : IRepository<VideoGame>
    {
        Task<IEnumerable<VideoGame>> TopSellingGames(int pageSize);
    }
}