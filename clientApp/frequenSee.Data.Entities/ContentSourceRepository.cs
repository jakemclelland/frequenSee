using frequenSee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data.Entities
{
    public class ContentSourceRepository : DbRepository
    {
        public InsertedResponse SaveContentSource(ContentSourceEntity entity)
        {
            return this.Save<ContentSourceEntity, ContentSource>(entity);
        }
    }
}
