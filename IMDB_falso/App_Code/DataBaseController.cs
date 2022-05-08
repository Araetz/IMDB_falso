using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IMDB_falso.App_Code
{
    public class DataBaseController
    {
        public const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\labas\\source\repos\\IMDB_falso\\IMDB_falso\\App_Data\\mainDB.msf.mdf;Integrated Security=True;Connect Timeout=30";
        
        public static DataTable Select(string commandString)
        {
            DataTable dt = new DataTable(); 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand(commandString, connection))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        adapter.Fill(dt); 
                    }
                        connection.Close(); 
                }
            }
            return dt; 
        }
    
    }
}
