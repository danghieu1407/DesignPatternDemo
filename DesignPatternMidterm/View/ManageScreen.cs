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
    public partial class ManageScreen : Form
    {
        public ManageScreen()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderScreen orderscreen = new OrderScreen();
            orderscreen.ShowDialog();
            this.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            this.Hide();
            KitchenScreen bep = new KitchenScreen();
            bep.ShowDialog();
            this.Show();
        }
        Modify modify = new Modify();
        public void updateData(string name)

        {
            lbIntro.Text = "Hello " + name;
        }
        int temp;
        //updateRole
        public void updateRole(int role)
        {
            temp = role;
        }
        private void ManageScreen_Load(object sender, EventArgs e)
        {

            if (temp == 3)
            {
                btnOrder.Enabled = true;
                btnKitchen.Enabled = true;
                btnManage.Enabled = true;
            }
            else if (temp == 1)
            {
                //hide button
                btnOrder.Enabled = true;
                btnKitchen.Enabled = true;
                btnManage.Hide();

            }
            else
            {
                btnOrder.Enabled = true;
                btnKitchen.Hide();
                btnManage.Hide();
            }

        }

       

        private void lbLogout_Click(object sender, EventArgs e)
        {
            //close all forms and open LoginScreen
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.Show();
          
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            //close and open ManageAccount
            this.Hide();
            ManageAccount manage = new ManageAccount();
          
            manage.ShowDialog();
            this.Show();
        }
    }
}
