using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data
{
    public class ExecutionResponse : IDbResponse
    {
        public ExecutionResponse()
        {
            State = DbResponseState.Inconclusive;
        }

        public int NumberOfRows { get; set; }

        public DbResponseState State { get; set; }

        public Exception ErrorResponse { get; set; }
    }
}
