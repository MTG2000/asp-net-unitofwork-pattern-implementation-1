using System.Collections.Generic;

namespace repository_pattern.Domain.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<VideoGame> VideoGames { get; set; }
    }
}