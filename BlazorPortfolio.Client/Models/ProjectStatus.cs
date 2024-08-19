
using System.Text.Json.Serialization;

namespace BlazorPortfolio.Client.Models
{
    public enum ProjectStatus
    {
        [JsonPropertyName("not_started")]
        NotStarted,

        [JsonPropertyName("in_progress")]
        InProgress,

        [JsonPropertyName("completed")]
        Completed,

        [JsonPropertyName("archived")]
        Archived
    }
}
