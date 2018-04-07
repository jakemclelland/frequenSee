using System;
using System.Collections.Generic;
using System.Text;

namespace frequenSee.Data.Interfaces
{
    public interface IFoundWord : IModelBase
    {
        int WordId { get; set; }

        string Text { get; set; }
    }
}
