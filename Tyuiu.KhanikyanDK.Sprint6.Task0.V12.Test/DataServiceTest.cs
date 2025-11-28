using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhanikyanDK.Sprint6.Task0.V12.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateWithX3()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);

            // Расчет вручную для x = 3:
            // numerator = 3² + 1 = 9 + 1 = 10
            // denominator = √(4*9 - 3) = √(36 - 3) = √33 ≈ 5.7445626465
            // result = 10 / 5.7445626465 ≈ 1.741
            double expected = 1.741;

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestCalculateWithX2()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);

            // Расчет вручную для x = 2:
            // numerator = 2² + 1 = 4 + 1 = 5
            // denominator = √(4*4 - 3) = √(16 - 3) = √13 ≈ 3.6055512755
            // result = 5 / 3.6055512755 ≈ 1.387
            double expected = 1.387;

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestCalculateWithX5()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(5);

            // Расчет вручную для x = 5:
            // numerator = 5² + 1 = 25 + 1 = 26
            // denominator = √(4*25 - 3) = √(100 - 3) = √97 ≈ 9.8488578018
            // result = 26 / 9.8488578018 ≈ 2.640
            double expected = 2.640;

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestCalculateWithInvalidX()
        {
            DataService ds = new DataService();
            // x = 0 приведет к отрицательному значению под корнем: 4*0 - 3 = -3
            ds.Calculate(0);
        }
    }
}