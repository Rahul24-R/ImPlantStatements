using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImPlantStatements.Interfaces
{
    public interface IReadData
    {
         bool ReadInput(out DataModel data,string filePath);
        // For Extension to read data from json as well as xml config in future , or to get data from any file in future
    }
}
