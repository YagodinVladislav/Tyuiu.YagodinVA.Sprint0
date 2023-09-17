using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tyuiu.YagodinVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            
            var name = "Владислав";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет , Владислав", res);
        }
    }
}
