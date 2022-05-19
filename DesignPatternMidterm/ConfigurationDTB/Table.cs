using System;
using DesignPatternMidterm.Model;
using DesignPatternMidterm.ConfigDTB;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.ConfigDTB
{
    public  class Table
    {
        private static Table instance;
        private static readonly object padlock = new object();
        private Table() { }
        public static Table getInstance()
        {

            lock (padlock)
            {
                if (instance == null)
                    instance = new Table();
                return instance;
            }
        }
        public List<TableModel> LoadTables()
        {
            string query = "select * from BanAn";
            List<TableModel> tables = new List<TableModel>();
            DataTable data = DatabaseProvide.getInstance().Query(query);
            foreach (DataRow item in data.Rows)
            {
                TableModel table = new TableModel(item);
                tables.Add(table);

            }
            return tables;
        }

        public static int getW = 100;
        public static int getH = 100;
    }
}
