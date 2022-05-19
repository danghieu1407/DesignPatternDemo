using DesignPatternMidterm.ConfigDTB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.StatePatternForManagerTable
{
    public class TableOrderedState : TableState
    {
       
        public string returnSate()
        {
            return "Đã Đặt Trước";
        }
    }
}
