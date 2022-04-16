using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.ChickenDecorator
{
    public class SweetCakeChick : ChickenDecorator
    {
        public SweetCakeChick(IChicken chicken) : base(chicken)
        {
        }

        public override String doChicken()
        {
            String type = base.doChicken();
            return type + addSweetCake();

        }
        public override double Cost()
        {
            return 3000 + base.Cost();
        }
        private String addSweetCake()
        {
            {
                return " + Bánh ngọt";
            }
        }
    }
}
