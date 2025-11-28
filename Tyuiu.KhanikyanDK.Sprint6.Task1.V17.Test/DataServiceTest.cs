using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhanikyanDK.Sprint6.Task1.V17.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task1.V17.Test
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

            // Проверяем обработку деления на ноль для x = 0 (sin(0) = 0)
            Assert.AreEqual(0, result[5]); // x = 0

            // Проверяем несколько значений
            // Для x = -5: f(-5) = 4*(-5) - 1.5/sin(-5) - 1
            double expectedMinus5 = 4 * (-5) - 1.5 / Math.Sin(-5) - 1;
            Assert.AreEqual(Math.Round(expectedMinus5, 2), result[0]);

            // Для x = 5: f(5) = 4*5 - 1.5/sin(5) - 1
            double expected5 = 4 * 5 - 1.5 / Math.Sin(5) - 1;
            Assert.AreEqual(Math.Round(expected5, 2), result[10]);
        }

        [TestMethod]
        public void TestGetMassFunctionWithDivisionByZero()
        {
            DataService ds = new DataService();

            // Тестируем диапазон, включающий точки где sin(x) = 0
            double[] result = ds.GetMassFunction(-1, 1);

            // x = -1: sin(-1) ≠ 0
            Assert.AreNotEqual(0, result[0]);

            // x = 0: sin(0) = 0 → результат должен быть 0
            Assert.AreEqual(0, result[1]);

            // x = 1: sin(1) ≠ 0
            Assert.AreNotEqual(0, result[2]);
        }

        [TestMethod]
        public void TestGetMassFunctionRange()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(1, 3);

            // Проверяем корректность диапазона
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(1, result[0]); // x = 1
            Assert.AreEqual(2, result[1]); // x = 2  
            Assert.AreEqual(3, result[2]); // x = 3
        }
    }
}