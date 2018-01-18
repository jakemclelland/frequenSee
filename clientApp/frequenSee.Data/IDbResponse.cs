using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data
{
    public interface IDbResponse
    {
        int NumberOfRows { get; set; }

        DbResponseState State { get; set; }

        Exception ErrorResponse { get; set; }
    }
}
