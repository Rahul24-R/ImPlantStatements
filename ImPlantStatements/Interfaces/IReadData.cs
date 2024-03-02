using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImPlantStatements.Interfaces
{
    public interface IReadData
    {
         bool ReadInput(out DataModel data,string jsonFile);
    }
}
