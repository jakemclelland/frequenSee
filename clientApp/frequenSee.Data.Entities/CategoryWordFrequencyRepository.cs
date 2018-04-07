using frequenSee.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data.Entities
{
    public class CategoryWordFrequencyRepository : DbRepository<ICategoryWordFrequency>
    {
        public CategoryWordFrequencyRepository()
        {
            this.MappedTableName = "CategoryWordFrequency";
        }
    }
}
