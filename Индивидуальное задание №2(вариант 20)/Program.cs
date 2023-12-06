using System;

namespace Индивидуальное_задание__2_вариант_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислить Z=(R1 + R2 + R3)/3, где R1, R2, R3 – радиусы шаров с объе-мами V1, V2, V3 соответственно.Радиус шара вычислять по соответст вующей формуле.Значения объемов ввести с экрана.");

            byte v1, v2, v3;
            double R1, R2, R3, z;

            Console.WriteLine("Введите объем шара № 1 Внимание! v не может быть отрицательным числом");
            v1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите объем шара № 2 Внимание! v не может быть отрицательным числом");
            v2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите объем шара № 3 Внимание! v не может быть отрицательным числом");
            v3 = Convert.ToByte(Console.ReadLine());

            R1 = Math.Sqrt(Math.Pow(3 * v1 / (4 * Math.PI), 3.0));
            R2 = Math.Sqrt(Math.Pow(3 * v2 / (4 * Math.PI), 3.0));
            R3 = Math.Sqrt(Math.Pow(3 * v3 / (4 * Math.PI), 3.0));

            Console.WriteLine("Радиус № 1: " + R1);
            Console.WriteLine("Радиус № 2: " + R2);
            Console.WriteLine("Радиус № 3: " + R3);

            z = (R1 + R2 + R3) / 3;
            Console.WriteLine($"z =  { z}");

            Console.ReadLine();
        }
    }
}
