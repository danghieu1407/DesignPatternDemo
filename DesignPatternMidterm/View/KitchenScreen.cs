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

        private ButtonCommandBase defColor;

        public KitchenScreen()
        {
            InitializeComponent();

            defColor = new DefColor(gaCay, gaPhoMai, pizzaHaiSan, pizzaThapCam );
        }

        private void gaCay_Click(object sender, EventArgs e)
        {
            vicay = true;
            gaCay.BackColor = Color.Green;
        }

        private void gaPhoMai_Click(object sender, EventArgs e)
        {
            phomai = true;
            gaPhoMai.BackColor = Color.Green;
        }

        private void pizzaHaiSan_Click(object sender, EventArgs e)
        {
            haisan = true;
            pizzaHaiSan.BackColor = Color.Green;
        }

        private void pizzaThapCam_Click(object sender, EventArgs e)
        {
            thapcam = true;
            pizzaThapCam.BackColor = Color.Green;
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
        }
    }
}
