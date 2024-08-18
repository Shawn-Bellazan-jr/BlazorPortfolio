using BlazorPortfolio.Client.Models;
using System.Text.Json;

namespace BlazorPortfolio.Client.Services
{
    public class PortfolioService
    {
        private readonly HttpClient _httpClient;

        public PortfolioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Portfolio> GetPortfolioAsync()
        {
            try
            {
                var json = await _httpClient.GetStringAsync("data/portfolio.json");
                var portfolio = JsonSerializer.Deserialize<Portfolio>(json);

                return portfolio ?? new Portfolio(); // Ensure a non-null return value
            }
            catch (Exception)
            {
                return new Portfolio(); // Return an empty portfolio on error
            }
        }
    }
}
