namespace repository_pattern.Domain.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Sales { get; set; }
        public Publisher Publisher { get; set; }
    }
}