using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.TemplateMethodPattern
{
    public class PizzaFood : FoodTemplate
    {
        protected override string prepairMaterial()
        {
            return "Chuẩn bị bột bánh";
        }
        protected override string preprocessing()
        {
            return "Xếp khuôn vào bột và nguyên liệu";
        }
        protected override string processing()
        {
            return "Để lò nướng vào khuôn pizza";
        }
        protected override string taste(string n)
        {
            if (n.Contains("Hải sản"))
            {
                return "Nguyên liệu là hải sản";
            }
            else
            {
                return "Nguyên liệu là thập cẩm";
            }
        }
        
    }
}
