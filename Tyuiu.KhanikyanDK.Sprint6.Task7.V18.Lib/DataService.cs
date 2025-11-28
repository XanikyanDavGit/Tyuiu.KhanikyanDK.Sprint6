using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhanikyanDK.Sprint6.Task7.V18.Lib
{
    public class DataService : ISprint6Task7V18
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            // Читаем все строки файла
            string[] lines = File.ReadAllLines(path);

            if (lines.Length == 0)
                throw new ArgumentException("Файл пуст");

            // Определяем размерность матрицы по первой строке
            string[] firstLineValues = lines[0].Split(',');
            int rows = lines.Length;
            int cols = firstLineValues.Length;

            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу данными из файла
            for (int i = 0; i < rows; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] values = line.Split(',');

                if (values.Length != cols)
                    throw new ArgumentException($"Несовпадение количества столбцов в строке {i + 1}. Ожидалось: {cols}, получено: {values.Length}");

                for (int j = 0; j < cols; j++)
                {
                    string valueStr = values[j].Trim();
                    if (int.TryParse(valueStr, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        throw new ArgumentException($"Некорректное значение '{valueStr}' в строке {i + 1}, столбце {j + 1}");
                    }
                }
            }

            // Изменяем значения в 9-м столбце (индекс 8)
            // Значения не равные 11 меняем на 11
            // Проверяем, что матрица имеет хотя бы 9 столбцов
            if (cols >= 9)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, 8] != 11)
                    {
                        matrix[i, 8] = 11;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Матрица должна содержать как минимум 9 столбцов");
            }

            return matrix;
        }
    }
}