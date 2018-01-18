namespace frequenSee.Data
{
    using Dapper;
    using frequenSee.Common.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DataContext
    {
        private const string DefaultConnectionString = "Data Source={0};Version=3;";

        public SQLiteConnection SQLiteConnection { get; set; }
        
        public string DataFilePath { get; set; }

        public DataContext(string dataFilePath)
        {
            this.ValidateConnectionInputs(dataFilePath);

            this.DataFilePath = dataFilePath;
        }

        private void ValidateConnectionInputs(string dataFilePath)
        {
            if (string.IsNullOrEmpty(dataFilePath))
            {
                throw new ArgumentNullException("DataFilePath", "Please specify a file path");
            }
        }
        
        internal DataContext Open()
        {
            ValidateConnectionInputs(this.DataFilePath);

            if (!File.Exists(this.DataFilePath))
            {
                SQLiteConnection.CreateFile(this.DataFilePath);
            }

            this.SQLiteConnection = new SQLiteConnection(string.Format(DefaultConnectionString, this.DataFilePath));

            this.SQLiteConnection.Open();

            return this;
        }

        public ExecutionResponse ExecuteNonQuery(string commandText)
        {
            ExecutionResponse response = new ExecutionResponse();

            try
            {
                this.EnsureDbOpen();

                response.NumberOfRows = this.SQLiteConnection.Execute(commandText);

                response.State = DbResponseState.Success;
            }
            catch(Exception ex)
            {
                response.State = DbResponseState.Failure;

                response.ErrorResponse = ex;

                throw;
            }

            return response;
        }

        public InsertedResponse Save<E, M>(E entity)
            where M : IModelBase
            where E : EntityBase<M>
        {
            InsertedResponse response = new InsertedResponse();

            string insertStatement = entity.BuildInsertStatement<E>(entity, true);

            try
            {
                this.EnsureDbOpen();

                response.SavedEntityKey = this.SQLiteConnection.Query<int>(insertStatement, entity).First();

                response.State = DbResponseState.Success;
            }
            catch (Exception ex)
            {
                response.State = DbResponseState.Failure;

                response.ErrorResponse = ex;

                throw;
            }

            return response;
        }

        private void EnsureDbOpen()
        {
            if (this.SQLiteConnection == null)
            {
                throw new NullReferenceException("Please provide a connection");
            }

            if (this.SQLiteConnection.State != ConnectionState.Open)
            {
                this.Open();
            }
        }
    }
}
