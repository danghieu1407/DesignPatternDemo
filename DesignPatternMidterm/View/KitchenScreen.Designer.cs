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
            this.SuspendLayout();
            // 
            // pizzaThapCam
            // 
            this.pizzaThapCam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pizzaThapCam.Location = new System.Drawing.Point(227, 166);
            this.pizzaThapCam.Name = "pizzaThapCam";
            this.pizzaThapCam.Size = new System.Drawing.Size(145, 89);
            this.pizzaThapCam.TabIndex = 9;
            this.pizzaThapCam.Text = "Pizza Thập cẩm";
            this.pizzaThapCam.UseVisualStyleBackColor = true;
            this.pizzaThapCam.Click += new System.EventHandler(this.pizzaThapCam_Click);
            // 
            // pizzaHaiSan
            // 
            this.pizzaHaiSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pizzaHaiSan.Location = new System.Drawing.Point(46, 166);
            this.pizzaHaiSan.Name = "pizzaHaiSan";
            this.pizzaHaiSan.Size = new System.Drawing.Size(145, 89);
            this.pizzaHaiSan.TabIndex = 8;
            this.pizzaHaiSan.Text = "Pizza Hải sản";
            this.pizzaHaiSan.UseVisualStyleBackColor = true;
            this.pizzaHaiSan.Click += new System.EventHandler(this.pizzaHaiSan_Click);
            // 
            // gaPhoMai
            // 
            this.gaPhoMai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gaPhoMai.Location = new System.Drawing.Point(227, 31);
            this.gaPhoMai.Name = "gaPhoMai";
            this.gaPhoMai.Size = new System.Drawing.Size(145, 89);
            this.gaPhoMai.TabIndex = 7;
            this.gaPhoMai.Text = "Gà rán + Vị phô mai";
            this.gaPhoMai.UseVisualStyleBackColor = true;
            this.gaPhoMai.Click += new System.EventHandler(this.gaPhoMai_Click);
            // 
            // gaCay
            // 
            this.gaCay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gaCay.Location = new System.Drawing.Point(46, 31);
            this.gaCay.Name = "gaCay";
            this.gaCay.Size = new System.Drawing.Size(145, 89);
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
            this.bep.Location = new System.Drawing.Point(414, 31);
            this.bep.Name = "bep";
            this.bep.Size = new System.Drawing.Size(345, 224);
            this.bep.TabIndex = 10;
            this.bep.UseVisualStyleBackColor = false;
            // 
            // nau
            // 
            this.nau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nau.Location = new System.Drawing.Point(625, 283);
            this.nau.Name = "nau";
            this.nau.Size = new System.Drawing.Size(114, 75);
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
            this.cancel.Location = new System.Drawing.Point(464, 283);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 75);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Hủy chọn";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // KitchenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 379);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.nau);
            this.Controls.Add(this.bep);
            this.Controls.Add(this.pizzaThapCam);
            this.Controls.Add(this.pizzaHaiSan);
            this.Controls.Add(this.gaPhoMai);
            this.Controls.Add(this.gaCay);
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
    }
}