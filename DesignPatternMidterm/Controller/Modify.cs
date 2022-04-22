using System.Data.SqlClient;
using System.Collections.Generic;
namespace DesignPatternMidterm.Controller
{
    internal class Modify
    {
        public Modify()
        {
        }

        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        
       //get data from database
       public List<Account> Accounts(string query)
       {
            List<Account> accounts = new List<Account>();
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=YUH\SQLEXPRESS;
                    Initial Catalog=DemoDesignPattern;Integrated Security=True"))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    accounts.Add(new Account(sqlDataReader.GetString(0), sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2), sqlDataReader.GetInt32(3)));
                }
                //close
                sqlConnection.Close();
            }
            return accounts;
        }
       
       
    }
}
