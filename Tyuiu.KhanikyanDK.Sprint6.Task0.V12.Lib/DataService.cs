using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhanikyanDK.Sprint6.Task0.V12.Lib
{
    public class DataService : ISprint6Task0V12
    {
        public double Calculate(int x)
        {
            // Формула: y(x) = (x² + 1) / √(4x² - 3)
            double numerator = Math.Pow(x, 2) + 1;
            double denominator = Math.Sqrt(4 * Math.Pow(x, 2) - 3);

            // Проверка на корректность знаменателя
            if (denominator <= 0 || double.IsNaN(denominator))
                throw new ArgumentException("Некорректное значение x для данной формулы");

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}