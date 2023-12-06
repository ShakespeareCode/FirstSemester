using System;

namespace Индивидуальное_задание__1_вариант_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание: записать арифметическое выражение на алгоритмическом языке и указать порядок выполнения операций. K = (2t ^ 2 + 3l + 7,2)/(ln(y) + e ^ (2*l))");
            Console.WriteLine();

            double t, l, y;

            Console.WriteLine("Введите значение t");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение l");
            l = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y: ВНИМАНИЕ!!! В перемной y могут быть только положительные значения");
            y = byte.Parse(Console.ReadLine());

            double a = Math.Pow(2 * t, 2);
            double b = a + 3 * l + 7.2;
            double c = Math.Log(y) + Math.Pow(Math.E, 2 * l);
            double K = b / c;

            Console.WriteLine($"Значение K: { K}");
            Console.ReadLine();
        }
    }
}
