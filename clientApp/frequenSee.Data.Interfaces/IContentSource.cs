using System;
using System.Collections.Generic;
using System.Text;

namespace frequenSee.Data.Interfaces
{
    public interface IContentSource : IModelBase
    {
        int SourceId { get; set; }

        string SourceUri { get; set; }

        int? CategoryId { get; }
    }
}
