using Spider.Json;
using System.Net.Http.Json;

namespace Spider.Services
{
    public class TimelineService(HttpClient client)
    {
        private bool initialized;

        private readonly HttpClient _client = client;

        public Dictionary<int, JsonTimelineItem> Timeline { get; private set; } = [];

        public async Task InitializeAsync()
        {
            if (!initialized)
            {
                Timeline = await _client.GetFromJsonAsync<Dictionary<int, JsonTimelineItem>>("data/timeline.json")
                    ?? [];

                initialized = true;
            }
        }
    }
}
