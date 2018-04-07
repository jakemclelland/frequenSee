using frequenSee.Data.Interfaces;
using frequenSee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data.Entities
{
    public class ContentSourceRepository : DbRepository<IContentSource>
    {
        public ContentSourceRepository()
        {
            this.MappedTableName = "ContentSource";
        }
    }
}
