using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhanikyanDK.Sprint6.Task1.V17.Lib
{
    public class DataService : ISprint6Task1V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;

                // Проверка деления на ноль: sin(x) не должен быть равен 0
                double sinX = Math.Sin(x);

                if (Math.Abs(sinX) < 1e-10) // Защита от деления на ноль
                {
                    arr[i] = 0;
                }
                else
                {
                    // Вычисление по формуле: f(x) = (3x - 1.5/sin(x) - 3 + x) + 2
                    // Упрощаем: f(x) = 3x + x - 1.5/sin(x) - 3 + 2 = 4x - 1.5/sin(x) - 1
                    double term1 = 4 * x;
                    double term2 = 1.5 / sinX;
                    double result = term1 - term2 - 1;

                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}