using System;
using static System.Console;

namespace Индивидуальное_задание__1_вариант_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Задание: записать арифметическое выражение на алгоритмическом языке и указать порядок выполнения операций. K = (2t ^ 2 + 3l + 7,2)/(ln(y) + e ^ (2*l))");
            WriteLine();

            double t, l;

            WriteLine("Введите значение t");
            t = double.Parse(ReadLine());
            WriteLine("Введите значение l");
            l = double.Parse(ReadLine());
            WriteLine("Введите значение y: ВНИМАНИЕ!!! перемнная y не равна нулю и может быть только положительные числом");
            ulong y = ulong.Parse(ReadLine());

            double A = Math.Pow(t, 2);
            double b = 2*A;
            double c = 3*l;
            double d = b+c;
            double E = d + 7.2;
            double f = Math.Log(y);
            double g = l*2;
            double j = Math.Pow(Math.E,g);
            double H =f+j;
            double K = E/H;
            
            WriteLine($"1.возведение переменной t в квадрат={A}");
            WriteLine($"2.Умножается результат из шага 1 на 2={b}");
            WriteLine($"3.Вычисляется значение 3 * l={c}");
            WriteLine($"4.Вычисление суммы из шагов 2 и 3={d}");
            WriteLine($"5.прибавить к 4 шагу 7,2={E}");
            WriteLine($"6.Вычисляется значение ln(y)={f}");
            WriteLine($"7.Вычисление значения l * 2={g}");
            WriteLine($"8.возведение экспоненты в степень(l*2)={j}");
            WriteLine($"9.Сложение результатов шагов 6 и 8={H}");
            WriteLine($"10.Деление результата шага 5 на результат шага 9={K}");
            WriteLine();

            WriteLine($"Значение K: {K}");
            ReadLine();
        }
    }
}
