using System;
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

            // Определяем размерность матрицы
            int rows = lines.Length;
            int cols = lines[0].Split(',').Length;

            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу данными из файла
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');

                if (values.Length != cols)
                    throw new ArgumentException($"Несовпадение количества столбцов в строке {i + 1}");

                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        throw new ArgumentException($"Некорректное значение в строке {i + 1}, столбце {j + 1}");
                    }
                }
            }

            // Изменяем значения в 9-м столбце (индекс 8)
            // Значения не равные 11 меняем на 11
            for (int i = 0; i < rows; i++)
            {
                if (cols >= 9) // Проверяем, что столбец существует
                {
                    if (matrix[i, 8] != 11)
                    {
                        matrix[i, 8] = 11;
                    }
                }
            }

            return matrix;
        }
    }
}