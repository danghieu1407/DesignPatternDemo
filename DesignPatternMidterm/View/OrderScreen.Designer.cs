namespace DesignPatternMidterm.View
{
    partial class OrderScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.thanhtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thanhToan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thapCam = new System.Windows.Forms.Button();
            this.haiSan = new System.Windows.Forms.Button();
            this.phoMai = new System.Windows.Forms.Button();
            this.cay = new System.Windows.Forms.Button();
            this.pizza = new System.Windows.Forms.Button();
            this.gaRan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.banhngot = new System.Windows.Forms.CheckBox();
            this.khoaitay = new System.Windows.Forms.CheckBox();
            this.tuongca = new System.Windows.Forms.CheckBox();
            this.tuongot = new System.Windows.Forms.CheckBox();
            this.cancelMenu = new System.Windows.Forms.Button();
            this.cancelForm = new System.Windows.Forms.Button();
            this.addMenu = new System.Windows.Forms.Button();
            this.soLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pickFood = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.thaiDo = new System.Windows.Forms.Button();
            this.traSua = new System.Windows.Forms.Button();
            this.thaiXanh = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.Button();
            this.pepsi = new System.Windows.Forms.Button();
            this.lemon = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.thachDeo = new System.Windows.Forms.CheckBox();
            this.banhFlan = new System.Windows.Forms.CheckBox();
            this.tranChau = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGrid
            // 
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Location = new System.Drawing.Point(677, 40);
            this.orderGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.RowHeadersWidth = 51;
            this.orderGrid.RowTemplate.Height = 25;
            this.orderGrid.Size = new System.Drawing.Size(512, 397);
            this.orderGrid.TabIndex = 14;
            // 
            // thanhtien
            // 
            this.thanhtien.Location = new System.Drawing.Point(893, 468);
            this.thanhtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Size = new System.Drawing.Size(126, 27);
            this.thanhtien.TabIndex = 16;
            this.thanhtien.TextChanged += new System.EventHandler(this.thanhtien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(793, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tổng giá:";
            // 
            // thanhToan
            // 
            this.thanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thanhToan.Location = new System.Drawing.Point(893, 512);
            this.thanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thanhToan.Name = "thanhToan";
            this.thanhToan.Size = new System.Drawing.Size(127, 77);
            this.thanhToan.TabIndex = 17;
            this.thanhToan.Text = "Thanh toán";
            this.thanhToan.UseVisualStyleBackColor = true;
            this.thanhToan.Click += new System.EventHandler(this.thanhToan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.thapCam);
            this.groupBox1.Controls.Add(this.haiSan);
            this.groupBox1.Controls.Add(this.phoMai);
            this.groupBox1.Controls.Add(this.cay);
            this.groupBox1.Controls.Add(this.pizza);
            this.groupBox1.Controls.Add(this.gaRan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(42, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(354, 197);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thức ăn";
            // 
            // thapCam
            // 
            this.thapCam.Location = new System.Drawing.Point(249, 123);
            this.thapCam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thapCam.Name = "thapCam";
            this.thapCam.Size = new System.Drawing.Size(65, 60);
            this.thapCam.TabIndex = 8;
            this.thapCam.Text = "Thập cẩm";
            this.thapCam.UseVisualStyleBackColor = true;
            this.thapCam.Click += new System.EventHandler(this.thapCam_Click);
            // 
            // haiSan
            // 
            this.haiSan.Location = new System.Drawing.Point(183, 123);
            this.haiSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.haiSan.Name = "haiSan";
            this.haiSan.Size = new System.Drawing.Size(65, 60);
            this.haiSan.TabIndex = 7;
            this.haiSan.Text = "Hải sản";
            this.haiSan.UseVisualStyleBackColor = true;
            this.haiSan.Click += new System.EventHandler(this.haiSan_Click);
            // 
            // phoMai
            // 
            this.phoMai.Location = new System.Drawing.Point(106, 123);
            this.phoMai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoMai.Name = "phoMai";
            this.phoMai.Size = new System.Drawing.Size(70, 60);
            this.phoMai.TabIndex = 4;
            this.phoMai.Text = "Phô mai";
            this.phoMai.UseVisualStyleBackColor = true;
            this.phoMai.Click += new System.EventHandler(this.phoMai_Click);
            // 
            // cay
            // 
            this.cay.Location = new System.Drawing.Point(43, 123);
            this.cay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cay.Name = "cay";
            this.cay.Size = new System.Drawing.Size(55, 60);
            this.cay.TabIndex = 3;
            this.cay.Text = "Cay";
            this.cay.UseVisualStyleBackColor = true;
            this.cay.Click += new System.EventHandler(this.cay_Click);
            // 
            // pizza
            // 
            this.pizza.Location = new System.Drawing.Point(183, 29);
            this.pizza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(131, 85);
            this.pizza.TabIndex = 2;
            this.pizza.Text = "Pizza";
            this.pizza.UseVisualStyleBackColor = true;
            this.pizza.Click += new System.EventHandler(this.pizza_Click);
            // 
            // gaRan
            // 
            this.gaRan.Location = new System.Drawing.Point(43, 29);
            this.gaRan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gaRan.Name = "gaRan";
            this.gaRan.Size = new System.Drawing.Size(133, 85);
            this.gaRan.TabIndex = 0;
            this.gaRan.Text = "Gà rán";
            this.gaRan.UseVisualStyleBackColor = true;
            this.gaRan.Click += new System.EventHandler(this.gaRan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.banhngot);
            this.groupBox2.Controls.Add(this.khoaitay);
            this.groupBox2.Controls.Add(this.tuongca);
            this.groupBox2.Controls.Add(this.tuongot);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(424, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(229, 197);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phần thêm";
            // 
            // banhngot
            // 
            this.banhngot.AutoSize = true;
            this.banhngot.Location = new System.Drawing.Point(62, 129);
            this.banhngot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.banhngot.Name = "banhngot";
            this.banhngot.Size = new System.Drawing.Size(104, 24);
            this.banhngot.TabIndex = 3;
            this.banhngot.Text = "Bánh ngọt";
            this.banhngot.UseVisualStyleBackColor = true;
            this.banhngot.CheckedChanged += new System.EventHandler(this.banhngot_CheckedChanged);
            // 
            // khoaitay
            // 
            this.khoaitay.AutoSize = true;
            this.khoaitay.Location = new System.Drawing.Point(62, 96);
            this.khoaitay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.khoaitay.Name = "khoaitay";
            this.khoaitay.Size = new System.Drawing.Size(138, 24);
            this.khoaitay.TabIndex = 2;
            this.khoaitay.Text = "Khoai tây chiên";
            this.khoaitay.UseVisualStyleBackColor = true;
            this.khoaitay.CheckedChanged += new System.EventHandler(this.khoaitay_CheckedChanged);
            // 
            // tuongca
            // 
            this.tuongca.AutoSize = true;
            this.tuongca.Location = new System.Drawing.Point(62, 63);
            this.tuongca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tuongca.Name = "tuongca";
            this.tuongca.Size = new System.Drawing.Size(96, 24);
            this.tuongca.TabIndex = 1;
            this.tuongca.Text = "Tương cà";
            this.tuongca.UseVisualStyleBackColor = true;
            this.tuongca.CheckedChanged += new System.EventHandler(this.tuongca_CheckedChanged);
            // 
            // tuongot
            // 
            this.tuongot.AutoSize = true;
            this.tuongot.Location = new System.Drawing.Point(62, 29);
            this.tuongot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tuongot.Name = "tuongot";
            this.tuongot.Size = new System.Drawing.Size(96, 24);
            this.tuongot.TabIndex = 0;
            this.tuongot.Text = "Tương ớt";
            this.tuongot.UseVisualStyleBackColor = true;
            this.tuongot.CheckedChanged += new System.EventHandler(this.tuongot_CheckedChanged);
            // 
            // cancelMenu
            // 
            this.cancelMenu.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelMenu.Location = new System.Drawing.Point(395, 561);
            this.cancelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelMenu.Name = "cancelMenu";
            this.cancelMenu.Size = new System.Drawing.Size(115, 68);
            this.cancelMenu.TabIndex = 25;
            this.cancelMenu.Text = "Hủy chọn món này";
            this.cancelMenu.UseVisualStyleBackColor = false;
            this.cancelMenu.Click += new System.EventHandler(this.cancelMenu_Click);
            // 
            // cancelForm
            // 
            this.cancelForm.BackColor = System.Drawing.Color.Red;
            this.cancelForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelForm.Location = new System.Drawing.Point(945, 734);
            this.cancelForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelForm.Name = "cancelForm";
            this.cancelForm.Size = new System.Drawing.Size(115, 68);
            this.cancelForm.TabIndex = 24;
            this.cancelForm.Text = "Hủy đơn";
            this.cancelForm.UseVisualStyleBackColor = false;
            this.cancelForm.Click += new System.EventHandler(this.cancelForm_Click);
            // 
            // addMenu
            // 
            this.addMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMenu.Location = new System.Drawing.Point(395, 700);
            this.addMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(115, 68);
            this.addMenu.TabIndex = 23;
            this.addMenu.Text = "Thêm";
            this.addMenu.UseVisualStyleBackColor = true;
            this.addMenu.Click += new System.EventHandler(this.addMenu_Click);
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(142, 559);
            this.soLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(214, 27);
            this.soLuong.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số lượng:";
            // 
            // pickFood
            // 
            this.pickFood.Location = new System.Drawing.Point(25, 640);
            this.pickFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pickFood.Name = "pickFood";
            this.pickFood.Size = new System.Drawing.Size(316, 127);
            this.pickFood.TabIndex = 20;
            this.pickFood.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.thaiDo);
            this.groupBox3.Controls.Add(this.traSua);
            this.groupBox3.Controls.Add(this.thaiXanh);
            this.groupBox3.Controls.Add(this.normal);
            this.groupBox3.Controls.Add(this.pepsi);
            this.groupBox3.Controls.Add(this.lemon);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(42, 245);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(354, 192);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nước uống";
            // 
            // thaiDo
            // 
            this.thaiDo.Location = new System.Drawing.Point(246, 123);
            this.thaiDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thaiDo.Name = "thaiDo";
            this.thaiDo.Size = new System.Drawing.Size(70, 60);
            this.thaiDo.TabIndex = 17;
            this.thaiDo.Text = "Thái đỏ";
            this.thaiDo.UseVisualStyleBackColor = true;
            this.thaiDo.Click += new System.EventHandler(this.thaiDo_Click);
            // 
            // traSua
            // 
            this.traSua.Location = new System.Drawing.Point(183, 29);
            this.traSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.traSua.Name = "traSua";
            this.traSua.Size = new System.Drawing.Size(133, 85);
            this.traSua.TabIndex = 15;
            this.traSua.Text = "Trà sữa";
            this.traSua.UseVisualStyleBackColor = true;
            this.traSua.Click += new System.EventHandler(this.traSua_Click);
            // 
            // thaiXanh
            // 
            this.thaiXanh.Location = new System.Drawing.Point(183, 123);
            this.thaiXanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thaiXanh.Name = "thaiXanh";
            this.thaiXanh.Size = new System.Drawing.Size(55, 60);
            this.thaiXanh.TabIndex = 16;
            this.thaiXanh.Text = "Thái xanh";
            this.thaiXanh.UseVisualStyleBackColor = true;
            this.thaiXanh.Click += new System.EventHandler(this.thaiXanh_Click);
            // 
            // normal
            // 
            this.normal.Location = new System.Drawing.Point(106, 123);
            this.normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(70, 60);
            this.normal.TabIndex = 11;
            this.normal.Text = "Vị thường";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // pepsi
            // 
            this.pepsi.Location = new System.Drawing.Point(43, 29);
            this.pepsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pepsi.Name = "pepsi";
            this.pepsi.Size = new System.Drawing.Size(133, 85);
            this.pepsi.TabIndex = 9;
            this.pepsi.Text = "Pepsi";
            this.pepsi.UseVisualStyleBackColor = true;
            this.pepsi.Click += new System.EventHandler(this.pepsi_Click);
            // 
            // lemon
            // 
            this.lemon.Location = new System.Drawing.Point(43, 123);
            this.lemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lemon.Name = "lemon";
            this.lemon.Size = new System.Drawing.Size(55, 60);
            this.lemon.TabIndex = 10;
            this.lemon.Text = "Vị chanh";
            this.lemon.UseVisualStyleBackColor = true;
            this.lemon.Click += new System.EventHandler(this.lemon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.thachDeo);
            this.groupBox4.Controls.Add(this.banhFlan);
            this.groupBox4.Controls.Add(this.tranChau);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(424, 245);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(229, 192);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Topping";
            // 
            // thachDeo
            // 
            this.thachDeo.AutoSize = true;
            this.thachDeo.Location = new System.Drawing.Point(61, 96);
            this.thachDeo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thachDeo.Name = "thachDeo";
            this.thachDeo.Size = new System.Drawing.Size(103, 24);
            this.thachDeo.TabIndex = 6;
            this.thachDeo.Text = "Thạch dẻo";
            this.thachDeo.UseVisualStyleBackColor = true;
            this.thachDeo.CheckedChanged += new System.EventHandler(this.thachDeo_CheckedChanged);
            // 
            // banhFlan
            // 
            this.banhFlan.AutoSize = true;
            this.banhFlan.Location = new System.Drawing.Point(61, 63);
            this.banhFlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.banhFlan.Name = "banhFlan";
            this.banhFlan.Size = new System.Drawing.Size(98, 24);
            this.banhFlan.TabIndex = 5;
            this.banhFlan.Text = "Bánh flan";
            this.banhFlan.UseVisualStyleBackColor = true;
            this.banhFlan.CheckedChanged += new System.EventHandler(this.banhFlan_CheckedChanged);
            // 
            // tranChau
            // 
            this.tranChau.AutoSize = true;
            this.tranChau.Location = new System.Drawing.Point(61, 29);
            this.tranChau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tranChau.Name = "tranChau";
            this.tranChau.Size = new System.Drawing.Size(99, 24);
            this.tranChau.TabIndex = 4;
            this.tranChau.Text = "Trân châu";
            this.tranChau.UseVisualStyleBackColor = true;
            this.tranChau.CheckedChanged += new System.EventHandler(this.tranChau_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1087, 734);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 68);
            this.button1.TabIndex = 28;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 815);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancelMenu);
            this.Controls.Add(this.cancelForm);
            this.Controls.Add(this.addMenu);
            this.Controls.Add(this.soLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickFood);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thanhToan);
            this.Controls.Add(this.thanhtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderScreen";
            this.Text = "OrderScreen";
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView orderGrid;
        private TextBox thanhtien;
        private Label label1;
        private Button thanhToan;
        private GroupBox groupBox1;
        private Button thapCam;
        private Button haiSan;
        private Button phoMai;
        private Button cay;
        private Button pizza;
        private Button gaRan;
        private GroupBox groupBox2;
        private CheckBox banhngot;
        private CheckBox khoaitay;
        private CheckBox tuongca;
        private CheckBox tuongot;
        private Button cancelMenu;
        private Button cancelForm;
        private Button addMenu;
        private TextBox soLuong;
        private Label label2;
        private RichTextBox pickFood;
        private GroupBox groupBox3;
        private Button thaiDo;
        private Button traSua;
        private Button thaiXanh;
        private Button normal;
        private Button pepsi;
        private Button lemon;
        private GroupBox groupBox4;
        private CheckBox thachDeo;
        private CheckBox banhFlan;
        private CheckBox tranChau;
        private Button button1;
    }
}