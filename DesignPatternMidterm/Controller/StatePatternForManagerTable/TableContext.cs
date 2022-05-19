using DesignPatternMidterm.ConfigDTB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.StatePatternForManagerTable
{
    public class TableContext
    {
        private TableState state;
        public void SetStatus(int id, TableState state)
        { 
            int status = 0;
            this.state = state;
            if(state is TableUsedState)
            {
                status = 1;
            }
            else if(state is TableFreeState)
            {
                status = 0;
            }
            else if (state is TableOrderedState)
            {
                status = 2;
            }

            string Query = "Update BanAn set status_table = '"+status+"' where id_table ='" + id + "'";
            DatabaseProvide.getInstance().Query(Query);
           
        }
        public string applyState()
        {
            return this.state.returnSate();
        }
    }
}