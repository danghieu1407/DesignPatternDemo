using DesignPatternMidterm.ConfigDTB;
using DesignPatternMidterm.Controller.ObserverNotification;
using DesignPatternMidterm.Model;
using DesignPatternMidterm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.View
{
    public partial class StaffManager : Form
    {
        private ISubjectNotification notification;
        public StaffManager()
        {
            notification = new ISubjectNotification();
            InitializeComponent();
            var DeviceScreen = new DeviceObserver(notification);
            DeviceScreen.Show();
            notification.RegisterObserver(DeviceScreen);
            LoadStaffTable();
        }

        void LoadStaffTable()
        {
            dtgvStaff.Controls.Clear();
            //if role = 1 or 3 can fill in dtgvStaff
           

            List<StaffModel> tablelist = Staff.getInstance().LoadStaffs();
            dtgvStaff.DataSource = tablelist;
            RoleText.ReadOnly = true;

        }

        private void StaffManager_Load(object sender, EventArgs e)
        {

        }

        private void dtgvStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dtgvStaff.CurrentRow.Index;
            EmailText.Text = dtgvStaff.Rows[i].Cells[1].Value.ToString();
            NameText.Text = dtgvStaff.Rows[i].Cells[0].Value.ToString();
            RoleText.Text = getRoleName(dtgvStaff.Rows[i].Cells[3].Value.ToString());
            EmailText.ReadOnly = true;
        }

        string getRoleName(string param)
        {
          
            if (param == "1")
            {
                return "Admin";
            }
            else if (param == "2")
            {
                return "Quản Lí";
            }
            else
            {
                return "Nhân Viên";
            }    
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmailText.Text ="";
            NameText.Text = "";
            RoleText.Text = "";
            EmailText.ReadOnly = false;
            RoleText.ReadOnly = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EmailText.ReadOnly == true && RoleText.ReadOnly==true)
            {
                MessageBox.Show("Không thể thêm nhân viên đã có sẵn, vui lòng clear form");

            }
            else if(NameText.Text.Trim()=="" || EmailText.Text.Trim()=="")
            {
                MessageBox.Show("Không được để trống thông tin");
            }    
            else
            {
                
                string query = "insert Account(email, name) values('"+ EmailText.Text + "', '"+ NameText.Text + "')";
                DatabaseProvide.getInstance().Query(query);
                EmailText.Text = "";
                NameText.Text = "";
                RoleText.Text = "";
                EmailText.ReadOnly = false;
                RoleText.ReadOnly = true;
                LoadStaffTable();
            }    
            
        }

        private void Upgrade_Click(object sender, EventArgs e)
        {
            string query = "Update Account set role = '2' where email ='" + EmailText.Text + "'";
            DatabaseProvide.getInstance().Query(query);
            LoadStaffTable();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            string query = "Update Account set role = '0' where email ='" + EmailText.Text + "'";
            DatabaseProvide.getInstance().Query(query);
            LoadStaffTable();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            string query = "Update Account set name = '"+ NameText.Text + "' where email ='" + EmailText.Text + "'";
            DatabaseProvide.getInstance().Query(query);
            LoadStaffTable();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string Query = "DELETE FROM Account WHERE email = '" + EmailText.Text + "' ";
            DatabaseProvide.getInstance().Query(Query);
            LoadStaffTable();                   
        }

        private void ReplaceMess_Click(object sender, EventArgs e)
        {
            string text = SendMess.Text;
            notification.ReplaceNotification(text);
        }

        private void DeleteMess_Click(object sender, EventArgs e)
        {
            notification.RemoveNotification();
            SendMess.Text = "Chưa Đăng Thông Báo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
