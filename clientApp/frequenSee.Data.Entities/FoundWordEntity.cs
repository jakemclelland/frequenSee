using frequenSee.Models;
using System;
using System.Collections.Generic;

namespace frequenSee.Data.Entities
{
    public class FoundWordEntity : EntityBase<FoundWord>
    {
        public FoundWordEntity(FoundWord model) : base(model)
        {
            this.MappedTableName = "FoundWord";
        }
    }
}
