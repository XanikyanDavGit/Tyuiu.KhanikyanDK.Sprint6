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

                // Формула: f(x) = ((3x - 1.5) / (sin(x) - 3 + x)) + 2
                // Проверка знаменателя: sin(x) - 3 + x
                double denominator = Math.Sin(x) - 3 + x;

                if (Math.Abs(denominator) < 1e-10) // Защита от деления на ноль
                {
                    arr[i] = 0;
                }
                else
                {
                    double numerator = 3 * x - 1.5;
                    double result = (numerator / denominator) + 2;
                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}