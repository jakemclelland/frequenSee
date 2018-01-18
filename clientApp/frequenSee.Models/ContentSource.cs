using frequenSee.Common.Interfaces;

namespace frequenSee.Models
{
    public class ContentSource : IModelBase
    {
        public int SourceId { get; set; }

        public string SourceUri { get; set; }

        public CategoryEnum Category { get; set; }
    }
}
