namespace Spider.Json
{
    public record JsonArticle
    {
        public string TimeSlot { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Caption { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string Preview { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public JsonArticle()
        {

        }
    }
}
