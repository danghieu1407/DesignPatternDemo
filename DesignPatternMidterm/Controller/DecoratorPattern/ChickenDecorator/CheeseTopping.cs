using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.ChickenDecorator
{
    public class CheeseTopping : ChickenDecorator
    {
        public CheeseTopping(IChicken chicken) : base(chicken)
        {
        }

        public override String doChicken()
        {
            String type = base.doChicken();
            return type + addCheeseFlavor();

        }
        public override double Cost()
        {
            return 5000 + base.Cost();
        }
        private String addCheeseFlavor()
        {
            {
                return " Phô mai";
            }
        }
    }
}
