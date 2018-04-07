using frequenSee.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data.Entities
{
    public class CategorySymbolFrequencyRepository : DbRepository<ICategorySymbolFrequency>
    {
        public CategorySymbolFrequencyRepository()
        {
            this.MappedTableName = "CategorySymbolFrequency";
        }
    }
}
