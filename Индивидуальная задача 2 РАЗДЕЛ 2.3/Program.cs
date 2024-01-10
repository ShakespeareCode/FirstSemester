using System;
using System.Collections.Generic;
using System.Globalization;

namespace Индивидуальная_задача_2_РАЗДЕЛ_2._3
{
    internal class Program
    {
        private static readonly Dictionary<uint, Flight> _flights = new Dictionary<uint, Flight>
        {
            { 1, new Flight("Киев", 500, 750) },
            { 2, new Flight("Харьков", 400, 600) },
            { 3, new Flight("Донецк", 350, 550) },
            { 4, new Flight("Львов", 600, 900) },

        };
        static void Main(string[] args)
        {
            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
            Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
            Console.WriteLine("────█░░█░░░░░█░░█────");
            Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
            Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Console.WriteLine("█░░║║║╠─║─║─║║║║║╠─░░█");
            Console.WriteLine("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.WriteLine("Закажите билет на авиарейс. Киев – в одном направлении 500гр, в двух направлениях -750гр. Харьков - в одном направлении 400гр, в двух направлениях -600гр. Донецк - в одном направлении 350гр, в двух направлениях -550гр. Львов - в одном направлении 600гр, в двух направлениях - 900гр. Если билет заказывается за 45 суток – скидка 20%, за 20 суток – скидка 10%. Определить стоимость заказа. Предусмотреть обработку ошибок ввода.");

            do
            {
                Console.WriteLine("Выберите город в который вы хотите лететь");
                foreach (KeyValuePair<uint, Flight> item in _flights)
                {
                    Console.WriteLine($"{item.Key}) {item.Value.City}");
                }
                uint chosenFlight = uint.Parse(Console.ReadLine());
                if (chosenFlight > 0 && chosenFlight < 5)
                {
                    Console.WriteLine("в каком наравление вы летите?");
                    Console.WriteLine("в 1 направлении или в 2");
                    uint direction = uint.Parse(Console.ReadLine());
                    switch (direction)
                    {
                        case uint condition when condition == 1 || condition == 2:
                            Flight flight = _flights[chosenFlight];
                            double? cost = CalculateCost(condition == 1 ? flight.CostOfOneDirection : flight.CostOfTwoDirection);
                            if (cost == null)
                            {
                                Console.WriteLine($"Введена некорректная дата.");
                            }
                            else
                            {
                                Console.WriteLine($"Стоимость вашего билета={cost}");
                            }
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("Завержить рабoту программы?(y/n)");
            }
            while (Console.ReadLine() != "y");
            Console.ReadKey();
        }
        private static double? CalculateCost(uint cost)
        {
            DateTime? departureDate = ParseDateTime();
            if (departureDate != null && !(departureDate < DateTime.Now))
            {
                TimeSpan interval = (DateTime)departureDate - DateTime.Now;
                switch (interval.Days)
                {
                    case int days when days >= 45:
                        Console.WriteLine("скидака = 20%");
                        return cost / 100 * 80;
                    case int days when days >= 20 && days < 45:
                        Console.WriteLine("скидака = 10%");
                        return cost / 100 * 90;
                    default:
                        Console.WriteLine("Скидки нет");
                        return cost;
                }
            }
            return null;
        }

        internal static DateTime CreateDateTime()
        {
            Console.WriteLine("напишите год вылета");
            uint yearDeparture = uint.Parse(Console.ReadLine());
            Console.WriteLine("напишите месяц вылета");
            uint monthDeparture = uint.Parse(Console.ReadLine());
            Console.WriteLine("напишите день вылета");
            uint dayDeparture = uint.Parse(Console.ReadLine());
            return new DateTime((int)yearDeparture, (int)monthDeparture, (int)dayDeparture);
        }
        
        internal static DateTime? ParseDateTime()
        {
            Console.WriteLine("Введите дату одной строкой в формате(dd.MM.yyyy)");
            if (DateTime.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {  
                return result; 
            }
            else
            {
                return null;
            }
        }

    }
}
