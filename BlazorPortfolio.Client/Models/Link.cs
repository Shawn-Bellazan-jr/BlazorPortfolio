using System.Text.Json.Serialization;

namespace BlazorPortfolio.Client.Models
{
    public class Link
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
