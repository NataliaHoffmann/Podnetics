namespace Podnetics.Models
{
    public class Episode
    {
        public int EpisodeID { get; set; } //PK

        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string AudioUrl { get; set; }
        public string? EpisodeImg { get; set; } // optional


        // FK: every Episode belongs to 1 Podcast
        public Podcast PodcastId { get; set; }

        // Parent ref to Podcast that the Episode belongs to
        public Podcast Podcast { get; set; }
    }
}
