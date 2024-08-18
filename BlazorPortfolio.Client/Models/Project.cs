using System.Text.Json.Serialization;

namespace BlazorPortfolio.Client.Models
{
    public class Project
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("technologies")]
        public List<string> Technologies { get; set; }

        [JsonPropertyName("keyFeatures")]
        public List<string> KeyFeatures { get; set; }

        [JsonPropertyName("challenges")]
        public string Challenges { get; set; }

        [JsonPropertyName("solutions")]
        public string Solutions { get; set; }

        [JsonPropertyName("screenshots")]
        public List<string> Screenshots { get; set; }

        [JsonPropertyName("demoLink")]
        public string DemoLink { get; set; }

        [JsonPropertyName("repositoryLink")]
        public string RepositoryLink { get; set; }
    }
}
