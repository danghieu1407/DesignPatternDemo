using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.DecoratorPattern.MilkTeaDecorator
{
    
     public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea mMilkTea;

        protected MilkTeaDecorator(IMilkTea milktea)
        {
            mMilkTea = milktea;
        }

        public IMilkTea getChicken()
        {
            return mMilkTea;
        }

        public void setChicken(IMilkTea mMilkTea)
        {
            this.mMilkTea = mMilkTea;
        }

        public virtual double Cost()
        {
            return mMilkTea.Cost();
        }
        public virtual String doMilkTea()
        {
            return mMilkTea.doMilkTea();
        }
    }
}
