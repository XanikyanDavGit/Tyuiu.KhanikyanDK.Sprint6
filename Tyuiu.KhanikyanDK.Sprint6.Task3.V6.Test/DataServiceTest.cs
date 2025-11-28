using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhanikyanDK.Sprint6.Task3.V6.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestEvenReplaceInThirdRow()
        {
            int[,] matrix = new int[5, 5]
            {
                { -2, -10, -8, 11, 1 },
                { -15, -9, -4, -15, 18 },
                { -15, 12, 7, 6, 9 },
                { -14, -10, 10, 18, -5 },
                { -1, 7, -19, -19, -4 }
            };

            DataService ds = new DataService();
            int[,] result = ds.Calculate(matrix);

            // Проверяем: четные значения в третьей строке заменены на 0
            // Исходная третья строка: -15, 12, 7, 6, 9
            // После замены: -15, 0, 7, 0, 9

            Assert.AreEqual(-15, result[2, 0]); // нечетное, остается
            Assert.AreEqual(0, result[2, 1]);   // 12 - четное, заменяется на 0
            Assert.AreEqual(7, result[2, 2]);   // нечетное, остается
            Assert.AreEqual(0, result[2, 3]);   // 6 - четное, заменяется на 0
            Assert.AreEqual(9, result[2, 4]);   // нечетное, остается
        }

        [TestMethod]
        public void TestGetInitialMatrix()
        {
            DataService ds = new DataService();
            int[,] result = ds.Calculate(null);

            // Проверяем, что возвращается исходный массив
            Assert.AreEqual(5, result.GetLength(0));
            Assert.AreEqual(5, result.GetLength(1));

            // Проверяем несколько значений исходного массива
            Assert.AreEqual(-2, result[0, 0]);
            Assert.AreEqual(18, result[1, 4]);
            Assert.AreEqual(-15, result[2, 0]);
            Assert.AreEqual(-5, result[3, 4]);
            Assert.AreEqual(-4, result[4, 4]);
        }

        [TestMethod]
        public void TestOtherRowsNotChanged()
        {
            int[,] matrix = new int[5, 5]
            {
                { -2, -10, -8, 11, 1 },
                { -15, -9, -4, -15, 18 },
                { -15, 12, 7, 6, 9 },
                { -14, -10, 10, 18, -5 },
                { -1, 7, -19, -19, -4 }
            };

            DataService ds = new DataService();
            int[,] result = ds.Calculate(matrix);

            // Проверяем, что другие строки не изменились
            // Первая строка
            Assert.AreEqual(-2, result[0, 0]);
            Assert.AreEqual(-10, result[0, 1]);
            Assert.AreEqual(-8, result[0, 2]);
            Assert.AreEqual(11, result[0, 3]);
            Assert.AreEqual(1, result[0, 4]);

            // Вторая строка
            Assert.AreEqual(-15, result[1, 0]);
            Assert.AreEqual(-9, result[1, 1]);
            Assert.AreEqual(-4, result[1, 2]);
            Assert.AreEqual(-15, result[1, 3]);
            Assert.AreEqual(18, result[1, 4]);

            // Четвертая строка
            Assert.AreEqual(-14, result[3, 0]);
            Assert.AreEqual(-10, result[3, 1]);
            Assert.AreEqual(10, result[3, 2]);
            Assert.AreEqual(18, result[3, 3]);
            Assert.AreEqual(-5, result[3, 4]);

            // Пятая строка
            Assert.AreEqual(-1, result[4, 0]);
            Assert.AreEqual(7, result[4, 1]);
            Assert.AreEqual(-19, result[4, 2]);
            Assert.AreEqual(-19, result[4, 3]);
            Assert.AreEqual(-4, result[4, 4]);
        }
    }
}