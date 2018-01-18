using frequenSee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data.Entities
{
    public class FoundSymbolEntity : EntityBase<FoundSymbol>
    {
        public FoundSymbolEntity(FoundSymbol model) : base(model)
        {
            this.MappedTableName = "FoundSymbol";
        }
    }
}
