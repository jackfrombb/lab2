namespace BisectionMethod
{
    using System;

    class Program
    {
        /// <summary>
        /// Функция
        /// </summary>
        static double f(double x)
        {
            return Math.Pow(x, 2) - 2;
        }

        /// <summary>
        /// Нахождение корней уравнения методом половинного деления
        /// </summary>
        /// <seealso href="http://www.machinelearning.ru/wiki/index.php?title=%D0%9C%D0%B5%D1%82%D0%BE%D0%B4%D1%8B_%D0%B4%D0%B8%D1%85%D0%BE%D1%82%D0%BE%D0%BC%D0%B8%D0%B8">
        /// Источник
        /// </seealso>
        static double BisectionMethod(double a, double b, double eps, ref int iterator)
        {
            double result;

            while(Math.Abs(b-a) > eps)
            {

                result = (a + b) / 2;

                if (f(b) * f(result) < 0)
                    a = result;
                else
                    b = result;

                iterator++;
            }

            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //Для отсчёта с единицы
            iterator++;

            result = (a + b) / 2;

            return result;
        }

        static void Main()
        {
            //Вводные
            double a = 0.0, b = 2.0, eps = 0.0001;

            //Счётчик итераций
            int i = 0;

            //Вычисление
            var y = BisectionMethod(a, b, eps, ref i);

            Console.WriteLine("Корень уравнения равен {0}", y);
            Console.WriteLine("Количество итераций равно {0}", i);
        }
    }
}
