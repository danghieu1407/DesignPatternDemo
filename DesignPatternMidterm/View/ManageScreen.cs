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
        private void ManageScreen_Load(object sender, EventArgs e)
        {

            //set text for labels
            //string strings = modify.Accounts("Select name from Accounts where id = " + LoginScreen.id);
            //txtWelcome.Text = strings;

        }
    }
}
