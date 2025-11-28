using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhanikyanDK.Sprint6.Task4.V14.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task4.V14.Test
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
            // x = -5: f(-5) = 2*(-5) - 4 + ((2*(-5)-1)/(sin(-5)+1))
            double expectedMinus5 = (2 * -5 - 4) + ((2 * -5 - 1) / (Math.Sin(-5) + 1));
            Assert.AreEqual(Math.Round(expectedMinus5, 2), result[0]);

            // x = 0: f(0) = 2*0 - 4 + ((2*0-1)/(sin(0)+1)) = -4 + (-1/1) = -5
            Assert.AreEqual(-5.00, result[5]);

            // x = 5: f(5) = 2*5 - 4 + ((2*5-1)/(sin(5)+1))
            double expected5 = (2 * 5 - 4) + ((2 * 5 - 1) / (Math.Sin(5) + 1));
            Assert.AreEqual(Math.Round(expected5, 2), result[10]);
        }

        [TestMethod]
        public void TestGetMassFunctionDivisionByZero()
        {
            DataService ds = new DataService();

            // Проверяем, что при sin(x) + 1 = 0 возвращается 0
            // sin(x) + 1 = 0 → sin(x) = -1 → x = -π/2 + 2πk ≈ -1.57, 4.71, ...
            // В диапазоне [-5;5] есть x ≈ -1.57 (не целое) и x ≈ 4.71 (не целое)
            // Для целых x в диапазоне [-5;5] деления на ноль не должно быть

            double[] result = ds.GetMassFunction(-5, 5);

            // Проверяем, что все значения вычислены корректно
            for (int i = 0; i < result.Length; i++)
            {
                double x = -5 + i;
                double denominator = Math.Sin(x) + 1;
                if (Math.Abs(denominator) < 1e-10)
                {
                    Assert.AreEqual(0, result[i]);
                }
            }
        }

        [TestMethod]
        public void TestSaveToFile()
        {
            DataService ds = new DataService();
            double[] testValues = { 1.23, 4.56, -2.34, 7.89 };
            string testFileName = "test_output.txt";

            // Сохраняем в файл
            ds.SaveToFile(testValues, testFileName);

            // Проверяем, что файл создан
            Assert.IsTrue(File.Exists(testFileName));

            // Читаем и проверяем содержимое
            string[] lines = File.ReadAllLines(testFileName);
            Assert.IsTrue(lines.Length > 0);

            // Удаляем тестовый файл
            File.Delete(testFileName);
        }

        [TestMethod]
        public void TestGetMassFunctionRange()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(1, 3);

            // Проверяем корректность диапазона
            Assert.AreEqual(3, result.Length);

            // Проверяем вычисления для x = 1, 2, 3
            double expected1 = (2 * 1 - 4) + ((2 * 1 - 1) / (Math.Sin(1) + 1));
            Assert.AreEqual(Math.Round(expected1, 2), result[0]);

            double expected2 = (2 * 2 - 4) + ((2 * 2 - 1) / (Math.Sin(2) + 1));
            Assert.AreEqual(Math.Round(expected2, 2), result[1]);

            double expected3 = (2 * 3 - 4) + ((2 * 3 - 1) / (Math.Sin(3) + 1));
            Assert.AreEqual(Math.Round(expected3, 2), result[2]);
        }
    }
}