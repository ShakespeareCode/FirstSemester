using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__3__задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.Решить задачу, используя цикл do…while.Даны положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). Не используя операции умножения и деления, найти длину незанятой части отрезка A.");
            Console.WriteLine();

            Console.WriteLine("Введите число а, а>b ");
            uint a = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b, а>b ");
            uint b = uint.Parse(Console.ReadLine());
            
            if (a <= b) 
            {
                Console.WriteLine("error");
            }
            else
            {

                uint result = a;
                do
                {
                     result -= b;
                }
                while (result >= b);
                Console.WriteLine($"{result}");
            }
            Console.ReadKey();
        }
    }
}
