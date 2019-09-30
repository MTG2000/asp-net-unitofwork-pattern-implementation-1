
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using repository_pattern.Domain.Models;
using repository_pattern.Domain.Services;

namespace repository_pattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<GamesController> _logger;
        private readonly IVideoGamesService service;

        public GamesController(ILogger<GamesController> logger, IVideoGamesService _service)
        {
            _logger = logger;
            service = _service;
        }

        [HttpGet]
        public async Task<IEnumerable<VideoGame>> Get()
        {
            var games = await service.ListAsync();
            return games;
        }
    }
}
