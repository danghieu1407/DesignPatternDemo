using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using DesignPatternMidtem.ConfigDTB;
using DesignPatternMidterm.Model;

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
        //getConnectionString() from DatabaseProvide in ConfigurationDTB
        string connection = DatabaseProvide.ConnectionString();
        //get data from database
        public List<Account> Accounts(string query)
       {
            List<Account> accounts = new List<Account>();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
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

        //get data from table Account in Modify
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT * FROM Account", sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    accounts.Add(new Account(sqlDataReader.GetString(1), sqlDataReader.GetString(0),
                        sqlDataReader.GetString(2), sqlDataReader.GetInt32(3)));

                }
                //close
                sqlConnection.Close();
            }
            return accounts;
        }

        //insert account to database
        public void InsertAccount(string username, string password, string email, int role)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                //check if username is exist
                sqlCommand = new SqlCommand("SELECT * FROM Account WHERE name = @username", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    //close
                    sqlConnection.Close();
                    //tho6ng báo tài khoản đã tồn tại
                    System.Windows.Forms.MessageBox.Show("Tài khoản đã tồn tại");
                }
                else
                {
                    //insert
                    sqlCommand = new SqlCommand("INSERT INTO Account VALUES(@email,@name, @password,@role)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@email", email);
                    sqlCommand.Parameters.AddWithValue("@name", username);
                    sqlCommand.Parameters.AddWithValue("@password", password);
                    sqlCommand.Parameters.AddWithValue("@role", role);

                    //sqlCommand.ExecuteNonQuery();

                    //close
                    sqlConnection.Close();
                    //thông bao thêm thành công và reload form
                    MessageBox.Show("Thêm tài khoản thành công");
                }
            }
        }

        //delete account from database
        public void DeleteAccount(string email)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM Account WHERE email = @email", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.ExecuteNonQuery();
                //close
                sqlConnection.Close();
                //thông bao xóa thành công
                MessageBox.Show("Xóa tài khoản thành công");
            }
        }

        //update account in database
        public void UpdateAccount(string username, string password, string email, int role)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE Account SET email = @email, password = @password, role = @role WHERE name = @username", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@role", role);
                sqlCommand.ExecuteNonQuery();
                //close
                sqlConnection.Close();
                //thông bao update thành công
                MessageBox.Show("Update tài khoản thành công");
            }
        }


    }
}
