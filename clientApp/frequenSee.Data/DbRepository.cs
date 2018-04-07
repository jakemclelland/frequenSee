using frequenSee.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Data
{
    public abstract class DbRepository<M> : IDbRepository
        where M : IModelBase
    {
        public string DataFilePath { get; set; }

        public DataContext Context { get; set; }

        public string MappedTableName { get; set; }

        private bool checkTableExists = true;

        public DbRepository()
        {
            this.DataFilePath = "frequenSee.sqlite";

            this.Context = new DataContext(this.DataFilePath);

            this.FieldList = this.ReflectFieldList();
        }

        public ExecutionResponse SeedDataSchema(M model, IList<M> seedList)
        {
            var result = this.Context.CreateTable(this.CreateStatement);

            foreach(M seed in seedList)
            {
                result.NumberOfRows += this.Insert(seed).NumberOfRows;
            }

            return result;
        }

        public InsertedResponse Insert(M model)
        {
            if (checkTableExists)
            {
                this.Context.EnsureTableExists(this.MappedTableName, this.BuildCreateTableStatement());
                checkTableExists = false;
            }

            return this.Context.Insert<M>(this.InsertStatement, this.MappedTableName, model);
        }

        private string insertStatementInstance;
        private string InsertStatement
        {
            get
            {
                if (insertStatementInstance == null)
                {
                    insertStatementInstance = this.BuildInsertStatement();
                }
                return insertStatementInstance;
            }
        }

        private string createStatementInstance;
        private string CreateStatement
        {
            get
            {
                if (createStatementInstance == null)
                {
                    createStatementInstance = this.BuildCreateTableStatement();
                }
                return createStatementInstance;
            }
        }

        private List<string> ReflectFieldList()
        {
            List<string> results = new List<string>();

            PropertyInfo[] propertyInfos = this.ModelProperties;

            foreach (PropertyInfo prop in propertyInfos)
            {
                results.Add(prop.Name);
            }

            return results;
        }

        protected virtual List<string> BuildCustomFieldList()
        {
            return new List<string>();
        }

        public List<String> FieldList { get; set; }

        private PropertyInfo[] ModelProperties
        {
            get
            {
                return typeof(M).GetProperties();
            }
        }

        public string BuildInsertStatement(bool returnId = true)
        {
            StringBuilder fieldList = new StringBuilder(1000);
            StringBuilder valuesList = new StringBuilder(1000);

            for (int f = 0; f < this.FieldList.Count; f++)
            {
                string fieldComma = f < (this.FieldList.Count - 1) ? ", " : string.Empty;
                string fieldName = this.FieldList[f];
                string fieldPart = $"{fieldName}{fieldComma}";

                fieldList.Append(fieldPart);

                valuesList.Append($"@{fieldPart}");
            }

            string returnStatement = returnId ? " select last_insert_rowid()" : string.Empty;

            return $"INSERT INTO {this.MappedTableName} ({fieldList}) VALUES ({valuesList}); {returnStatement}";
        }

        public string BuildCreateTableStatement()
        {
            string returnStatement = string.Empty;

            StringBuilder fieldList = new StringBuilder(1000);

            for (int f = 0; f < this.FieldList.Count; f++)
            {
                string fieldComma = f < (this.FieldList.Count - 1) ? ", " : string.Empty;
                string fieldName = this.FieldList[f];
                var property = this.ModelProperties.Where(x => x.Name == fieldName).First();
                string dataType = DataTypeMapper.LookupDbType(property.PropertyType);

                string fieldLine = $"{fieldName} {dataType}{fieldComma}";

                fieldList.Append(fieldLine);
            }

            returnStatement = $"CREATE TABLE IF NOT EXISTS {this.MappedTableName} ({fieldList})";

            return returnStatement;
        }
    }
}
