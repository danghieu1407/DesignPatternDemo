using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Model
{
    public class StaffModel
    {
        private string name;
        private string email;
        private string password;
        private int role;


        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }

        public StaffModel(string name, string email, string password, int role)
        {

            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public StaffModel(DataRow row)
        {
            this.name = row["name"].ToString();
            this.Role = (int)row["role"];
            this.email = row["email"].ToString();
            this.password = row["password"].ToString();
        }

    }
}
