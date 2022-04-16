using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.MilkTeaDecorator
{
    
    public class FlanCake : MilkTeaDecorator
    {
        public FlanCake(IMilkTea milktea) : base(milktea)
        {
        }

        public override String doMilkTea()
        {
            String type = base.doMilkTea();
            return type + addFlanCake();

        }
        public override double Cost()
        {
            return 7000 + base.Cost();
        }
        private String addFlanCake()
        {
            {
                return " + Bánh flan";
            }
        }
    }
}
