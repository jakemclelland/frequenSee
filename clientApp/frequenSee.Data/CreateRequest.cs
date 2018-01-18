using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data
{
    public class CreateRequest<T>
    {
        public List<T> EntitiesToCreate { get; set; }
    }
}
