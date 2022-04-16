using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.TemplateMethodPattern
{
    
    public class GaranFood : FoodTemplate
    {
        protected override string prepairMaterial()
        {
            return "Chuẩn bị cánh gà, đùi gà, ức gà và gia vị";
        }
        protected override string preprocessing()
        {
            return "Tẩm gia vị vào gà";
        }
        protected override string processing()
        {
            return "Bỏ gà vào chảo chiên";
        }
        protected override string taste(string n)
        {
            if (n.Contains("Vị cay"))
            {
                return "Thêm vị cay vào gà";
            }
            else 
            {
                return "Thêm vị phô mai vào gà";
            }

        }

    }
}
