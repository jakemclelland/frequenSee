using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data
{
    public class InsertedResponse : IDbResponse
    {
        public InsertedResponse()
        {
            State = DbResponseState.Inconclusive;
        }

        public int SavedEntityKey { get; set; }

        public int NumberOfRows { get; set; }

        public DbResponseState State { get; set; }

        public Exception ErrorResponse { get; set; }
    }
}
