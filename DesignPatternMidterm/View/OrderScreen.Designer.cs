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
            this.orderGrid.Location = new System.Drawing.Point(592, 30);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.RowTemplate.Height = 25;
            this.orderGrid.Size = new System.Drawing.Size(448, 298);
            this.orderGrid.TabIndex = 14;
            // 
            // thanhtien
            // 
            this.thanhtien.Location = new System.Drawing.Point(781, 351);
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Size = new System.Drawing.Size(111, 23);
            this.thanhtien.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(694, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tổng giá:";
            // 
            // thanhToan
            // 
            this.thanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thanhToan.Location = new System.Drawing.Point(781, 384);
            this.thanhToan.Name = "thanhToan";
            this.thanhToan.Size = new System.Drawing.Size(111, 58);
            this.thanhToan.TabIndex = 17;
            this.thanhToan.Text = "Thanh toán";
            this.thanhToan.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(37, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 148);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thức ăn";
            // 
            // thapCam
            // 
            this.thapCam.Location = new System.Drawing.Point(218, 92);
            this.thapCam.Name = "thapCam";
            this.thapCam.Size = new System.Drawing.Size(57, 45);
            this.thapCam.TabIndex = 8;
            this.thapCam.Text = "Thập cẩm";
            this.thapCam.UseVisualStyleBackColor = true;
            this.thapCam.Click += new System.EventHandler(this.thapCam_Click);
            // 
            // haiSan
            // 
            this.haiSan.Location = new System.Drawing.Point(160, 92);
            this.haiSan.Name = "haiSan";
            this.haiSan.Size = new System.Drawing.Size(57, 45);
            this.haiSan.TabIndex = 7;
            this.haiSan.Text = "Hải sản";
            this.haiSan.UseVisualStyleBackColor = true;
            this.haiSan.Click += new System.EventHandler(this.haiSan_Click);
            // 
            // phoMai
            // 
            this.phoMai.Location = new System.Drawing.Point(93, 92);
            this.phoMai.Name = "phoMai";
            this.phoMai.Size = new System.Drawing.Size(61, 45);
            this.phoMai.TabIndex = 4;
            this.phoMai.Text = "Phô mai";
            this.phoMai.UseVisualStyleBackColor = true;
            this.phoMai.Click += new System.EventHandler(this.phoMai_Click);
            // 
            // cay
            // 
            this.cay.Location = new System.Drawing.Point(38, 92);
            this.cay.Name = "cay";
            this.cay.Size = new System.Drawing.Size(48, 45);
            this.cay.TabIndex = 3;
            this.cay.Text = "Cay";
            this.cay.UseVisualStyleBackColor = true;
            // 
            // pizza
            // 
            this.pizza.Location = new System.Drawing.Point(160, 22);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(115, 64);
            this.pizza.TabIndex = 2;
            this.pizza.Text = "Pizza";
            this.pizza.UseVisualStyleBackColor = true;
            this.pizza.Click += new System.EventHandler(this.pizza_Click);
            // 
            // gaRan
            // 
            this.gaRan.Location = new System.Drawing.Point(38, 22);
            this.gaRan.Name = "gaRan";
            this.gaRan.Size = new System.Drawing.Size(116, 64);
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
            this.groupBox2.Location = new System.Drawing.Point(371, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 148);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phần thêm";
            // 
            // banhngot
            // 
            this.banhngot.AutoSize = true;
            this.banhngot.Location = new System.Drawing.Point(54, 97);
            this.banhngot.Name = "banhngot";
            this.banhngot.Size = new System.Drawing.Size(83, 19);
            this.banhngot.TabIndex = 3;
            this.banhngot.Text = "Bánh ngọt";
            this.banhngot.UseVisualStyleBackColor = true;
            this.banhngot.CheckedChanged += new System.EventHandler(this.banhngot_CheckedChanged);
            // 
            // khoaitay
            // 
            this.khoaitay.AutoSize = true;
            this.khoaitay.Location = new System.Drawing.Point(54, 72);
            this.khoaitay.Name = "khoaitay";
            this.khoaitay.Size = new System.Drawing.Size(110, 19);
            this.khoaitay.TabIndex = 2;
            this.khoaitay.Text = "Khoai tây chiên";
            this.khoaitay.UseVisualStyleBackColor = true;
            this.khoaitay.CheckedChanged += new System.EventHandler(this.khoaitay_CheckedChanged);
            // 
            // tuongca
            // 
            this.tuongca.AutoSize = true;
            this.tuongca.Location = new System.Drawing.Point(54, 47);
            this.tuongca.Name = "tuongca";
            this.tuongca.Size = new System.Drawing.Size(78, 19);
            this.tuongca.TabIndex = 1;
            this.tuongca.Text = "Tương cà";
            this.tuongca.UseVisualStyleBackColor = true;
            this.tuongca.CheckedChanged += new System.EventHandler(this.tuongca_CheckedChanged);
            // 
            // tuongot
            // 
            this.tuongot.AutoSize = true;
            this.tuongot.Location = new System.Drawing.Point(54, 22);
            this.tuongot.Name = "tuongot";
            this.tuongot.Size = new System.Drawing.Size(79, 19);
            this.tuongot.TabIndex = 0;
            this.tuongot.Text = "Tương ớt";
            this.tuongot.UseVisualStyleBackColor = true;
            this.tuongot.CheckedChanged += new System.EventHandler(this.tuongot_CheckedChanged);
            // 
            // cancelMenu
            // 
            this.cancelMenu.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelMenu.Location = new System.Drawing.Point(346, 421);
            this.cancelMenu.Name = "cancelMenu";
            this.cancelMenu.Size = new System.Drawing.Size(101, 51);
            this.cancelMenu.TabIndex = 25;
            this.cancelMenu.Text = "Hủy chọn món này";
            this.cancelMenu.UseVisualStyleBackColor = false;
            // 
            // cancelForm
            // 
            this.cancelForm.BackColor = System.Drawing.Color.Red;
            this.cancelForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelForm.Location = new System.Drawing.Point(939, 548);
            this.cancelForm.Name = "cancelForm";
            this.cancelForm.Size = new System.Drawing.Size(101, 51);
            this.cancelForm.TabIndex = 24;
            this.cancelForm.Text = "Hủy đơn";
            this.cancelForm.UseVisualStyleBackColor = false;
            this.cancelForm.Click += new System.EventHandler(this.cancelForm_Click);
            // 
            // addMenu
            // 
            this.addMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMenu.Location = new System.Drawing.Point(346, 525);
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(101, 51);
            this.addMenu.TabIndex = 23;
            this.addMenu.Text = "Thêm";
            this.addMenu.UseVisualStyleBackColor = true;
            this.addMenu.Click += new System.EventHandler(this.addMenu_Click);
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(124, 419);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(188, 23);
            this.soLuong.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số lượng:";
            // 
            // pickFood
            // 
            this.pickFood.Location = new System.Drawing.Point(22, 480);
            this.pickFood.Name = "pickFood";
            this.pickFood.Size = new System.Drawing.Size(277, 96);
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
            this.groupBox3.Location = new System.Drawing.Point(37, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 144);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nước uống";
            // 
            // thaiDo
            // 
            this.thaiDo.Location = new System.Drawing.Point(215, 92);
            this.thaiDo.Name = "thaiDo";
            this.thaiDo.Size = new System.Drawing.Size(61, 45);
            this.thaiDo.TabIndex = 17;
            this.thaiDo.Text = "Thái đỏ";
            this.thaiDo.UseVisualStyleBackColor = true;
            this.thaiDo.Click += new System.EventHandler(this.thaiDo_Click);
            // 
            // traSua
            // 
            this.traSua.Location = new System.Drawing.Point(160, 22);
            this.traSua.Name = "traSua";
            this.traSua.Size = new System.Drawing.Size(116, 64);
            this.traSua.TabIndex = 15;
            this.traSua.Text = "Trà sữa";
            this.traSua.UseVisualStyleBackColor = true;
            this.traSua.Click += new System.EventHandler(this.traSua_Click);
            // 
            // thaiXanh
            // 
            this.thaiXanh.Location = new System.Drawing.Point(160, 92);
            this.thaiXanh.Name = "thaiXanh";
            this.thaiXanh.Size = new System.Drawing.Size(48, 45);
            this.thaiXanh.TabIndex = 16;
            this.thaiXanh.Text = "Thái xanh";
            this.thaiXanh.UseVisualStyleBackColor = true;
            this.thaiXanh.Click += new System.EventHandler(this.thaiXanh_Click);
            // 
            // normal
            // 
            this.normal.Location = new System.Drawing.Point(93, 92);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(61, 45);
            this.normal.TabIndex = 11;
            this.normal.Text = "Vị thường";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // pepsi
            // 
            this.pepsi.Location = new System.Drawing.Point(38, 22);
            this.pepsi.Name = "pepsi";
            this.pepsi.Size = new System.Drawing.Size(116, 64);
            this.pepsi.TabIndex = 9;
            this.pepsi.Text = "Pepsi";
            this.pepsi.UseVisualStyleBackColor = true;
            this.pepsi.Click += new System.EventHandler(this.pepsi_Click);
            // 
            // lemon
            // 
            this.lemon.Location = new System.Drawing.Point(38, 92);
            this.lemon.Name = "lemon";
            this.lemon.Size = new System.Drawing.Size(48, 45);
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
            this.groupBox4.Location = new System.Drawing.Point(371, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 144);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Topping";
            // 
            // thachDeo
            // 
            this.thachDeo.AutoSize = true;
            this.thachDeo.Location = new System.Drawing.Point(53, 72);
            this.thachDeo.Name = "thachDeo";
            this.thachDeo.Size = new System.Drawing.Size(83, 19);
            this.thachDeo.TabIndex = 6;
            this.thachDeo.Text = "Thạch dẻo";
            this.thachDeo.UseVisualStyleBackColor = true;
            this.thachDeo.CheckedChanged += new System.EventHandler(this.thachDeo_CheckedChanged);
            // 
            // banhFlan
            // 
            this.banhFlan.AutoSize = true;
            this.banhFlan.Location = new System.Drawing.Point(53, 47);
            this.banhFlan.Name = "banhFlan";
            this.banhFlan.Size = new System.Drawing.Size(78, 19);
            this.banhFlan.TabIndex = 5;
            this.banhFlan.Text = "Bánh flan";
            this.banhFlan.UseVisualStyleBackColor = true;
            this.banhFlan.CheckedChanged += new System.EventHandler(this.banhFlan_CheckedChanged);
            // 
            // tranChau
            // 
            this.tranChau.AutoSize = true;
            this.tranChau.Location = new System.Drawing.Point(53, 22);
            this.tranChau.Name = "tranChau";
            this.tranChau.Size = new System.Drawing.Size(79, 19);
            this.tranChau.TabIndex = 4;
            this.tranChau.Text = "Trân châu";
            this.tranChau.UseVisualStyleBackColor = true;
            this.tranChau.CheckedChanged += new System.EventHandler(this.tranChau_CheckedChanged);
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 611);
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
    }
}