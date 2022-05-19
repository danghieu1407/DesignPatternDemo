using DesignPatternMidterm.ConfigDTB;
using DesignPatternMidterm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.StatePatternForManagerTable
{
    public class TableUsedState:TableState
    {
       
        public string returnSate()
        {
            return "Đang Sử Dụng";
        }
    }
}
