using System;
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.Cources.Programming.Interfaces.Sprint6;

namespace Tyuiu.KhanikyanDK.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;

                // Формула: f(x) = cos(x) + 4x/2 - sin(x) * 3x
                // Упрощаем: f(x) = cos(x) + 2x - 3x * sin(x)

                double cosX = Math.Cos(x);
                double sinX = Math.Sin(x);

                double result = cosX + (2 * x) - (3 * x * sinX);
                arr[i] = Math.Round(result, 2);
            }

            return arr;
        }
    }
}