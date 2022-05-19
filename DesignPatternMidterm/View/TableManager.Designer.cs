namespace Demo.View
{
    partial class TableManager
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
            this.flListTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFree = new System.Windows.Forms.Button();
            this.btnOrdered = new System.Windows.Forms.Button();
            this.btnUsed = new System.Windows.Forms.Button();
            this.status_table = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_table = new System.Windows.Forms.TextBox();
            this.TableID = new System.Windows.Forms.TextBox();
            this.Idtable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddTable = new System.Windows.Forms.Button();
            this.EditTable = new System.Windows.Forms.Button();
            this.DeleteTable = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flListTable
            // 
            this.flListTable.AutoScroll = true;
            this.flListTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flListTable.Location = new System.Drawing.Point(0, 0);
            this.flListTable.Name = "flListTable";
            this.flListTable.Size = new System.Drawing.Size(531, 450);
            this.flListTable.TabIndex = 0;
            // 
            // btnFree
            // 
            this.btnFree.BackColor = System.Drawing.Color.White;
            this.btnFree.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFree.Location = new System.Drawing.Point(0, 0);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(59, 60);
            this.btnFree.TabIndex = 1;
            this.btnFree.Text = "Bàn Trống";
            this.btnFree.UseVisualStyleBackColor = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnOrdered
            // 
            this.btnOrdered.BackColor = System.Drawing.Color.Yellow;
            this.btnOrdered.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrdered.Location = new System.Drawing.Point(59, 0);
            this.btnOrdered.Name = "btnOrdered";
            this.btnOrdered.Size = new System.Drawing.Size(60, 60);
            this.btnOrdered.TabIndex = 2;
            this.btnOrdered.Text = "Đã đặt trước";
            this.btnOrdered.UseVisualStyleBackColor = false;
            this.btnOrdered.Click += new System.EventHandler(this.btnOrdered_Click);
            // 
            // btnUsed
            // 
            this.btnUsed.BackColor = System.Drawing.Color.Red;
            this.btnUsed.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUsed.Location = new System.Drawing.Point(119, 0);
            this.btnUsed.Name = "btnUsed";
            this.btnUsed.Size = new System.Drawing.Size(60, 60);
            this.btnUsed.TabIndex = 3;
            this.btnUsed.Text = "Đang Được Sử Dụng";
            this.btnUsed.UseVisualStyleBackColor = false;
            this.btnUsed.Click += new System.EventHandler(this.btnUsed_Click);
            // 
            // status_table
            // 
            this.status_table.AcceptsReturn = true;
            this.status_table.Location = new System.Drawing.Point(70, 88);
            this.status_table.Name = "status_table";
            this.status_table.Size = new System.Drawing.Size(178, 23);
            this.status_table.TabIndex = 5;
            this.status_table.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUsed);
            this.panel1.Controls.Add(this.btnOrdered);
            this.panel1.Controls.Add(this.btnFree);
            this.panel1.Location = new System.Drawing.Point(564, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 60);
            this.panel1.TabIndex = 5;
            // 
            // name_table
            // 
            this.name_table.AcceptsReturn = true;
            this.name_table.Location = new System.Drawing.Point(70, 44);
            this.name_table.Name = "name_table";
            this.name_table.Size = new System.Drawing.Size(178, 23);
            this.name_table.TabIndex = 6;
            // 
            // TableID
            // 
            this.TableID.AcceptsReturn = true;
            this.TableID.Location = new System.Drawing.Point(70, 2);
            this.TableID.Name = "TableID";
            this.TableID.Size = new System.Drawing.Size(178, 23);
            this.TableID.TabIndex = 7;
            // 
            // Idtable
            // 
            this.Idtable.AutoSize = true;
            this.Idtable.Location = new System.Drawing.Point(3, 10);
            this.Idtable.Name = "Idtable";
            this.Idtable.Size = new System.Drawing.Size(41, 15);
            this.Idtable.TabIndex = 8;
            this.Idtable.Text = "ID Bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trạng Thái";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TableID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.status_table);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.name_table);
            this.panel2.Controls.Add(this.Idtable);
            this.panel2.Location = new System.Drawing.Point(537, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 116);
            this.panel2.TabIndex = 11;
            // 
            // AddTable
            // 
            this.AddTable.Location = new System.Drawing.Point(540, 209);
            this.AddTable.Name = "AddTable";
            this.AddTable.Size = new System.Drawing.Size(75, 54);
            this.AddTable.TabIndex = 12;
            this.AddTable.Text = "Thêm";
            this.AddTable.UseVisualStyleBackColor = true;
            this.AddTable.Click += new System.EventHandler(this.AddTable_Click);
            // 
            // EditTable
            // 
            this.EditTable.Location = new System.Drawing.Point(621, 209);
            this.EditTable.Name = "EditTable";
            this.EditTable.Size = new System.Drawing.Size(75, 54);
            this.EditTable.TabIndex = 13;
            this.EditTable.Text = "Sửa";
            this.EditTable.UseVisualStyleBackColor = true;
            this.EditTable.Click += new System.EventHandler(this.EditTable_Click);
            // 
            // DeleteTable
            // 
            this.DeleteTable.Location = new System.Drawing.Point(702, 209);
            this.DeleteTable.Name = "DeleteTable";
            this.DeleteTable.Size = new System.Drawing.Size(75, 54);
            this.DeleteTable.TabIndex = 14;
            this.DeleteTable.Text = "Xóa";
            this.DeleteTable.UseVisualStyleBackColor = true;
            this.DeleteTable.Click += new System.EventHandler(this.DeleteTable_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(545, 274);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(232, 52);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DeleteTable);
            this.Controls.Add(this.EditTable);
            this.Controls.Add(this.AddTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flListTable);
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManager";
            this.Load += new System.EventHandler(this.TableManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flListTable;
        private Button btnFree;
        private Button btnOrdered;
        private Button btnUsed;
        private TextBox status_table;
        private Panel panel1;
        private TextBox name_table;
        private TextBox TableID;
        private Label Idtable;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button AddTable;
        private Button EditTable;
        private Button DeleteTable;
        private Button Clear;
    }
}