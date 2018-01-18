using frequenSee.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data
{
    public abstract class DbRepository : IDbRepository
    {
        public string DataFilePath { get; set; }

        public DataContext Context { get; set; }

        public string MappedTableName { get; set; }

        public DbRepository()
        {
            this.DataFilePath = "frequenSee.sqlite";

            this.Context = new DataContext(this.DataFilePath);
        }

        public virtual void SeedDataSchema()
        {}

        public InsertedResponse Save<E, M>(E entity)
            where M : IModelBase
            where E : EntityBase<M>
        {
            return this.Context.Save<E, M>(entity);
        }

        
    }
}
