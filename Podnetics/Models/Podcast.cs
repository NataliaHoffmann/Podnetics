namespace Podnetics.Models
{
    public class Podcast
    {
        // {name of the class}Id is the primary key already created by the program
        public int PodcastID { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; } // optional

        // child ref to list of episodes : 1 Podcast / Many Episodes
        // must be nullable (?) so we can first create a Podcast without Episodes, then attach Episodes after
        public List<Episode>? Episodes { get; set; }

        // FK: every Podcast belongs to 1 Category
        public int CategoryId { get; set; }

        // Parent ref to Category that the Podcast belongs to
        public Category Category { get; set; }
    }
}
