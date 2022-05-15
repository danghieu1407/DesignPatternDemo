using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Model
{
    internal class Account
    {
        private string name;
        private string email;
        private string password;
        private int role;
       
        public Account()
        {
            
        }
        public Account(string name,string email, string password, int role)
        {
            this.email = email;
            this.name = name;
           
            this.password = password;
            this.role = role;
        }

        //get set
      
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }

    }
}
