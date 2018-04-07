using System;
using System.Collections.Generic;
using System.Text;

namespace frequenSee.Data.Interfaces
{
    public interface IFoundSymbol : IModelBase
    {
        int SymbolId { get; set; }

        string Symbol { get; set; }
    }
}
