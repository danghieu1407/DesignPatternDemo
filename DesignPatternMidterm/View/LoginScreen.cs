using DesignPatternMidterm.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternMidterm.View
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form and open Login.cs
            this.Close();
            Login login = new Login();
            login.Show();
        }

        Modify modify = new Modify();
        public delegate void sendName(TextBox text);
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //get txtTaiKhoan và txtMatKhau
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            //string email = txtEmail.Text;
            //COMPARE taiKhoan và matKhau

            //check taikhoan va mat khau null
            if (taiKhoan == "" && matKhau == "")
            {

                MessageBox.Show("Vui lòng nhập tai khoa va mat khau");

            } else if (taiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
            } else if (matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập mat khau");
            } 
            else
            {
                string query = "select * from Account where email = '" + taiKhoan + "' and password = '" + matKhau + "'";
                //check taiKhoan va matKhau
                if (modify.Accounts(query).Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    //open form MainScreen
                    //select name from Account
                    
                    ManageScreen screen1 = new ManageScreen();
                    sendName name = new sendName(screen1.updateData);
                    name?.Invoke(this.txtTaiKhoan);
                    screen1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
              
            }
       
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //hilde
            this.Hide();
            //open ForgotPassword
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
        }
    }
}
