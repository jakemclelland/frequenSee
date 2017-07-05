namespace frequenSee.Models
{
    public class ContentSource
    {
        public int SourceId { get; set; }

        public string SourceUri { get; set; }

        public CategoryEnum Category { get; set; }
    }
}
