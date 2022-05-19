using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.ConfigDTB
{
    public  class DatabaseProvide
    {
        public static string connectionString = @"Data Source=YUH\SQLEXPRESS;Initial Catalog=DemoDesignPattern;Integrated Security=True";
        private static DatabaseProvide instance;
        public DatabaseProvide() {  }

        public static string ConnectionString()
        {
            return connectionString;
        }

        //get set connectionString
  


        public static DatabaseProvide getInstance() //Singleton Pattern
        {
            if (instance == null)
                instance = new DatabaseProvide(); //Chỉ 1 thể hiện của ProvideDatabase được tồn tại
            return instance;
        }
        DataTable data = new DataTable();
       
        public DataTable Query (string query, object[] param = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if(param != null)
                {
                    string [] list = query.Split(' ');
                    int i =0;
                    foreach(string s in list)
                    {
                        if(s.Contains("@")) //parameter lấy từ database đều có dạng @biến vd: @username
                        {
                            cmd.Parameters.AddWithValue(s, param[i]);
                            i++;
                        }    
                    }    
                }    

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                data.Clear();
                adapter.Fill(data);
                connection.Close();
                
            }
            return data;

        }
    }
}
