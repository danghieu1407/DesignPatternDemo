using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.MilkTeaDecorator
{
    
    public class RedMilkTea : MilkTeaDecorator
    {
        public RedMilkTea(IMilkTea milktea) : base(milktea)
        {
        }

        public override String doMilkTea()
        {
            String type = base.doMilkTea();
            return type + addThaiDo();

        }
        public override double Cost()
        {
            return 7000 + base.Cost();
        }
        private String addThaiDo()
        {
            {
                return " Thái đỏ";
            }
        }
    }
}
