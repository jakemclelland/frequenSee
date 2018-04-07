using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data
{
    public interface IDbRepository
    {
        string DataFilePath { get; set; }

        DataContext Context { get; set; }
    }
}
