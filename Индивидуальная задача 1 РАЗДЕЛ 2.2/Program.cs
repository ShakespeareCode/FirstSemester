using System;
using static System.Console;

namespace Индивидуальная_задача_1_РАЗДЕЛ_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Написать программу, которая при вводе числа в диапазоне от 1 до 20 nдобавляет к нему слово гривна в правильной форме. Например, 1гривна,2 гривны,5 гривен.");
            WriteLine("");
            WriteLine("введите число от 1 до 20");
            uint inputValue = uint.Parse(ReadLine());
            switch (inputValue)
            {
                case 1:
                    WriteLine($"{inputValue} гривна");
                    break;
                case uint temp when temp < 5 && temp > 1:
                    WriteLine($"{inputValue} гривны");
                    break;
                case uint temp when temp >= 5 && temp <= 20:
                    WriteLine($"{inputValue} гривен");
                    break;
                default:
                    WriteLine("введенны некорректные данные");
                    break;
            }
            ReadKey();
        }
    }
}
