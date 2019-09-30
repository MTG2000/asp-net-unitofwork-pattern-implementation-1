using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using repository_pattern.Domain.Models;
using repository_pattern.Domain.Repositories;

namespace repository_pattern.Presistence.Repositories
{
    public class PublishersRepository : Repository<Publisher>, IPublisherRepository
    {
        public PublishersRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
        }

        async public Task<IEnumerable<Publisher>> TopSellingPublishers(int pageSize)
        {
            // var publishers = AppDbContext.VideoGames.GroupBy(v => v.Publisher).OrderBy(i => i.Count()).ToListAsync();
            return await AppDbContext.Publishers.ToListAsync();
            //    return publishers;

        }
    }
}