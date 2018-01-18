using frequenSee.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data
{
    public abstract class EntityBase<M> where M : IModelBase
    {
        public EntityBase(M model)
        {
            //if (string.IsNullOrEmpty(this.MappedTableName))
            //{
            //    throw new ArgumentNullException("MappedTableName");
            //}

            if (model == null)
            {
                throw new ArgumentNullException("Model");
            }

            this.Model = model;

            this.FieldList = this.ReflectFieldList();
        }

        private List<string> ReflectFieldList()
        {
            List<string> results = new List<string>();

            PropertyInfo[] propertyInfos = typeof(M).GetProperties();
            foreach(PropertyInfo prop in propertyInfos)
            {
                results.Add(prop.Name);
            }

            return results;
        }

        protected virtual List<string> BuildCustomFieldList()
        {
            return new List<string>();
        }

        public M Model { get; set; }

        public string MappedTableName { get; set; }

        public List<String> FieldList { get; set; }

        public string BuildInsertStatement<E>(E entity, bool returnId) where E : EntityBase<M>
        {
            StringBuilder fieldList = new StringBuilder(1000);
            StringBuilder valuesList = new StringBuilder(1000);

            for (int f = 0; f < entity.FieldList.Count; f++)
            {
                string fieldComma = f < entity.FieldList.Count ? ", " : string.Empty;

                string field = $"{entity.FieldList[f]}{fieldComma}";

                fieldList.Append(field);
                valuesList.Append($"@{field}");
            }

            string returnStatement = returnId ? " select last_insert_rowid()" : string.Empty;

            return $"INSERT INTO ({fieldList}) VALUES ({valuesList});{returnStatement}";
        }
    }
}
