using System.Text.Json.Serialization;

namespace BlazorPortfolio.Client.Models
{
    public class ProjectCollection
    {
        [JsonPropertyName("projects")]
        public List<Project> Projects { get; set; } = new();
    }
}
