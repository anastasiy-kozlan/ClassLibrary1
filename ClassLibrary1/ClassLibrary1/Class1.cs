using System;

namespace ClassLibrary1
{
    public class Class1
    {
        /// <summary>
        /// TASK 1 Area of an isosceles trapezoid (площа рівнобедреної трапеції)
        /// </summary>
        /// <param name="a"> smaller base of an equilateral trapezoid (менша основа рівнобічної трапеції)</param> 
        /// <param name="b"> larger base of an equilateral trapezoid  (більша основа рівнобічної трапеції)</param>
        /// <param name="c"> angle at a larger base (кут при більшій основі)</param>
        /// <returns> Returns the area value for the specified data (Повертає значення площі для заданих даних)</returns>
        public static double P(int a, int b, int c)
        {
            double d = 0;
            d = (Math.Pow(b, 2) - Math.Pow(a, 2)) * Math.Tan(c) / 4;
            return Math.Round(d, 4);
        }
        /// <summary>
        /// TASK 2 Finding the sum of n members of a series (знаходження суми n членів ряду)
        /// </summary>
        /// <param name="n">number of members of the series (кількість членів ряду)</param>
        /// <returns>Returns the amount for the specified amount (Повертає значення суми для заданої кількості)</returns>
        public static double S(int n)
        {
            double sum = 0;
            double m = 0;
            for(int i=1; i<=n; i++)
            {
                m = m + Math.Sin(i);
                sum = sum + 1 / m;
            }
            return Math.Round(sum, 4);
        }
        /// <summary>
        /// TASK 3 Finding the sum of m members of a series (знаходження суми m членів ряду)
        /// </summary>
        /// <param name="e">number of decimal places (кількість знаків після коми)</param>
        /// <param name="m">number of members of the series (кількість членів ряду)</param>
        /// <param name="x">function argument (аргумент функції )</param>
        /// <returns>Returns the amount for the specified amount (Повертає значення суми для заданої кількості)</returns>
        public static double ryad(int e, double m, double x)
        {
            double result = 0;
            for (int i = 1; i <= m; i++)
            {
                result += ((1 / (2 * m - 1)) * Math.Pow(((x - 1) / (x + 1)), (2 * m - 1)));
            }
            return Math.Round(result,e);
        }
        /// <summary>
        /// TASK 3 Finding the exact value of the function (Знаходження точного значення функції)
        /// </summary>
        /// <param name="e">number of decimal places (кількість знаків після коми)</param>
        /// <param name="x">function argument (аргумент функції )</param>
        /// <returns>Returns the value of the function for the specified argument value (Повертає значення функції для заданого значення аргументу )</returns>
        public static double func(int e, double x)
        {
            double result = ((Math.Log(x))*0.5);
            return Math.Round(result,e);
        }
        /// <summary>
        /// TASK 3 Calculate the calculation error (порахувати помилку обчислень)
        /// </summary>
        /// <param name="e">number of decimal places (кількість знаків після коми)</param>
        /// <param name="ryad">the amount of the series (сума ряду)</param>
        /// <param name="func">the exact value of the function (точне значення функції)</param>
        /// <returns>Returns a computational error for the specified data (Повертає  помилку обчислень для заданих даних)</returns>
        public static double end(int e, double ryad, double func)
        {
            return Math.Round((Math.Abs(ryad - func) / func) * 100,e);
        }

    }
}
