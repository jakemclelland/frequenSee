using frequenSee.Data.Interfaces;

namespace frequenSee.Models
{
    public class ContentSource : IContentSource
    {
        public int SourceId { get; set; }

        public string SourceUri { get; set; }

        public CategoryEnum Category { get; set; }

        public int? CategoryId
        {
            get
            {
                return (int?)this.Category;
            }
        }
    }
}
