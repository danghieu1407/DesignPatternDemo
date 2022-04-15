using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Controller.DecoratorPattern.ChickenDecorator
{
    public class Chicken : IChicken
    {
        public String doChicken()
        {
            return " + Gà rán";
        }
        public double Cost()
        {
            return 25000 ;
        }
    }
}
