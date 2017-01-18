using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LivePerformance.Data
{
    public static class Database
    {

        private static string Connection
        {
            get
            {
                string connection = "Server = mssql.fhict.local; Database = dbi352829; User Id = dbi352829; Password = aaycaaim14;" +"connection timeout=15";
                return connection;
            }
        }

        static SqlConnection sqlConnection
        {
            get
            {
                SqlConnection sqlConnection = new SqlConnection(Connection);
                return sqlConnection;
            }
        }

        //Handles all the queries and gives back the datatable
        public static DataTable Execute(string commandString)
        {
            DataTable dt = new DataTable();

            using (SqlCommand command = new SqlCommand(commandString, sqlConnection))
            {

                using (SqlDataAdapter Adapter = new SqlDataAdapter(commandString, sqlConnection))
                {

                    Adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
