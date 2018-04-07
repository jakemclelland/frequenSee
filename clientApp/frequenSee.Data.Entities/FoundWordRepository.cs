using frequenSee.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data.Entities
{
    public class FoundWordRepository : DbRepository<IFoundWord>
    {
        public FoundWordRepository()
        {
            this.MappedTableName = "FoundWord";
        }
    }
}
