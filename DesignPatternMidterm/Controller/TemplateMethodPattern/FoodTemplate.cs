using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.TemplateMethodPattern
{
    public abstract class FoodTemplate
    {
        string n;
        public void setString(string ne)
        {
            this.n = ne;
        }
        protected abstract string prepairMaterial();
        protected abstract string preprocessing();
        protected abstract string processing();

        protected abstract string taste(string n);
        

        public string prepareFood()
        {
            return
            prepairMaterial() + " -> " +
            preprocessing() + " -> " +
            processing() + " -> " +
            taste(n);
        }
    }
}
