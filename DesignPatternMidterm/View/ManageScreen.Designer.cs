namespace DesignPatternMidterm.View
{
    partial class ManageScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnManagerStaff = new System.Windows.Forms.Button();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbIntro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnManage);
            this.panel1.Controls.Add(this.btnTable);
            this.panel1.Controls.Add(this.btnManagerStaff);
            this.panel1.Controls.Add(this.btnKitchen);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Location = new System.Drawing.Point(262, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 372);
            this.panel1.TabIndex = 1;
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(0, 296);
            this.btnManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(277, 75);
            this.btnManage.TabIndex = 13;
            this.btnManage.Text = "Quản lý tài khoản";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click_1);
            // 
            // btnTable
            // 
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTable.Location = new System.Drawing.Point(0, 225);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(277, 75);
            this.btnTable.TabIndex = 9;
            this.btnTable.Text = "Quản lí bàn";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnManagerStaff
            // 
            this.btnManagerStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagerStaff.Location = new System.Drawing.Point(0, 150);
            this.btnManagerStaff.Name = "btnManagerStaff";
            this.btnManagerStaff.Size = new System.Drawing.Size(277, 75);
            this.btnManagerStaff.TabIndex = 8;
            this.btnManagerStaff.Text = "Quản lí nhân viên";
            this.btnManagerStaff.UseVisualStyleBackColor = true;
            this.btnManagerStaff.Click += new System.EventHandler(this.btnManagerStaff_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKitchen.Location = new System.Drawing.Point(0, 75);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(277, 75);
            this.btnKitchen.TabIndex = 7;
            this.btnKitchen.Text = "Khu Bếp";
            this.btnKitchen.UseVisualStyleBackColor = true;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.Location = new System.Drawing.Point(0, 0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(277, 75);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Đặt Món";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(10, 38);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(61, 15);
            this.lbLogout.TabIndex = 9;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbIntro
            // 
            this.lbIntro.AutoSize = true;
            this.lbIntro.Location = new System.Drawing.Point(10, 14);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(38, 15);
            this.lbIntro.TabIndex = 10;
            this.lbIntro.Text = "label1";
            // 
            // ManageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 530);
            this.Controls.Add(this.lbIntro);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.panel1);
            this.Name = "ManageScreen";
            this.Text = "ManageScreen";
            this.Load += new System.EventHandler(this.ManageScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnKitchen;
        private Button btnOrder;
        private Label lbLogout;
        private Label lbIntro;
        private Button btnManage;
        private Button btnTable;
        private Button btnManagerStaff;
    }
}