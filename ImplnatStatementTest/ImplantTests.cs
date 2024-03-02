using ImPlantStatements;

namespace ImplnatStatementTest
{
    public class Tests
    {

        [Test]
        public void ReadJsonFileTest()
        {
            DataModel dataModel = new DataModel();
            DataModel testDataModel = new DataModel()
            {
                isDesignImplant = true,
                designImplantQuantity = 8,
                isPrintImplant = true,
                printImplantQuantity = 18,
            };
            ReadJsonData readJsonData = new ReadJsonData();
            string fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestFiles");
            var filePath = Path.Combine(fileDirectory, "TestJsonFile.json");
            bool returndata = readJsonData.ReadInput(out dataModel, filePath);
            Assert.IsTrue(returndata);
            Assert.AreEqual(testDataModel.isDesignImplant, dataModel.isDesignImplant);
            Assert.AreEqual(testDataModel.designImplantQuantity, dataModel.designImplantQuantity);
            Assert.AreEqual(testDataModel.isPrintImplant, dataModel.isPrintImplant);
            Assert.AreEqual(testDataModel.printImplantQuantity, dataModel.printImplantQuantity);
        }

        [Test]
        public void CalculateAmountTest()
        {
            DataModel testDataModel = new DataModel()
            {
                isDesignImplant = true,
                designImplantQuantity = 8,
                isPrintImplant = true,
                printImplantQuantity = 18,
            };
            float amount = Calculate.CalculateAmount(testDataModel);
            Assert.AreEqual(1154.74f, amount);
        }
    }
}