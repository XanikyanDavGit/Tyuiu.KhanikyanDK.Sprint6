using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhanikyanDK.Sprint6.Task5.V14.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFileWithNumbersGreaterOrEqual10()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "5 15.5 9.9 10 25.75 3.14 100 8.5 10.1");

            double[] result = ds.LoadFromDataFile(path);

            // Ожидаемые числа ≥10: 15.5, 10, 25.75, 100, 10.1
            double[] expected = { 15.5, 10, 25.75, 100, 10.1 };

            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.001);
            }

            File.Delete(path);
        }

        [TestMethod]
        public void TestLoadFromDataFileNoNumbersGreaterOrEqual10()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "1 2 3 4 5 6 7 8 9 9.9");

            double[] result = ds.LoadFromDataFile(path);

            // Ожидаем пустой массив
            Assert.AreEqual(0, result.Length);

            File.Delete(path);
        }

        [TestMethod]
        public void TestLoadFromDataFileWithDifferentFormats()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "10,5 15.25 20 9,99 25.5 30,75");

            double[] result = ds.LoadFromDataFile(path);

            // Ожидаемые числа ≥10: 10.5, 15.25, 20, 25.5, 30.75
            double[] expected = { 10.5, 15.25, 20, 25.5, 30.75 };

            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.001);
            }

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestLoadFromDataFileNotFound()
        {
            DataService ds = new DataService();
            string path = @"C:\NonExistentDirectory\NonExistentFile.txt";
            ds.LoadFromDataFile(path);
        }

        [TestMethod]
        public void TestLoadFromDataFileWithNegativeAndZero()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "-5 0 10 15 -10 20 0.5 25");

            double[] result = ds.LoadFromDataFile(path);

            // Ожидаемые числа ≥10: 10, 15, 20, 25
            double[] expected = { 10, 15, 20, 25 };

            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.001);
            }

            File.Delete(path);
        }
    }
}