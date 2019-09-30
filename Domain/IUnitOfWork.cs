using System;
using System.Threading.Tasks;
using repository_pattern.Domain.Repositories;

namespace repository_pattern.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IPublisherRepository Publishers { get; }
        IVideoGameRepository VideoGames { get; }

        Task<int> Complete();
    }


}