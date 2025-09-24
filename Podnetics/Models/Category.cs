namespace Podnetics.Models
{
    public class Category
    {
        public int CategoryID { get; set; } //PK
        public string Name { get; set; }

        // child ref to list of podcasts : 1 Category / Many Podcasts
        // must be nullable (?) so we can first create a Category without Podcasts, then attach Podcasts after
        public List<Podcast>? Podcasts { get; set; }
    }
}
