using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternMidterm.Controller.DecoratorPattern.ChickenDecorator;
using DesignPatternMidterm.Controller.DecoratorPattern.MilkTeaDecorator;
using DesignPatternMidterm.Controller.CommandPattern;

namespace DesignPatternMidterm.View
{
    public partial class OrderScreen : Form
    {
        double price;
        List<double> dongia = new List<double>();
        DataTable listMon = new DataTable();
        List<double> queue = new List<double>();

        int count = 0;
        bool gaPhoMai = false; //Biến cờ cho gà rán phô mai
        bool gaCay = false; //Biến cờ cho gà rán cay
        bool pizzaHaisan = false; //Biến cờ cho pizza hải sản
        bool pizzaThapcam = false; //biến cờ cho pizza thập cẩm
        bool pepsilemon = false; // Biến cờ cho Pepsi chanh
        bool pepsinormal = false; // Biến cờ cho Pepsi vị thường
        bool thaixanh = false;//Biến cờ cho trà sữa thái xanh
        bool thaido = false;//Biến cờ cho trà sữa thái đỏ
        bool tuongOt = false;
        bool tuongCa = false;
        bool thachdeo = false;
        bool flan = false;
        bool tranchau = false;


        private ButtonCommandBase batMon, mauNut, anNut, hienNut;

        private CheckBoxCommandBase batTopping, tatTopping, disableTopping, enableTopping;

        public OrderScreen()
        {
            InitializeComponent();
            //Command Pattern cho các nút món ăn và topping
            batMon = new EnableCmd(gaRan, pizza, pepsi, traSua);
            mauNut = new DefColor(gaRan, pizza, pepsi, traSua);

            batTopping = new ToppingOn(tuongot, tuongca, khoaitay, banhngot, tranChau, banhFlan, thachDeo);
            tatTopping = new ToppingOff(tuongot, tuongca, khoaitay, banhngot, tranChau, banhFlan, thachDeo);

            anNut = new ButtonHide(cay, phoMai, haiSan, thapCam, lemon, normal, thaiDo, thaiXanh); ;

            disableTopping = new CheckboxDisableCmd(tuongot, tuongca, khoaitay, banhngot, tranChau, banhFlan, thachDeo);
            enableTopping = new CheckboxEnableCmd(tuongot, tuongca, khoaitay, banhngot, tranChau, banhFlan, thachDeo);

            //Tạo bảng 
            listMon.Columns.Add("STT", typeof(int));
            listMon.Columns.Add("Món", typeof(string));
            listMon.Columns.Add("Số lượng", typeof(string));
            listMon.Columns.Add("Giá tiền", typeof(double));
            orderGrid.AllowUserToAddRows = false;

            // Cái nút xóa trong bảng
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            orderGrid.Columns.Add(btnDelete);
            btnDelete.Name = "Delete";
            btnDelete.Text = "x";
            btnDelete.HeaderText = "";
            btnDelete.UseColumnTextForButtonValue = true;

            orderGrid.CellContentClick += orderGrid_CellContentClick;

            soLuong.Text = "1";
            addMenu.Enabled = false;
            thanhtien.Enabled = false;


            pickFood.Enabled = false;
            thanhToan.Enabled = false;
            cancelForm.Enabled = false;
            cancelMenu.Enabled = false;
            addMenu.Enabled = false;
            disableTopping.execute();
            anNut.execute();
            tatTopping.execute();
        }

        private void gaRan_Click(object sender, EventArgs e)
        {
            pickFood.Text = "";
            pickFood.Text = pickFood.Text + " + Gà rán";
            cay.Show();
            phoMai.Show();
            cancelMenu.Enabled = true;


            pizza.Enabled = false;
            pepsi.Enabled = false;
            traSua.Enabled = false;

            gaRan.BackColor = Color.Green;
        }

        private void phoMai_Click(object sender, EventArgs e)
        {
            pickFood.Text = pickFood.Text + " + Vị phô mai";
            addMenu.Enabled = true;
            cay.Hide();
            phoMai.Hide();
            tuongot.Enabled = true;
            tuongca.Enabled = true;
            khoaitay.Enabled = true;
            banhngot.Enabled = true;
            gaPhoMai = true;
        }

        private void pizza_Click(object sender, EventArgs e)
        {
            cancelMenu.Enabled = true;

            pickFood.Text = "";
            pickFood.Text = pickFood.Text + " + Pizza";

            haiSan.Show();
            thapCam.Show();

            gaRan.Enabled = false;
            pizza.Enabled = false;
            pepsi.Enabled = false;
            traSua.Enabled = false;
            pizza.BackColor = Color.Green;
        }

        private void haiSan_Click(object sender, EventArgs e)
        {
            pickFood.Text = pickFood.Text + " hải sản";
            addMenu.Enabled = true;
            haiSan.Hide();
            thapCam.Hide();
            tuongot.Enabled = true;
            tuongca.Enabled = true;
            pizzaHaisan = true;
        }

        private void thapCam_Click(object sender, EventArgs e)
        {
            pickFood.Text = pickFood.Text + " thập cẩm";
            addMenu.Enabled = true;
            haiSan.Hide();
            thapCam.Hide();
            tuongot.Enabled = true;
            tuongca.Enabled = true;
            pizzaThapcam = true;
        }

        private void pepsi_Click(object sender, EventArgs e)
        {
            cancelMenu.Enabled = true;
            pickFood.Text = "";
            pickFood.Text = pickFood.Text + " + Pepsi";
            lemon.Show();
            normal.Show();
            gaRan.Enabled = false;
            pizza.Enabled = false;
            traSua.Enabled = false;
            pepsi.BackColor = Color.Green;
        }

        private void lemon_Click(object sender, EventArgs e)
        {
            pickFood.Text = pickFood.Text + " vị chanh";
            addMenu.Enabled = true;
            lemon.Hide();
            normal.Hide();
            pepsilemon = true;
        }

        private void normal_Click(object sender, EventArgs e)
        {
            pickFood.Text = pickFood.Text + " vị thường";
            addMenu.Enabled = true;
            lemon.Hide();
            normal.Hide();
            pepsinormal = true;
        }

        private void traSua_Click(object sender, EventArgs e)
        {
            cancelMenu.Enabled = true;
            traSua.BackColor = Color.Green;
            pickFood.Text = "";
            pickFood.Text = pickFood.Text + " + Trà sữa";
            thaiDo.Show();
            thaiXanh.Show();
            gaRan.Enabled = false;
            pizza.Enabled = false;
            pepsi.Enabled = false;
        }

        private void thaiXanh_Click(object sender, EventArgs e)
        {
            pickFood.Text = pickFood.Text + " Thái xanh";
            addMenu.Enabled = true;
            thaiDo.Hide();
            thaiXanh.Hide();
            tranChau.Enabled = true;
            thachDeo.Enabled = true;
            banhFlan.Enabled = true;
            thaixanh = true;
        }

        private void thaiDo_Click(object sender, EventArgs e)
        {
            pickFood.Text = pickFood.Text + " Thái đỏ";
            addMenu.Enabled = true;
            thaiDo.Hide();
            thaiXanh.Hide();
            tranChau.Enabled = true;
            thachDeo.Enabled = true;
            banhFlan.Enabled = true;
            thaido = true;
        }

        private void tuongot_CheckedChanged(object sender, EventArgs e)
        {
            if (pickFood.Text.Contains("Tương ớt"))
            {

                pickFood.Text = pickFood.Text;

            }
            else
            {
                if (tuongot.Checked)
                {
                    pickFood.Text = pickFood.Text + " + Tương ớt";
                }

                else
                {
                    pickFood.Text = pickFood.Text;
                }
            }
        }

        private void tuongca_CheckedChanged(object sender, EventArgs e)
        {
            if (pickFood.Text.Contains("Tương cà"))
            {
                pickFood.Text = pickFood.Text;
            }
            else
            {
                if (tuongca.Checked)
                {
                    pickFood.Text = pickFood.Text + " + Tương cà";
                }

                else
                {
                    pickFood.Text = pickFood.Text;
                }

            }
        }






        private void orderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {


                var temp = grid.Rows[e.RowIndex];

                string a = temp.ToString();
                string b = null;
                for (int i = 0; i < a.Length; i++)
                {
                    if ((a[i] >= 48 && a[i] <= 57))
                    {
                        b = b + a[i];

                    }

                }


                DeleteAMeal(queue[int.Parse(b)]);
                queue.RemoveAt(int.Parse(b));
                count = 0;
                orderGrid.Rows.RemoveAt(int.Parse(b));
                if (dongia[0] <= 0)
                {
                    thanhToan.Enabled = false;
                    dongia.Clear();
                }

            }

        }
        private void DeleteAMeal(double gia)
        {

            double temp = 0;
            temp = dongia[0];



            double kq = temp - gia;
            dongia.Clear();
            thanhtien.Text = "";
            thanhtien.Text = thanhtien.Text + kq;
            dongia.Add(kq);
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            {

                thanhToan.Enabled = true;
                thanhToan.Show();
                pickFood.Text = "";
                cancelForm.Enabled = true;
                cancelMenu.Enabled = false;
                int parsedValue;
                if (!int.TryParse(soLuong.Text, out parsedValue))
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                    return;
                }



                //Gà rán
                if (gaPhoMai == true && khoaitay.Checked == true)
                {
                    var garanphomaikhoaiay = new PotatoChick(new CheeseTopping(new Chicken()));
                    pickFood.Text = pickFood.Text + garanphomaikhoaiay.doChicken();
                    dongia.Add(garanphomaikhoaiay.Cost() * parsedValue);
                    price = garanphomaikhoaiay.Cost() * parsedValue;
                }
                else if (gaCay == true && khoaitay.Checked == true)
                {
                    var garancaykhoaitay = new PotatoChick(new SpicyFlavor(new Chicken()));
                    pickFood.Text = pickFood.Text + garancaykhoaitay.doChicken();
                    dongia.Add(garancaykhoaitay.Cost() * parsedValue);
                    price = garancaykhoaitay.Cost() * parsedValue;
                }
                else if (gaPhoMai == true && banhngot.Checked == true)
                {
                    var garanphomaibanhngot = new SweetCakeChick(new CheeseTopping(new Chicken()));
                    pickFood.Text = pickFood.Text + garanphomaibanhngot.doChicken();
                    dongia.Add(garanphomaibanhngot.Cost() * parsedValue);
                    price = garanphomaibanhngot.Cost() * parsedValue;
                }
                else if (gaCay == true && banhngot.Checked == true)
                {
                    var garancaybanhngot = new SweetCakeChick(new SpicyFlavor(new Chicken()));
                    pickFood.Text = pickFood.Text + garancaybanhngot.doChicken();
                    dongia.Add(garancaybanhngot.Cost() * parsedValue);
                    price = garancaybanhngot.Cost() * parsedValue;
                }
                else
                {
                    if (gaPhoMai == true)
                    {
                        var garanphomai = new CheeseTopping(new Chicken());
                        pickFood.Text = pickFood.Text + garanphomai.doChicken();
                        dongia.Add(garanphomai.Cost() * parsedValue);
                        price = garanphomai.Cost() * parsedValue;
                    }
                    else if (gaCay == true)
                    {
                        var garancay = new SpicyFlavor(new Chicken());
                        pickFood.Text = pickFood.Text + garancay.doChicken();
                        dongia.Add(garancay.Cost() * parsedValue);
                        price = garancay.Cost() * parsedValue;
                    }
                }

                //Pizza

                if (pizzaHaisan == true)
                {
                    pickFood.Text = pickFood.Text + " + Pizza hải sản";
                    dongia.Add(20000 * parsedValue);
                    price = 20000 * parsedValue;
                }
                else if (pizzaThapcam == true)
                {
                    pickFood.Text = pickFood.Text + " + Pizza thập cẩm";
                    dongia.Add(25000 * parsedValue);
                    price = 25000 * parsedValue;
                }
                //Pepsi
                if (pepsilemon == true)
                {
                    pickFood.Text = pickFood.Text + " + Pepsi vị chanh";
                    dongia.Add(10000 * parsedValue);
                    price = 10000 * parsedValue;
                }
                else if (pepsinormal == true)
                {
                    pickFood.Text = pickFood.Text + " + Pepsi vị thường";
                    dongia.Add(8000 * parsedValue);
                    price = 8000 * parsedValue;
                }


                // tuong ca tuong ot
                if (tuongca.Checked == true)
                {
                    if (pickFood.Text.Contains("Tương cà"))
                    {
                        pickFood.Text = pickFood.Text;
                    }
                    else
                    {
                        pickFood.Text = pickFood.Text + " + Tương cà";
                    }

                }
                if (tuongot.Checked == true)
                {
                    if (pickFood.Text.Contains("Tương ớt"))
                    {
                        pickFood.Text = pickFood.Text;
                    }
                    else
                    {
                        pickFood.Text = pickFood.Text + " + Tương ớt";
                    }

                }
                //Trà sữa
                if (thaixanh == true)
                {
                    if (tranChau.Checked && banhFlan.Checked && thachDeo.Checked)
                    {
                        var tamp = new FlanCake(new Bubble(new Jelly(new GreenMilkTea(new MilkTea()))));
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                    else if (tranChau.Checked)
                    {
                        var tamp = new Bubble(new GreenMilkTea(new MilkTea()));
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                    else if (banhFlan.Checked)
                    {
                        var tamp = new FlanCake(new GreenMilkTea(new MilkTea()));
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                    else if (thachDeo.Checked)
                    {
                        var tamp = new Jelly(new GreenMilkTea(new MilkTea()));
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }

                    else
                    {
                        var tamp = new GreenMilkTea(new MilkTea());
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                }
                else if (thaido == true)
                {
                    if (tranChau.Checked && banhFlan.Checked && thachDeo.Checked)
                    {
                        var tamp = new FlanCake(new Bubble(new Jelly(new RedMilkTea(new MilkTea()))));
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                    else if (tranChau.Checked)
                    {
                        var tamp = new Bubble(new RedMilkTea(new MilkTea()));
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                    else if (banhFlan.Checked)
                    {
                        var tamp = new FlanCake(new RedMilkTea(new MilkTea()));
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                    else if (thachDeo.Checked)
                    {
                        var tamp = new Jelly(new RedMilkTea(new MilkTea()));
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                    else
                    {
                        var tamp = new RedMilkTea(new MilkTea());
                        pickFood.Text = pickFood.Text + tamp.doMilkTea();
                        dongia.Add(tamp.Cost() * parsedValue);
                        price = tamp.Cost() * parsedValue;
                    }
                }

                //Xuất bảng

                count = count + 1;

                listMon.Rows.Add(count, pickFood.Text, soLuong.Text, price);
                orderGrid.DataSource = listMon;



                queue.Add(price);


                //Tính tiền dựa trên số lượng
                double temp = 0;
                foreach (double i in dongia)
                {
                    temp = temp + i;

                }
                dongia.Clear();
                thanhtien.Text = "";
                thanhtien.Text = thanhtien.Text + temp;
                dongia.Add(temp);


                gaPhoMai = false;
                gaCay = false;

                pizzaHaisan = false;
                pizzaThapcam = false;
                thaido = false;
                thaixanh = false;
                pepsilemon = false;
                pepsinormal = false;


                tatTopping.execute();
                disableTopping.execute();
                soLuong.Text = "1";

                batMon.execute();

                mauNut.execute();

                addMenu.Enabled = false;


            }
        }

        private void cancelMenu_Click(object sender, EventArgs e)
        {
            cancelMenu.Enabled = false;

            batMon.execute();

            soLuong.Text = "1";
            thanhtien.Text = thanhtien.Text;
            pickFood.Text = "";
            addMenu.Enabled = false;

            gaPhoMai = false;
            gaCay = false;
            pizzaHaisan = false;
            pizzaThapcam = false;
            thaido = false;
            thaixanh = false;
            pepsilemon = false;
            pepsinormal = false;

            tuongot.Checked = false;
            tuongca.Checked = false;

            anNut.execute();

            thanhToan.Hide();


            disableTopping.execute();

            tatTopping.execute();

            mauNut.execute();
        }

        private void cay_Click(object sender, EventArgs e)
        {
            pickFood.Text = pickFood.Text + " + Vị cay";
            addMenu.Enabled = true;
            cay.Hide();
            phoMai.Hide();
            tuongot.Enabled = true;
            tuongca.Enabled = true;
            khoaitay.Enabled = true;
            banhngot.Enabled = true;
            gaCay = true;
        }

        private void thanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số tiền bạn cần thanh toán là: " + thanhtien.Text + " VNĐ" +". Vui lòng chuẩn bị đủ tiền để thanh toán cho shipper.");
            thanhtien.Text = "";
            pickFood.Text = "";
            dongia.Clear();
            cancelForm.Enabled = false;
            cancelMenu.Enabled = false;

            gaPhoMai = false;
            gaCay = false;
            pizzaHaisan = false;
            pizzaThapcam = false;
            thaido = false;
            thaixanh = false;
            pepsilemon = false;
            pepsinormal = false;

            tatTopping.execute();


            disableTopping.execute();


            batMon.execute();

            addMenu.Enabled = false;

            anNut.execute();

            thanhToan.Hide();



            mauNut.execute();

            // Hủy cái bảng
            listMon.Clear();
            orderGrid.DataSource = "";
            count = 0;

        }

        private void thanhtien_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //close form and open ManageScreen
            this.Hide();
            
        }

        private void khoaitay_CheckedChanged(object sender, EventArgs e)
        {
            if (khoaitay.Checked)
            {

                pickFood.Text = pickFood.Text + " + Khoai tây chiên";
                banhngot.Enabled = false;
            }
            else
            {
                banhngot.Enabled = true;
            }
        }

        private void banhngot_CheckedChanged(object sender, EventArgs e)
        {
            if (banhngot.Checked)
            {
                pickFood.Text = pickFood.Text + " + Bánh ngọt";
                khoaitay.Enabled = false;
            }
            else
            {
                khoaitay.Enabled = true;
            }
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            thanhtien.Text = "";
            pickFood.Text = "";
            dongia.Clear();
            cancelForm.Enabled = false;
            cancelMenu.Enabled = false;

            gaPhoMai = false;
            gaCay = false;
            pizzaHaisan = false;
            pizzaThapcam = false;
            thaido = false;
            thaixanh = false;
            pepsilemon = false;
            pepsinormal = false;

            tatTopping.execute();


            disableTopping.execute();


            batMon.execute();

            addMenu.Enabled = false;

            anNut.execute();

            thanhToan.Hide();



            mauNut.execute();

            // Hủy cái bảng
            listMon.Clear();
            orderGrid.DataSource = "";
            count = 0;
        }

        private void tranChau_CheckedChanged(object sender, EventArgs e)
        {
            if (pickFood.Text.Contains("Trân châu"))
            {
                pickFood.Text = pickFood.Text;
            }
            else
            {

                if (tranChau.Checked)
                {
                    pickFood.Text = pickFood.Text + " + Trân châu";
                }

                else
                {
                    pickFood.Text = pickFood.Text;
                }
            }
        }

        private void banhFlan_CheckedChanged(object sender, EventArgs e)
        {
            if (pickFood.Text.Contains("Bánh flan"))
            {
                pickFood.Text = pickFood.Text;
            }
            else
            {
                if (banhFlan.Checked)
                {
                    pickFood.Text = pickFood.Text + " + Bánh flan";
                }

                else
                {
                    pickFood.Text = pickFood.Text;
                }
            }
        }

        private void thachDeo_CheckedChanged(object sender, EventArgs e)
        {
            if (pickFood.Text.Contains("Thạch dẻo"))
            {
                pickFood.Text = pickFood.Text;
            }
            else
            {
                if (thachDeo.Checked)
                {
                    pickFood.Text = pickFood.Text + " + Thạch dẻo";
                }

                else
                {
                    pickFood.Text = pickFood.Text;
                }
            }
        }
    }
}
