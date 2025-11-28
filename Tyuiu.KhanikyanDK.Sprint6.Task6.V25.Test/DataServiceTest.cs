using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhanikyanDK.Sprint6.Task6.V25.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFileWithEWords()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "Hello World ELEPHANT tree EAGLE computer");

            string result = ds.CollectTextFromFile(path);

            // Ожидаемый результат: слова с буквой 'E'
            string expected = "Hello ELEPHANT EAGLE";

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestCollectTextFromFileNoEWords()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "cat dog bird fish animal");

            string result = ds.CollectTextFromFile(path);

            // Ожидаем пустую строку
            string expected = "";

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestCollectTextFromFileWithPunctuation()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "Hello, World! ELEPHANT? tree; EAGLE: computer.");

            string result = ds.CollectTextFromFile(path);

            // Ожидаемый результат: слова с буквой 'E' (без знаков препинания)
            string expected = "Hello ELEPHANT EAGLE";

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestCollectTextFromFileCaseSensitive()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "ELEPHANT eagle EAGLE Elephant eLePhAnT");

            string result = ds.CollectTextFromFile(path);

            // Ожидаемый результат: только слова с заглавной 'E'
            string expected = "ELEPHANT EAGLE";

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestCollectTextFromFileEmpty()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "");

            string result = ds.CollectTextFromFile(path);

            // Ожидаем пустую строку
            string expected = "";

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestCollectTextFromFileNotFound()
        {
            DataService ds = new DataService();
            string path = @"C:\NonExistentDirectory\NonExistentFile.txt";

            string result = ds.CollectTextFromFile(path);

            // Ожидаем пустую строку
            string expected = "";

            Assert.AreEqual(expected, result);
        }
    }
}