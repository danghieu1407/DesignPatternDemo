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
            return "Tẩm gà vào gia vị";
        }
        protected override string processing()
        {
            return "Bỏ chảo dầu vào gà";
        }
        protected override string taste(string n)
        {
            if (n.Contains("Vị cay"))
            {
                return "Thêm gà vào vị cay";
            }
            else 
            {
                return "Thêm gà vào phô mai";
            }

        }

    }
}
