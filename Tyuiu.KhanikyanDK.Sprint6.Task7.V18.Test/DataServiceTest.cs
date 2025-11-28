using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhanikyanDK.Sprint6.Task7.V18.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMatrixWithSemicolonSeparator()
        {
            DataService ds = new DataService();

            // Создаем временный CSV файл с разделителем точка с запятой
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "1;2;3;4;5;6;7;8;9;10\n11;12;13;14;15;16;17;18;19;20\n21;22;23;24;25;26;27;28;11;30");

            int[,] result = ds.GetMatrix(path);

            // Проверяем, что в 9-м столбце (индекс 8) все значения, не равные 11, изменены на 11
            Assert.AreEqual(11, result[0, 8]); // Было 9, должно стать 11
            Assert.AreEqual(11, result[1, 8]); // Было 19, должно стать 11
            Assert.AreEqual(11, result[2, 8]); // Было 11, остается 11

            // Проверяем, что другие столбцы не изменились
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(20, result[1, 9]);
            Assert.AreEqual(21, result[2, 0]);

            File.Delete(path);
        }

        [TestMethod]
        public void TestGetMatrixWithCommaSeparator()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "1,2,3,4,5,6,7,8,9,10\n11,12,13,14,15,16,17,18,19,20");

            int[,] result = ds.GetMatrix(path);

            // Проверяем изменения в 9-м столбце
            Assert.AreEqual(11, result[0, 8]); // Было 9
            Assert.AreEqual(11, result[1, 8]); // Было 19

            File.Delete(path);
        }

        [TestMethod]
        public void TestGetMatrixWithNegativeNumbers()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "-12;-18;16;2;-20;12;-15;-3;0;-19\n5;10;-5;15;-10;20;-15;25;30;35");

            int[,] result = ds.GetMatrix(path);

            // Проверяем размерность
            Assert.AreEqual(2, result.GetLength(0));
            Assert.AreEqual(10, result.GetLength(1));

            // Проверяем изменения в 9-м столбце
            Assert.AreEqual(11, result[0, 8]); // Было 0
            Assert.AreEqual(11, result[1, 8]); // Было 30

            // Проверяем, что отрицательные числа корректно обработаны
            Assert.AreEqual(-12, result[0, 0]);
            Assert.AreEqual(-18, result[0, 1]);
            Assert.AreEqual(5, result[1, 0]);

            File.Delete(path);
        }

        [TestMethod]
        public void TestGetMatrixAllColumnsExist()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "5;10;15;20;25;30;35;40;45;50\n1;2;3;4;5;6;7;8;9;10");

            int[,] result = ds.GetMatrix(path);

            // Проверяем размерность
            Assert.AreEqual(2, result.GetLength(0)); // строки
            Assert.AreEqual(10, result.GetLength(1)); // столбцы

            // Проверяем изменения в 9-м столбце
            Assert.AreEqual(11, result[0, 8]); // Было 45
            Assert.AreEqual(11, result[1, 8]); // Было 9

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestGetMatrixFileNotFound()
        {
            DataService ds = new DataService();
            string path = @"C:\NonExistentDirectory\NonExistentFile.csv";
            ds.GetMatrix(path);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetMatrixEmptyFile()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "");
            ds.GetMatrix(path);
            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetMatrixInvalidData()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "1;2;abc;4;5;6;7;8;9;10");
            ds.GetMatrix(path);
            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetMatrixNotEnoughColumns()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "1;2;3;4;5;6;7;8"); // Только 8 столбцов
            ds.GetMatrix(path);
            File.Delete(path);
        }
    }
}