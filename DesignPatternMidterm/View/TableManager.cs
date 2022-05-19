using DesignPatternMidterm.ConfigDTB;
using DesignPatternMidterm.Controller.StatePatternForManagerTable;
using DesignPatternMidterm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.View
{
    public partial class TableManager : Form
    {
        
        public TableManager()
        {
            InitializeComponent();          
            LoadTable();
        }
        TableContext tableContext = new TableContext();
        public void LoadTable()
        {
            
            flListTable.Controls.Clear();
            List<TableModel> tablelist = Table.getInstance().LoadTables();
            foreach(TableModel table in tablelist)
            {
                Button button = new Button() { Width=Table.getW,Height=Table.getH };
                button.Text = table.Name + Environment.NewLine + getStatus(table.Status);
                button.Tag = table;
                if (table.Status == "0")
                {
                    button.BackColor = Color.White;
                }
                else if(table.Status == "1")
                {
                    button.BackColor = Color.Red;
                }
                else if(table.Status == "2")
                {
                    button.BackColor = Color.Yellow;
                }    
                button.Click += button_Click;
                
                flListTable.Controls.Add(button);
            }    
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button item = (Button)sender;
            TableModel tableModel = item.Tag as TableModel;
            TableID.Text = tableModel.ID.ToString();
            name_table.Text= tableModel.Name;
            status_table.Text = getStatus(tableModel.Status);
            TableID.ReadOnly = true;
            status_table.ReadOnly = true;
        }



        string getStatus(string param)
        {
            if(param == "1")
            {
                TableState btnUsed = new TableUsedState();
                return btnUsed.returnSate();
            }   
            else if(param == "2")
            {
                TableState ordered = new TableOrderedState();
                return ordered.returnSate();
            }
            else
            {
                TableState btnFree = new TableFreeState();
                return btnFree.returnSate();
            }    
        }
        private void TableManager_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOrdered_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TableID.Text);

           tableContext.SetStatus(x, new TableOrderedState());
          
            LoadTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUsed_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TableID.Text);
            this.tableContext.SetStatus(x, new TableUsedState());
            
            LoadTable();

        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TableID.Text);
            this.tableContext.SetStatus(x,new TableFreeState());
            
            LoadTable();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TableID.Text = "";
            name_table.Text = "";
            status_table.Text = "";
            status_table.ReadOnly = false;
            TableID.ReadOnly = false;
            status_table.ReadOnly = false;
        }

        private void AddTable_Click(object sender, EventArgs e)
        {
            string Query = "insert BanAn(name_table, status_table) values ('" + name_table.Text+"','0') ";
            DatabaseProvide.getInstance().Query(Query);
            LoadTable();
        }

        private void EditTable_Click(object sender, EventArgs e)
        {
            string Query = "Update BanAn set name_table = '" + name_table.Text + "' where id_table = '"+ TableID.Text + "'";
            DatabaseProvide.getInstance().Query(Query);
            LoadTable();
        }

        private void DeleteTable_Click(object sender, EventArgs e)
        {
            string Query = "DELETE FROM BanAn WHERE id_table = '"+ TableID.Text + "' ";
            DatabaseProvide.getInstance().Query(Query);
            LoadTable();
        }
    }
}
