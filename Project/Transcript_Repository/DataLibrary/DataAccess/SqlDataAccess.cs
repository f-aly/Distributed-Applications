using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; //If there's an error, Right-click DataLibrary References > NuGet Manager and download it from there
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccess
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string connectionName = "TRS_Database")
        {
            //If there's an error, Right-click DataLibrary References > Add Reference > Assemblies > Check System.Configuration
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        // Load data into model T and return a list of the model. Connects to sql which is the sql query which is loaded in T.
        // Then we return the list from T.
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        // Save one model using sql stmt 
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }
    }
}
