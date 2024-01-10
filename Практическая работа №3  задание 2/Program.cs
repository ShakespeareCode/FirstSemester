using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__3__задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.Решить задачу, используя цикл while.Спортсмен-лыжник начал тренировки, пробежав в первый день 10 км. Каждый следующий день он увеличивал длину пробега на P процентов от пробега предыдущего дня (P — вещественное, 0 < P < 50). По данному P определить, после какого дня суммарный пробег лыжника за все дни превысит 200 км, и вывести найденное количество дней K (целое) и суммарный пробег S (вещественное число).");
            Console.WriteLine();
            Console.WriteLine("Введите p, p - должно быть вещественным числом и 0 < P < 50 ");

            bool isFinished = false;
            double distance = 10;
            uint dayCount = 1;
            double currentDistance = 10;

            double p = double.Parse(Console.ReadLine().Replace(",", "."), NumberStyles.Float, NumberFormatInfo.InvariantInfo);
            if (0 < p && p < 50)
            {
                while (!isFinished)
                {
                    currentDistance += p * currentDistance / 100; //Эта строка обновляет значение currentDistance увеличивая его на p процентов от расстояния предыдущего дня.
                    distance += currentDistance; 
                    dayCount++;
                    if (distance >= 200)
                    {
                        isFinished = true;
                    }
                }
                Console.WriteLine($"Дистанция={distance} количесво дней={dayCount}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}
