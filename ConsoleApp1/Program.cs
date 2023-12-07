using ConsoleApp1.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "-_-";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2.Пользователь вводит вид геометрической фигуры (1-параллелограм, 2-квадрат, 3-трапеция, 4-прямоугольник) и значение сторон геометрической фигуры. Найти периметр выбранной геометрической фигуры.");
            Console.WriteLine();
            Console.WriteLine("Выберите номер фигуры из перечисленных выше");
            uint s = uint.Parse(Console.ReadLine());
            IFigure figure;
            switch (s)
            {
                case 1:
                    Console.WriteLine("введите сторну квадрата");
                    double sideLength = double.Parse(Console.ReadLine());
                    figure = new Square(sideLength);
                    Console.WriteLine($"периметр квадрата={figure.GetArea()}");
                    break;
                case 2:
                    Console.WriteLine("введите длинну прямоугольника");
                    double rectangleLength = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите ширину прямоугольника");
                    double rectangleidth = double.Parse(Console.ReadLine());
                    figure = new Rectangle(rectangleidth, rectangleLength);
                    Console.WriteLine($"периметр прямоугольника={figure.GetArea()}");
                    break;
                case 3:
                    Console.WriteLine("введите длинну параллерограмма");
                    double lengthOfTheParallelogram = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите ширину параллерограмма");
                    double heightParallelogram = double.Parse(Console.ReadLine());
                    figure = new Parallelogram(lengthOfTheParallelogram , heightParallelogram);
                    Console.WriteLine($"периметр параллерограмма={figure.GetArea()}");
                    break;
                case 4:
                    Console.WriteLine("введите основание трапеции 1");
                    double lenght1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите основание трапеции 2");
                    double lenght2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите основание трапеции 3");
                    double lenght3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите основание трапеции 4");
                    double lenght4 = double.Parse(Console.ReadLine());
                    figure = new Trapeze(lenght1,lenght2,lenght3,lenght4);
                    Console.WriteLine($"периметр трапеции={figure.GetArea()}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.ReadKey();
        }
    }
}
