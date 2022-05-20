using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternMidterm.Controller.TemplateMethodPattern;
using DesignPatternMidterm.Controller.CommandPattern;

namespace DesignPatternMidterm.View
{
    public partial class KitchenScreen : Form
    {

        bool vicay = false;
        bool phomai = false;
        bool haisan = false;
        bool thapcam = false;

        private ButtonCommandBase defColor, truGaCay, truGaPhoMai, truhaisan, truthapcam, tatCa;

        public KitchenScreen()
        {
            InitializeComponent();
            nau.Enabled = false;
            defColor = new DefColor(gaCay, gaPhoMai, pizzaHaiSan, pizzaThapCam );
            truGaCay = new DisableCmd(gaPhoMai, pizzaHaiSan, pizzaThapCam);
            truGaPhoMai = new DisableCmd(gaCay, pizzaThapCam, pizzaHaiSan);
            truhaisan = new DisableCmd(gaCay, gaPhoMai, pizzaThapCam);
            truthapcam = new DisableCmd(gaPhoMai, gaCay, pizzaHaiSan);
            tatCa = new EnableCmd(gaCay, gaPhoMai, pizzaHaiSan, pizzaThapCam);
            //button gaCay not select
            
                   

            cancel.Hide();
        }

        private void gaCay_Click(object sender, EventArgs e)

        {
            vicay = true;
            truGaCay.execute();
            cancel.Show();
            gaCay.BackColor = Color.Green;
            nau.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form and open  ManageScreen
            this.Hide();
           

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            vicay = false;
            phomai = false;
            haisan = false;
            thapcam = false;
            tatCa.execute();
            defColor.execute();
        }

        private void gaPhoMai_Click(object sender, EventArgs e)
        {
            phomai = true;
            truGaPhoMai.execute();
            cancel.Show();
            gaPhoMai.BackColor = Color.Green;
            nau.Enabled = true;
        }

        private void pizzaHaiSan_Click(object sender, EventArgs e)
        {
            haisan = true;
            truhaisan.execute();
            cancel.Show();
            pizzaHaiSan.BackColor = Color.Green;
            nau.Enabled = true;
        }

        private void pizzaThapCam_Click(object sender, EventArgs e)
        {
            thapcam = true;
            truthapcam.execute();
            cancel.Show();
            pizzaThapCam.BackColor = Color.Green;
            nau.Enabled = true;
        }

        private void nau_Click(object sender, EventArgs e)
        {
            if (vicay == true)
            {
                FoodTemplate temp = new GaranFood();
                temp.setString("Vị cay");
                bep.Text = temp.prepareFood();
                vicay = false;
            }
            else if (phomai == true)
            {
                FoodTemplate temp = new GaranFood();
                temp.setString("Phô mai");
                bep.Text = temp.prepareFood();
                phomai = false;
            }
            else if (haisan == true)
            {
                FoodTemplate temp = new PizzaFood();
                temp.setString("Hải sản");
                bep.Text = temp.prepareFood();
                haisan = false;
            }
            else if (thapcam == true)
            {
                FoodTemplate temp = new PizzaFood();
                temp.setString("Thập cẩm");
                bep.Text = temp.prepareFood();
                thapcam = false;
            }
            

            MessageBox.Show("Hoàn thành");
            defColor.execute();
            tatCa.execute();
        }
    }
}
