using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ekz;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        metodi metodi = new metodi();
        [TestMethod]
        public void TestMethod1() 
        {
            Assert.AreEqual(Convert.ToString(metodi.Procenti(675321, 6)), Convert.ToString(1.14)); // Тестовый метод для проеверки модуля по нахождению процента по вкладу
                                                                                                  // с сумой вклада 675321 у.е. и длительностью вклада в 6 недель
        }
    }
}
