using System;

namespace CheckAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Написать программу для определения подходящего возраста для вступления в брак, используя следующее соображение: возраст девушки равен половине возраста мужчины плюс 7, возраст мужчины определяется соответственно как удвоенный возраст девушки минус 14. Данные для проверки работы программы задать самостоятельно.");

            Console.WriteLine();


            int age, ManOrWooman, AgeMan, AgeWooman;
            Console.WriteLine("введите возраст женщины либо мужчины по приеру ниже");
            Console.WriteLine("Женщина = 1");
            Console.WriteLine("мужчина = 0");
            ManOrWooman =int.Parse(Console.ReadLine());
            Console.WriteLine("Введите возраст");
            age = int.Parse(Console.ReadLine());
            if (age == 1)
            {
                AgeWooman = age /2+7;
                AgeMan = age * 2 - 14;
                Console.WriteLine($"Корректныый возрас женщины для вступления в брак = {AgeWooman} а Корректныый возрас мужчины для вступления в брак = {AgeMan}");
            }
            
            Console.ReadKey();
        }
    }
}
