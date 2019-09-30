

using System.Threading.Tasks;
using repository_pattern.Domain;
using repository_pattern.Domain.Repositories;
using repository_pattern.Presistence.Repositories;

namespace repository_pattern.Presistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public UnitOfWork(AppDbContext _context)
        {
            context = _context;
            VideoGames = new VideoGamesRepository(context);

        }

        public IPublisherRepository Publishers { get; }

        public IVideoGameRepository VideoGames { get; private set; }

        async public Task<int> Complete()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}