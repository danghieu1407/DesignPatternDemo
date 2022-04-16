using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.ChickenDecorator
{
    public class SpicyFlavor : ChickenDecorator
    {
        public SpicyFlavor(IChicken chicken) : base(chicken)
        {
        }

        public override String doChicken()
        {
            String type = base.doChicken();
            return type + addSpicyFlavor();

        }
        public override double Cost()
        {
            return 7000 +base.Cost() ;
        }
        private String addSpicyFlavor()
        {
            {
                return " Cay";
            }
        }
    }
}
