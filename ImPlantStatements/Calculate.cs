using ImPlantStatements.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ImPlantStatements
{
    public static class Calculate
    {
        
        public static float CalculateAmount(DataModel model)
        {
            PriceCollection pricemapping = new PriceCollection();
            float amount = 0f;
            if (model.isDesignImplant)
            {
                if(model.designImplantQuantity <= (int)DesignImplement.tierRange1)
                {
                    amount += model.designImplantQuantity * pricemapping.DesignImplementMap[DesignImplement.tierRange1];
                }
                if(model.designImplantQuantity > (int)DesignImplement.tierRange1)
                {
                    amount += (int)DesignImplement.tierRange1 * pricemapping.DesignImplementMap[DesignImplement.tierRange1];
                    amount+= (model.designImplantQuantity  - (int)DesignImplement.tierRange1) * pricemapping.DesignImplementMap[DesignImplement.tierRange2];
                }
            }
            if(model.isPrintImplant)
            {
                if (model.printImplantQuantity <= (int)PrintImplant.tierRange1)
                {
                    amount += model.printImplantQuantity * pricemapping.PrintImplantMap[PrintImplant.tierRange1];
                }
                if (model.printImplantQuantity > (int)PrintImplant.tierRange1)
                {
                    amount += (int)PrintImplant.tierRange1 * pricemapping.PrintImplantMap[PrintImplant.tierRange1];
                    amount += (model.printImplantQuantity - (int)PrintImplant.tierRange1) * pricemapping.PrintImplantMap[PrintImplant.tierRange2];
                }
            }
            return (float)Math.Round(amount,2);
        }
    }
}
