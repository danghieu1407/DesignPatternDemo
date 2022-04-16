using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.ChickenDecorator
{
    public interface IChicken
    {
        String doChicken();
        double Cost();
    }
}
