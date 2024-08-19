using BlazorPortfolio.Client.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BlazorPortfolio.Client
{
    public class ProjectStatusConverter : JsonConverter<ProjectStatus>
    {
        public override ProjectStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Try to parse the value
            if (Enum.TryParse<ProjectStatus>(reader.GetString(), out var status))
            {
                return status;
            }

            // Handle unexpected values
            throw new JsonException($"Invalid project status value: {reader.GetString()}");
        }

        public override void Write(Utf8JsonWriter writer, ProjectStatus value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
