using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhanikyanDK.Sprint6.Task2.V17.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            // Проверяем длину массива: [-5..5] = 11 элементов
            Assert.AreEqual(11, result.Length);

            // Проверяем несколько конкретных значений
            // x = -5: cos(-5) + 2*(-5) - 3*(-5)*sin(-5)
            double expectedMinus5 = Math.Cos(-5) + (2 * -5) - (3 * -5 * Math.Sin(-5));
            Assert.AreEqual(Math.Round(expectedMinus5, 2), result[0]);

            // x = 0: cos(0) + 2*0 - 3*0*sin(0) = 1 + 0 - 0 = 1
            Assert.AreEqual(1.00, result[5]);

            // x = 5: cos(5) + 2*5 - 3*5*sin(5)
            double expected5 = Math.Cos(5) + (2 * 5) - (3 * 5 * Math.Sin(5));
            Assert.AreEqual(Math.Round(expected5, 2), result[10]);
        }

        [TestMethod]
        public void TestGetMassFunctionRange()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(1, 3);

            // Проверяем корректность диапазона
            Assert.AreEqual(3, result.Length);

            // Проверяем вычисления для x = 1, 2, 3
            Assert.AreEqual(Math.Round(Math.Cos(1) + 2 - 3 * Math.Sin(1), 2), result[0]);
            Assert.AreEqual(Math.Round(Math.Cos(2) + 4 - 6 * Math.Sin(2), 2), result[1]);
            Assert.AreEqual(Math.Round(Math.Cos(3) + 6 - 9 * Math.Sin(3), 2), result[2]);
        }

        [TestMethod]
        public void TestGetMassFunctionSingleValue()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(0, 0);

            // Проверяем одно значение
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(1.00, result[0]); // cos(0) + 0 - 0 = 1
        }
    }
}