using System;
using System.Configuration;
using System.Data.SqlClient;

namespace EduNova.Data
{
    public static class Db
    {
        public static string ConnectionString
        {
            get
            {
                var settings = ConfigurationManager.ConnectionStrings["EduNovaDB"];
                if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
                    throw new InvalidOperationException("Missing connection string 'EduNovaDB' in App.config.");
                return settings.ConnectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
