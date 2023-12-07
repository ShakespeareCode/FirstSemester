using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSemester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Написать программу для определения подходящего возраста для вступления в брак, используя следующее соображение: возраст девушки равен половине возраста мужчины плюс 7, возраст мужчины определяется соответственно как удвоенный возраст девушки минус 14. Данные для проверки работы программы задать самостоятельно.");

            Console.WriteLine();


            int maleAge, femaleAge;
            double correctMaleAge, correctFemaleAge;

            Console.WriteLine("Введите возраст мужчины");
            maleAge = int.Parse(Console.ReadLine());
            correctFemaleAge = maleAge / 2 + 7;
            if (correctFemaleAge < 18)
            {
                Console.WriteLine("невозможно вычислить корректный возраст");
            }
            else 
            {
                Console.WriteLine($"корректный возраст женщины для вступления в брак с данным мужчинной ={correctFemaleAge}");
            }
            Console.WriteLine("Введите возраст женщины");
            femaleAge = int.Parse(Console.ReadLine());
            correctMaleAge = femaleAge * 2 - 14;
            if (correctFemaleAge < 18)
            {
                Console.WriteLine("невозможно вычислить корректный возраст");
            }
            else
            {
                Console.WriteLine($"корректный возраст мужчины для вступления в брак с данной женщиной= {correctMaleAge}");
            }
            Console.ReadLine();
        }
    }
}
