using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.YagodinVA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.YagodinVA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);

        }
        [TestMethod]
        public void CheckSubctractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);

        }
        [TestMethod]
        public void CheckMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.Multiplicalion(numbers);
            Assert.AreEqual(120, res);

        }
    }
}
    

