using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.ChickenDecorator
{
    public abstract class ChickenDecorator : IChicken
    {
        private IChicken mChicken;
        
        protected ChickenDecorator(IChicken chicken)
        {
            mChicken = chicken;
        }

        public IChicken getChicken()
        {
            return mChicken;
        }

        public void setChicken(IChicken mChicken)
        {
            this.mChicken = mChicken;
        }

        public virtual double Cost()
        {
            return mChicken.Cost();
        }
        public virtual String doChicken()
        {
            return mChicken.doChicken();
        }
    }
}
