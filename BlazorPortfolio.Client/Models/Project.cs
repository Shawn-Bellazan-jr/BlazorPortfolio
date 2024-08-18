namespace BlazorPortfolio.Client.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public List<string> KeyFeatures { get; set; }
        public string Challenges { get; set; }
        public string Solutions { get; set; }
        public List<string> Screenshots { get; set; }
        public string DemoLink { get; set; }
        public string RepositoryLink { get; set; }
    }
}
