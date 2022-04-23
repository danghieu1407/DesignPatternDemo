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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool checkAccount(string abc)
        {
            return Regex.IsMatch(abc, @"^[a-zA-Z0-9]{6,12}$");
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            //check null
           
            if (txtUsername.Text == "" || txtPWD.Text == "" || txtConfirmPWD.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (!checkAccount(txtPWD.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu dài 6-26 ký tự với 1 kỳ tự hoa 1 ký tự số");
                    return;
                }
                if (txtConfirmPWD.Text != txtPWD.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp");
                    return;
                }
                if (!checkEmail(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng email");
                    return;
                }
                if (modify.Accounts("Select * from Account where email = '" + txtEmail.Text + "'").Count != 0)
                {
                   MessageBox.Show("Tài khoản đã tồn tại");
                    return;
                }
                //test checkbox
                if(chkAgree.Checked == false)
                {
                    MessageBox.Show("Vui lòng đồng ý với điều khoản của ứng dụng");
                    return;
                }
                try
                {
                    modify.Accounts("Insert into Account(name, password, email) values('" + txtUsername.Text + "','" + txtPWD.Text + "','" + txtEmail.Text + "')");
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}