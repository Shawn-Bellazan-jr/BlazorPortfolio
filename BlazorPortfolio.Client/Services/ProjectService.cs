using BlazorPortfolio.Client.Models;
using System.Text.Json;

namespace BlazorPortfolio.Client.Services
{
    public class ProjectService
    {
        private readonly HttpClient _httpClient;

        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Project>> GetProjectsAsync()
        {
            var options = new JsonSerializerOptions
            {
                Converters = { new ProjectStatusConverter() },
                PropertyNameCaseInsensitive = true
            };

            var response = await _httpClient.GetStringAsync("data/projects.json");
            var projects = JsonSerializer.Deserialize<ProjectCollection>(response, options);



            return projects?.Projects ?? new List<Project>();
        }
    }
}
