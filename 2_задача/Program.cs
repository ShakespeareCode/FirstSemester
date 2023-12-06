using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _2_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Возраст Тани – X лет, а возраст Мити – Y лет.");
            Console.WriteLine("Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.");
            Console.WriteLine("Введенные данные не могут быть <0 , т.к это возраст");
            Console.ReadLine();
            uint tanyaAge = uint.Parse(Interaction.InputBox("Напишите возраст Тани", "Возраст Тани и Мити"));
            uint mityaAge = uint.Parse(Interaction.InputBox("Напишите возраст Мити", "Возраст Тани и Мити"));
            double averageAge = (tanyaAge + mityaAge) / 2;
            
            MessageBox.Show($"Средний возраст {averageAge} у Тани разница со средним значением {averageAge - tanyaAge} у Мити {averageAge - mityaAge}", "Возраст Тани и Мити");

        }
    }
}
