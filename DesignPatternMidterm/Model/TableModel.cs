using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Model
{
    public class TableModel
    {
        private int id;
        private string name;
        private string status;

        public int ID
        { get => id; 
          set => id = value; 
        }
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public string Status 
        { 
            get => status; 
            set => status = value; 
        }

        public TableModel(int id,string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }

        public TableModel(DataRow row)
        {
            this.id = (int)row["id_table"];
            this.name = row["name_table"].ToString();
            this.status = row["status_table"].ToString(); 
        }    

    }
}
