using DesignPatternMidterm.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternMidterm.View
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //hide this form
            //check txtEmail null or not format
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your email");
            }
            else if (!checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email");
            }
            else
            {
                string query = "select * from Account where Email = '" + txtEmail.Text + "'";
                if (modify.Accounts(query).Count != 0)
                {
                    lbPassword.ForeColor = Color.Blue;
                    lbPassword.Text = "Your password is: " + modify.Accounts(query)[0].Password;
                }
                else
                {
                    lbPassword.ForeColor = Color.Red;
                    lbPassword.Text = "Email chưa được đăng ký";
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open the login form
            LoginScreen login = new LoginScreen();
            login.Show();
        }
    }
}
