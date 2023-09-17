using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.YagodinVA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.YagodinVA.Sprint0.Task3.V0
{
    [TestClass]
    class Program
    {
        [TestMethod]
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Sum(7, 7));
            Console.ReadKey();
        }
    }
}
