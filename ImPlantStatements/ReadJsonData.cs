using ImPlantStatements.Interfaces;
using Newtonsoft.Json;
using System.Text.Json;
using JsonException = System.Text.Json.JsonException;

namespace ImPlantStatements
{
    public  class ReadJsonData : IReadData
    {
        public string filePath { get; set; }
        public ReadJsonData()
        {
            string fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Files");
            filePath = Path.Combine(fileDirectory, "DataInput.json");
        }
        public  bool ReadInput(out DataModel modelData,string jsonFile)
        {
            if(File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    modelData = JsonConvert.DeserializeObject<DataModel>(jsonString);
                    if (modelData != null)
                    {
                        try
                        {
                            if (modelData.isDesignImplant || modelData.isPrintImplant)
                            {
                                return true;
                            }
                            return false;
                        }
                        catch (JsonException e)
                        {
                            Console.WriteLine("Error Reading Json attributes, please verify the json data and try again.");
                            throw new InvalidDataException("Invalid Json Data");
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid data in Json file, please verify the jsoan data and try again");
                    throw new InvalidDataException("Invalid Json Data");
                }

            }
            else
            {
                Console.WriteLine("File Not Found");
                throw new FileNotFoundException("The input Json File could not be found.");
            }
        }
    }
}
