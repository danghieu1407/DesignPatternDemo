using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.TemplateMethodPattern
{
    
    public class HamburgerFood : FoodTemplate
    {
        protected override string prepairMaterial()
        {
            return "Chuẩn bị bánh mì và nguyên liệu";
        }
        protected override string preprocessing()
        {
            return "Cắt nguyên liệu sao cho bằng với bánh mì";
        }
        protected override string processing()
        {
            return "Xếp thịt và rau củ vào bánh mì";
        }
        protected override string taste(string n)
        {
            if (n.Contains("Thịt"))
            {
                return "Nguyên liệu gồm thịt";
            }
            else
            {
                return "Nguyên liệu gồm rau";
            }

        }
    }
}
