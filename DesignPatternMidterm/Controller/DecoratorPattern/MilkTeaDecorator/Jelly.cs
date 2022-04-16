using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.MilkTeaDecorator
{
    
    public class Jelly : MilkTeaDecorator
    {
        public Jelly(IMilkTea milktea) : base(milktea)
        {
        }

        public override String doMilkTea()
        {
            String type = base.doMilkTea();
            return type + addJelly();

        }
        public override double Cost()
        {
            return 5000 + base.Cost();
        }
        private String addJelly()
        {
            {
                return " + Thạch dẻo";
            }
        }
    }
}
