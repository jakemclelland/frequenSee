using frequenSee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data.Entities
{
    public class CategoryWordFrequencyEntity : EntityBase<CategoryWordFrequency>
    {
        public CategoryWordFrequencyEntity(CategoryWordFrequency model) : base(model)
        {
            this.MappedTableName = "CategoryWordFrequency";
        }
    }
}
