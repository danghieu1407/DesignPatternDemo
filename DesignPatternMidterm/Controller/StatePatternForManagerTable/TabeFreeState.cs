using DesignPatternMidterm.ConfigDTB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.StatePatternForManagerTable
{
    public class TableFreeState : TableState
    {
       
        public string returnSate()
        {
            return "Còn Trống";
        }
    }
}
