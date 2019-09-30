using System.Collections.Generic;
using System.Threading.Tasks;
using repository_pattern.Domain.Models;

namespace repository_pattern.Domain.Repositories
{
    public interface IPublisherRepository : IRepository<Publisher>
    {
        Task<IEnumerable<Publisher>> TopSellingPublishers(int pageSize);
    }
}