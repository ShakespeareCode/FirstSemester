using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

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

            Console.WriteLine("Закажите билет на авиарейс. Киев – в одном направлении 500гр, в двух направлениях -750гр. Харьков - в одном направлении 400гр, в двух направлениях -600гр. Донецк - в одном направлении 350гр, в двух направлениях -550гр. Львов - в одном направлении 600гр, в двух направлениях - 900гр. Если билет заказывается за 45 суток – скидка 20%, за 20 суток – скидка 10%. Определить стоимость заказа. Предусмотреть обработку ошибок ввода.");
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
                Flight flight;
                switch (direction)
                {
                    case 1:
                        flight = _flights[chosenFlight];
                        Console.WriteLine($"Стоимость вашего билета={CalculateCost(flight.CostOfOneDirection)}");
                        
                        break;
                    case 2:
                        flight = _flights[chosenFlight];
                        Console.WriteLine($"Стоимость вашего билета={CalculateCost(flight.CostOfTwoDirection)}");

                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                



                //Console.WriteLine("напишите дату по примеру: 09.12.2023");
                //string date = Console.ReadLine();

                //считываю строкой
            }
            Console.ReadKey();

        }

        private static double CalculateCost(uint cost)
        {
            Console.WriteLine("напишите год вылета");
            uint yearDeparture = uint.Parse(Console.ReadLine());
            Console.WriteLine("напишите месяц вылета");
            uint monthDeparture = uint.Parse(Console.ReadLine());
            Console.WriteLine("напишите день вылета");
            uint dayDeparture = uint.Parse(Console.ReadLine());
            DateTime departureDate = new DateTime((int)yearDeparture, (int)monthDeparture, (int)dayDeparture);

            TimeSpan interval = departureDate - DateTime.Now;
            if (interval.Days >= 45)
            {
                Console.WriteLine("скидака = 20%");
                return cost / 100 * 80;
            }
            else if (interval.Days >= 20 && interval.Days < 45)
            {
                Console.WriteLine("скидака = 10%");
                return cost / 100 * 90;
            }
            else
            {
                Console.WriteLine("Скидки нет");
                return cost;
            }
        }
    }
}
