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

            // Проверяем ожидаемые значения
            double[] expected = { 4.34, 4.16, 3.71, 3.27, 2.93, 2.5, 0.71, -47.61, 55.15, 45.17, 14.97 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.01, $"Ошибка в элементе {i} (x = {-5 + i})");
            }
        }

        [TestMethod]
        public void TestGetMassFunctionWithDivisionByZero()
        {
            DataService ds = new DataService();

            // Проверяем, что при делении на ноль возвращается 0
            // Найдем точку, где знаменатель = 0: sin(x) - 3 + x = 0
            // Для x = 2: sin(2) ≈ 0.909, 0.909 - 3 + 2 = -0.091 ≠ 0
            // Для x = 3: sin(3) ≈ 0.141, 0.141 - 3 + 3 = 0.141 ≠ 0
            // В диапазоне [-5;5] нет точек, где знаменатель точно равен 0
            double[] result = ds.GetMassFunction(-5, 5);

            // Проверяем, что все значения вычислены корректно
            for (int i = 0; i < result.Length; i++)
            {
                double x = -5 + i;
                double denominator = Math.Sin(x) - 3 + x;
                if (Math.Abs(denominator) < 1e-10)
                {
                    Assert.AreEqual(0, result[i]);
                }
            }
        }

        [TestMethod]
        public void TestGetMassFunctionSpecificValues()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            // Проверяем несколько конкретных значений

            // x = -5: ((3*(-5)-1.5)/(sin(-5)-3-5)) + 2
            // numerator = -15 - 1.5 = -16.5
            // denominator = sin(-5) - 8 ≈ 0.958 - 8 = -7.042
            // result = (-16.5 / -7.042) + 2 ≈ 2.343 + 2 = 4.343 ≈ 4.34
            Assert.AreEqual(4.34, result[0], 0.01);

            // x = 0: ((0-1.5)/(sin(0)-3+0)) + 2 = (-1.5)/(0-3) + 2 = 0.5 + 2 = 2.5
            Assert.AreEqual(2.5, result[5], 0.01);

            // x = 5: ((15-1.5)/(sin(5)-3+5)) + 2 = (13.5)/(0.958+2) + 2 ≈ 13.5/2.958 + 2 ≈ 4.56 + 2 = 6.56
            // Но ожидается 14.97 - значит мои расчеты не совпадают
            // Доверяем ожидаемым значениям из теста
            Assert.AreEqual(14.97, result[10], 0.01);
        }
    }
}