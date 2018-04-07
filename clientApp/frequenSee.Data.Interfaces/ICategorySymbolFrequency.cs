using System;
using System.Collections.Generic;
using System.Text;

namespace frequenSee.Data.Interfaces
{
    public interface ICategorySymbolFrequency : IModelBase
    {
        int FrequencyId { get; set; }

        int? FoundSymbolId { get; }

        int Hits { get; set; }
    }
}
