using System.Data;
using System.Data.SqlClient;

namespace EduNova.Data
{
    public static class SqlHelper
    {
        public static DataTable ExecuteDataTable(string storedProcedure, params SqlParameter[] parameters)
        {
            using (var connection = Db.GetConnection())
            using (var command = new SqlCommand(storedProcedure, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 120;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static DataSet ExecuteDataSet(string storedProcedure, params SqlParameter[] parameters)
        {
            using (var connection = Db.GetConnection())
            using (var command = new SqlCommand(storedProcedure, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 120;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }

        public static int ExecuteNonQuery(string storedProcedure, params SqlParameter[] parameters)
        {
            using (var connection = Db.GetConnection())
            using (var command = new SqlCommand(storedProcedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 120;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string storedProcedure, params SqlParameter[] parameters)
        {
            using (var connection = Db.GetConnection())
            using (var command = new SqlCommand(storedProcedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 120;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteScalar();
            }
        }

        public static SqlParameter Param(string name, object value)
        {
            return new SqlParameter(name, value ?? System.DBNull.Value);
        }

        public static SqlParameter Param(string name, SqlDbType type, object value)
        {
            return new SqlParameter(name, type) { Value = value ?? System.DBNull.Value };
        }
    }
}
