using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using repository_pattern.Domain.Models;

namespace repository_pattern.Domain.Services
{
    public interface IVideoGamesService
    {
        Task<IEnumerable<VideoGame>> ListAsync();
    }
}