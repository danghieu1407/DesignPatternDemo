using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.MilkTeaDecorator
{
    public class MilkTea : IMilkTea
    {
        public String doMilkTea()
        {
            return " + Trà sữa";
        }
        public double Cost()
        {
            return 15000;
        }
    }
}
