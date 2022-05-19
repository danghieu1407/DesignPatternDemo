using DesignPatternMidterm.Model;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.ConfigDTB
{
    public class Staff
    {
        private static Staff instance;
        private static readonly object padlock = new object();
        private Staff() { }
        public static Staff getInstance()
        {

            lock (padlock)
            {
                if (instance == null)
                    instance = new Staff();
                return instance;
            }
        }
        public List<StaffModel> LoadStaffs()
        {
            string query = "select * from Account";
            List<StaffModel> tables = new List<StaffModel>();
            DataTable data = DatabaseProvide.getInstance().Query(query);
            foreach (DataRow item in data.Rows)
            {
                StaffModel table = new StaffModel(item);
                tables.Add(table);

            }
            return tables;
        }

        public static int getW = 100;
        public static int getH = 100;
    }
}

