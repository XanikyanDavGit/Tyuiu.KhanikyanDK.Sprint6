using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhanikyanDK.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] values = new double[size];

            for (int i = 0; i < size; i++)
            {
                double x = startValue + i;
                double fx;

                try
                {
                    // Формула: f(x) = 2x - 4 + ((2x - 1) / (sin(x) + 1))
                    double denominator = Math.Sin(x) + 1;

                    // Проверка деления на ноль
                    if (Math.Abs(denominator) < 1e-10)
                    {
                        fx = 0;
                    }
                    else
                    {
                        double numerator = 2 * x - 1;
                        fx = (2 * x - 4) + (numerator / denominator);
                    }
                }
                catch
                {
                    fx = 0;
                }

                values[i] = Math.Round(fx, 2);
            }

            return values;
        }

        public void SaveToFile(double[] values, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("Таблица значений функции:");
                sw.WriteLine("f(x) = 2x - 4 + ((2x - 1) / (sin(x) + 1))");
                sw.WriteLine("Диапазон: [-5; 5], шаг: 1");
                sw.WriteLine();

                for (int i = 0; i < values.Length; i++)
                {
                    int x = -5 + i;
                    sw.WriteLine($"x = {x,3}, f(x) = {values[i]:F2}");
                }
            }
        }
    }
}