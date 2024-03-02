using ImPlantStatements;
using System;

namespace Staements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadJsonData readJsonData = new ReadJsonData();
            try
            {
                Console.WriteLine("Checking For Json Data");
                DataModel dataModel = new DataModel();
                if(readJsonData.ReadInput(out dataModel,readJsonData.filePath))
                {
                    float totalAmount = Calculate.CalculateAmount(dataModel);
                    Console.WriteLine(totalAmount.ToString());
                }   //similar extension for other file read , implementing interface.
                else
                {
                    Console.WriteLine("No data provided by the user through Json");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}