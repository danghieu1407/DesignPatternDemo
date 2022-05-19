namespace Demo.View
{
    partial class StaffManager
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
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.RoleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Upgrade = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SendMess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReplaceMess = new System.Windows.Forms.Button();
            this.DeleteMess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(27, 21);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.RowTemplate.Height = 25;
            this.dtgvStaff.Size = new System.Drawing.Size(434, 285);
            this.dtgvStaff.TabIndex = 0;
            this.dtgvStaff.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvStaff_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.Editbtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Location = new System.Drawing.Point(581, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 75);
            this.panel1.TabIndex = 1;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Deletebtn.Location = new System.Drawing.Point(150, 0);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 75);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Sa Thải";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Editbtn.Location = new System.Drawing.Point(75, 0);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(75, 75);
            this.Editbtn.TabIndex = 1;
            this.Editbtn.Text = "Sửa Thông Tin";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddBtn.Location = new System.Drawing.Point(0, 0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 75);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Thêm Nhân Viên";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(581, 47);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(227, 23);
            this.EmailText.TabIndex = 2;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(581, 117);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(227, 23);
            this.NameText.TabIndex = 3;
            // 
            // RoleText
            // 
            this.RoleText.Location = new System.Drawing.Point(581, 185);
            this.RoleText.Name = "RoleText";
            this.RoleText.Size = new System.Drawing.Size(227, 23);
            this.RoleText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chức vụ";
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(812, 278);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(84, 28);
            this.Clearbtn.TabIndex = 8;
            this.Clearbtn.Text = "Hạ Chức";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Upgrade
            // 
            this.Upgrade.Location = new System.Drawing.Point(812, 242);
            this.Upgrade.Name = "Upgrade";
            this.Upgrade.Size = new System.Drawing.Size(84, 30);
            this.Upgrade.TabIndex = 9;
            this.Upgrade.Text = "Tăng Chức";
            this.Upgrade.UseVisualStyleBackColor = true;
            this.Upgrade.Click += new System.EventHandler(this.Upgrade_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 178);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SendMess
            // 
            this.SendMess.Location = new System.Drawing.Point(41, 363);
            this.SendMess.Multiline = true;
            this.SendMess.Name = "SendMess";
            this.SendMess.Size = new System.Drawing.Size(420, 128);
            this.SendMess.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đăng Thông Báo";
            // 
            // ReplaceMess
            // 
            this.ReplaceMess.Location = new System.Drawing.Point(488, 364);
            this.ReplaceMess.Name = "ReplaceMess";
            this.ReplaceMess.Size = new System.Drawing.Size(75, 127);
            this.ReplaceMess.TabIndex = 13;
            this.ReplaceMess.Text = "Đăng Thông Báo";
            this.ReplaceMess.UseVisualStyleBackColor = true;
            this.ReplaceMess.Click += new System.EventHandler(this.ReplaceMess_Click);
            // 
            // DeleteMess
            // 
            this.DeleteMess.Location = new System.Drawing.Point(595, 364);
            this.DeleteMess.Name = "DeleteMess";
            this.DeleteMess.Size = new System.Drawing.Size(75, 127);
            this.DeleteMess.TabIndex = 15;
            this.DeleteMess.Text = "Xóa Thông Báo";
            this.DeleteMess.UseVisualStyleBackColor = true;
            this.DeleteMess.Click += new System.EventHandler(this.DeleteMess_Click);
            // 
            // StaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 563);
            this.Controls.Add(this.DeleteMess);
            this.Controls.Add(this.ReplaceMess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SendMess);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Upgrade);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvStaff);
            this.Name = "StaffManager";
            this.Text = "StaffManager";
            this.Load += new System.EventHandler(this.StaffManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvStaff;
        private Panel panel1;
        private Button Deletebtn;
        private Button Editbtn;
        private Button AddBtn;
        private TextBox EmailText;
        private TextBox NameText;
        private TextBox RoleText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Clearbtn;
        private Button Upgrade;
        private Button button2;
        private TextBox SendMess;
        private Label label4;
        private Button ReplaceMess;
        private Button DeleteMess;
    }
}