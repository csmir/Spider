namespace Spider.Json
{
    public class JsonTimelineItem
    {
        public string TimeSlot { get; set; } = string.Empty;

        public string Preview { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public int BlogId { get; set; }

        public enum ViewType
        {
            InfoGraphic,

            BlogPreview,
        }
    }
}
