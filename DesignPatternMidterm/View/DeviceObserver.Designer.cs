namespace Demo.View
{
    partial class DeviceObserver
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
            this.MesseageText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MesseageText
            // 
            this.MesseageText.Location = new System.Drawing.Point(12, 12);
            this.MesseageText.Multiline = true;
            this.MesseageText.Name = "MesseageText";
            this.MesseageText.Size = new System.Drawing.Size(485, 80);
            this.MesseageText.TabIndex = 0;
            // 
            // DeviceObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 104);
            this.Controls.Add(this.MesseageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceObserver";
            this.Text = "DeviceObserver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox MesseageText;
    }
}