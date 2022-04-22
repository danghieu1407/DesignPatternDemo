

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace DesignPatternMidterm.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ManageScreen screen1 = new ManageScreen();
            //screen1.ShowDialog();
            //this.Show();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {



        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open Register
            Register register = new Register();
            register.Show();
        }
    }
}
