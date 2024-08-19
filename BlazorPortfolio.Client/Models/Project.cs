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

        [JsonPropertyName("key_features")]
        public List<string> KeyFeatures { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("demo_link")]
        public string DemoLink { get; set; }

        [JsonPropertyName("repository_link")]
        public string RepositoryLink { get; set; }

        [JsonPropertyName("platforms")]
        public List<string> Platforms { get; set; }

        [JsonPropertyName("status")]
        public ProjectStatus Status { get; set; }
        [JsonPropertyName("completion_date")]
        public DateTime CompletionDate { get; set; } // Add this line

    }
}
