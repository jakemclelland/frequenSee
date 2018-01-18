using frequenSee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace frequenSee.Data.Entities
{
    public class ContentSourceEntity : EntityBase<ContentSource>
    {
        public ContentSourceEntity(ContentSource model) : base(model)
        {
            this.MappedTableName = "ContentSource";
        }
    }
}
