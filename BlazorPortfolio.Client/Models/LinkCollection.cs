using System.Text.Json.Serialization;

namespace BlazorPortfolio.Client.Models
{
    public class LinkCollection
    {
        [JsonPropertyName("links")]
        public List<Link> Links { get; set; } = new();
    }
}
