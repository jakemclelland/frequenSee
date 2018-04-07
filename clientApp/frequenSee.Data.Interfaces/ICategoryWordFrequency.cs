using System;
using System.Collections.Generic;
using System.Text;

namespace frequenSee.Data.Interfaces
{
    public interface ICategoryWordFrequency : IModelBase
    {
        int FrequencyId { get; set; }

        int? FoundWordId { get; }

        int Hits { get; set; }
    }
}
