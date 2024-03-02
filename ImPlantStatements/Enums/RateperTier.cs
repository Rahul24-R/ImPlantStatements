using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImPlantStatements.Enums
{
    public enum DesignImplement
    {
        tierRange1 = 5, tierRange2 = 10

    }
    public enum PrintImplant
    {
        tierRange1 = 25, tierRange2 = 30
    }

    public class PriceCollection
    {
        public PriceCollection()
        {
            DesignImplementMap = new Dictionary<DesignImplement, float>() {
                { DesignImplement.tierRange1, 29.99f },
                { DesignImplement.tierRange2,34.99f}
            };
            PrintImplantMap = new Dictionary<PrintImplant, float>()
            {
                {PrintImplant.tierRange1,49.99f },
                {PrintImplant.tierRange2, 59.99f }
            };
        }
        public Dictionary<DesignImplement, float> DesignImplementMap { get; private set; }
        public Dictionary<PrintImplant, float> PrintImplantMap { get; private set; }
    }
}
