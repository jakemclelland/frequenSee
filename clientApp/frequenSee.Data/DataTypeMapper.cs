/*
 License: http://www.apache.org/licenses/LICENSE-2.0
 Home page: https://github.com/StackExchange/dapper-dot-net
 */

using System;
using System.Collections.Generic;

namespace frequenSee.Data
{
    public static class DataTypeMapper
    {
        const string INTEGER = "INTEGER";
        const string REAL = "REAL";
        const string TEXT = "TEXT";
        const string BLOB = "BLOB";

        private static Dictionary<Type, string> typeMap;

        static DataTypeMapper()
        {
            typeMap = new Dictionary<Type, string>
            {
                [typeof(byte)] = INTEGER,
                [typeof(sbyte)] = INTEGER,
                [typeof(short)] = INTEGER,
                [typeof(ushort)] = INTEGER,
                [typeof(int)] = INTEGER,
                [typeof(uint)] = INTEGER,
                [typeof(long)] = INTEGER,
                [typeof(ulong)] = INTEGER,
                [typeof(float)] = REAL,
                [typeof(double)] = REAL,
                [typeof(decimal)] = REAL,
                [typeof(bool)] = INTEGER,
                [typeof(string)] = TEXT,
                [typeof(char)] = TEXT,
                [typeof(Guid)] = TEXT,
                [typeof(DateTime)] = TEXT,
                [typeof(DateTimeOffset)] = TEXT,
                [typeof(TimeSpan)] = TEXT,
                [typeof(byte[])] = BLOB,
                [typeof(byte?)] = BLOB,
                [typeof(sbyte?)] = BLOB,
                [typeof(short?)] = INTEGER,
                [typeof(ushort?)] = INTEGER,
                [typeof(int?)] = INTEGER,
                [typeof(uint?)] = INTEGER,
                [typeof(long?)] = INTEGER,
                [typeof(ulong?)] = INTEGER,
                [typeof(float?)] = REAL,
                [typeof(double?)] = REAL,
                [typeof(decimal?)] = REAL,
                [typeof(bool?)] = INTEGER,
                [typeof(char?)] = TEXT,
                [typeof(Guid?)] = TEXT,
                [typeof(DateTime?)] = TEXT,
                [typeof(DateTimeOffset?)] = TEXT,
                [typeof(TimeSpan?)] = TEXT,
                [typeof(object)] = BLOB
            };
        }
       
        public static string LookupDbType(Type type)
        {
            var nullUnderlyingType = Nullable.GetUnderlyingType(type);
            if (nullUnderlyingType != null) type = nullUnderlyingType;

            if (typeMap.TryGetValue(type, out string dbType))
            {
                return dbType;
            }
           
            return TEXT;
        }
    }
}
