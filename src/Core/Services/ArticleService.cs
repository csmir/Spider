using Spider.Json;
using System.Net.Http.Json;

namespace Spider.Services
{
    public class ArticleService(HttpClient client)
    {
        private bool initialized;

        private readonly HttpClient _client = client;

        public Dictionary<int, JsonArticle> Articles { get; private set; } = [];

        public async Task InitializeAsync()
        {
            if (!initialized)
            {
                Articles = await _client.GetFromJsonAsync<Dictionary<int, JsonArticle>>("data/articles.json")
                    ?? [];

                initialized = true;
            }
        }
    }
}
