namespace frequenSee.Data
{
    using Dapper;
    using frequenSee.Data.Interfaces;
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
            finally
            {
                this.SQLiteConnection.Close();
            }

            return response;
        }

        public InsertedResponse Insert<M>(string insertStatement, string tableName, M model)
            where M : IModelBase
        {
            InsertedResponse response = new InsertedResponse();
            
            try
            {
                this.EnsureDbOpen();

                response.SavedEntityKey = this.SQLiteConnection.Query<int>(insertStatement, model).First();

                response.State = DbResponseState.Success;
            }
            catch (Exception ex)
            {
                response.State = DbResponseState.Failure;

                response.ErrorResponse = ex;

                throw;
            }
            finally
            {
                this.SQLiteConnection.Close();
            }

            return response;
        }

        public ExecutionResponse CreateTable(string createStatement)
        {
            ExecutionResponse response = new ExecutionResponse();

            response = this.ExecuteNonQuery(createStatement);

            return response;
        }

        private void EnsureDbOpen()
        {
            if (this.SQLiteConnection == null || this.SQLiteConnection.State != ConnectionState.Open)
            {
                this.Open();
            }
        }

        private void EnsureTableExists(string tableName, string createStatement)
        {
            this.EnsureDbOpen();

            var tableExistsSql = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}';";
            var isTableExists = this.SQLiteConnection.Query<string>(tableExistsSql).ToList();

            if (!isTableExists.Any())
            {
                this.CreateTable(createStatement);
            }
        }
    }
}
