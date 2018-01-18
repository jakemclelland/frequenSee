using frequenSee.Models;
using System.Collections.Generic;

namespace frequenSee.Data.Entities
{
    public class CategorySymbolFrequencyEntity : EntityBase<CategorySymbolFrequency>
    {
        public CategorySymbolFrequencyEntity(CategorySymbolFrequency model) : base(model)
        {
            this.MappedTableName = "CategorySymbolFrequency";
        }
    }
}
