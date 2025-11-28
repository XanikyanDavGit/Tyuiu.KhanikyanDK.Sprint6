using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhanikyanDK.Sprint6.Task3.V6.Lib
{
    public class DataService : ISprint6Task3V6
    {
        // Исходный массив
        private int[,] initialMatrix = new int[,]
        {
            { -2, -10, -8, 11, 1 },
            { -15, -9, -4, -15, 18 },
            { -15, 12, 7, 6, 9 },
            { -14, -10, 10, 18, -5 },
            { -1, 7, -19, -19, -4 }
        };

        public int[,] Calculate(int[,] matrix)
        {
            // Если matrix пустой, возвращаем исходный массив
            if (matrix == null)
                return (int[,])initialMatrix.Clone();

            // Иначе заменяем четные значения в третьей строке (индекс 2)
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[2, j] % 2 == 0)
                    matrix[2, j] = 0;
            }
            return matrix;
        }
    }
}