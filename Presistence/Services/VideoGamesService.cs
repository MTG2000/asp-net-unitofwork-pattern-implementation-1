using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using repository_pattern.Domain;
using repository_pattern.Domain.Models;
using repository_pattern.Domain.Services;

namespace repository_pattern.Presistence.Services
{
    class VideoGamesService : IVideoGamesService
    {
        private readonly IUnitOfWork unitOfWork;

        public VideoGamesService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        async public Task<IEnumerable<VideoGame>> ListAsync()
        {
            return await unitOfWork.VideoGames.GetAllAsync();
        }
    }
}