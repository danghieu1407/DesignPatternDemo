namespace DesignPatternMidterm.View
{
    partial class KitchenScreen
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
            this.pizzaThapCam = new System.Windows.Forms.Button();
            this.pizzaHaiSan = new System.Windows.Forms.Button();
            this.gaPhoMai = new System.Windows.Forms.Button();
            this.gaCay = new System.Windows.Forms.Button();
            this.bep = new System.Windows.Forms.Button();
            this.nau = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pizzaThapCam
            // 
            this.pizzaThapCam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pizzaThapCam.Location = new System.Drawing.Point(259, 221);
            this.pizzaThapCam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pizzaThapCam.Name = "pizzaThapCam";
            this.pizzaThapCam.Size = new System.Drawing.Size(166, 119);
            this.pizzaThapCam.TabIndex = 9;
            this.pizzaThapCam.Text = "Pizza Thập cẩm";
            this.pizzaThapCam.UseVisualStyleBackColor = true;
            this.pizzaThapCam.Click += new System.EventHandler(this.pizzaThapCam_Click);
            // 
            // pizzaHaiSan
            // 
            this.pizzaHaiSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pizzaHaiSan.Location = new System.Drawing.Point(53, 221);
            this.pizzaHaiSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pizzaHaiSan.Name = "pizzaHaiSan";
            this.pizzaHaiSan.Size = new System.Drawing.Size(166, 119);
            this.pizzaHaiSan.TabIndex = 8;
            this.pizzaHaiSan.Text = "Pizza Hải sản";
            this.pizzaHaiSan.UseVisualStyleBackColor = true;
            this.pizzaHaiSan.Click += new System.EventHandler(this.pizzaHaiSan_Click);
            // 
            // gaPhoMai
            // 
            this.gaPhoMai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gaPhoMai.Location = new System.Drawing.Point(259, 41);
            this.gaPhoMai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gaPhoMai.Name = "gaPhoMai";
            this.gaPhoMai.Size = new System.Drawing.Size(166, 119);
            this.gaPhoMai.TabIndex = 7;
            this.gaPhoMai.Text = "Gà rán + Vị phô mai";
            this.gaPhoMai.UseVisualStyleBackColor = true;
            this.gaPhoMai.Click += new System.EventHandler(this.gaPhoMai_Click);
            // 
            // gaCay
            // 
            this.gaCay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gaCay.Location = new System.Drawing.Point(53, 41);
            this.gaCay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gaCay.Name = "gaCay";
            this.gaCay.Size = new System.Drawing.Size(166, 119);
            this.gaCay.TabIndex = 6;
            this.gaCay.Text = "Gà rán + Vị cay";
            this.gaCay.UseVisualStyleBackColor = true;
            this.gaCay.Click += new System.EventHandler(this.gaCay_Click);
            // 
            // bep
            // 
            this.bep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bep.Enabled = false;
            this.bep.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bep.ForeColor = System.Drawing.Color.White;
            this.bep.Location = new System.Drawing.Point(473, 41);
            this.bep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bep.Name = "bep";
            this.bep.Size = new System.Drawing.Size(437, 299);
            this.bep.TabIndex = 10;
            this.bep.UseVisualStyleBackColor = false;
            // 
            // nau
            // 
            this.nau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nau.Location = new System.Drawing.Point(637, 377);
            this.nau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nau.Name = "nau";
            this.nau.Size = new System.Drawing.Size(111, 100);
            this.nau.TabIndex = 11;
            this.nau.Text = "Chế biến";
            this.nau.UseVisualStyleBackColor = true;
            this.nau.Click += new System.EventHandler(this.nau_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.IndianRed;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(473, 377);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(120, 100);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Hủy chọn";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(797, 377);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 100);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // KitchenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 505);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.nau);
            this.Controls.Add(this.bep);
            this.Controls.Add(this.pizzaThapCam);
            this.Controls.Add(this.pizzaHaiSan);
            this.Controls.Add(this.gaPhoMai);
            this.Controls.Add(this.gaCay);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KitchenScreen";
            this.Text = "KitchenScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private Button pizzaThapCam;
        private Button pizzaHaiSan;
        private Button gaPhoMai;
        private Button gaCay;
        private Button bep;
        private Button nau;
        private Button cancel;
        private Button btnExit;
    }
}