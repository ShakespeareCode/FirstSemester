using System;
using System.Text;

namespace Практическая_работа__3__задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Решить задачу, используя цикл for.Даны два целых числа A и B (A < B). Найти сумму квадратов всех целых чисел от A до B включительно.");
            Console.WriteLine();
            Console.WriteLine("введите целое число А");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("введите целое число В, которое должно быть больше А");
            int B = int.Parse(Console.ReadLine());
            if (A < B)
            {

                int sumOfSqur = 0;

                for (int i = A; i <= B; i++)
                {
                    int square = i * i;
                    sumOfSqur += square;
                }

                Console.WriteLine($"Сумма квадратов от {A} до {B} равна: {sumOfSqur}");
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }

    }
}
