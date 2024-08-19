using BlazorPortfolio.Client.Models;
using System.Text.Json;

namespace BlazorPortfolio.Client.Services
{
    public class LinkService
    {
        private readonly HttpClient _httpClient;

        public LinkService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Link>> GetLinksAsync()
        {
            var response = await _httpClient.GetStringAsync("data/links.json");
            var links = JsonSerializer.Deserialize<LinkCollection>(response);
            return links?.Links ?? new List<Link>();
        }
    }
}
