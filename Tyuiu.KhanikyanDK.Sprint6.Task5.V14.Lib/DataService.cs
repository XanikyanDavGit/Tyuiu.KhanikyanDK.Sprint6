using System;
using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhanikyanDK.Sprint6.Task5.V14.Lib
{
    public class DataService : ISprint6Task5V14
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path);

            // Разбиваем текст на числа
            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> filteredNumbers = new List<double>();

            foreach (string part in parts)
            {
                if (double.TryParse(part.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double num))
                {
                    // Добавляем только числа ≥10
                    if (num >= 10)
                        filteredNumbers.Add(Math.Round(num, 3));
                }
            }

            return filteredNumbers.ToArray();
        }
    }
}