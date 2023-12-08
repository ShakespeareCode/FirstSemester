using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индивидуальная_задача_2_РАЗДЕЛ_2._3
{
    internal class Flight
    {
        public string City { get; }
        public uint CostOfTwoDirection { get; }
        public uint CostOfOneDirection { get; }
        public Flight(string city, uint costOfOneDirection, uint costOfTwoDirection)
        {
            City = city;
            CostOfOneDirection = costOfOneDirection;
            CostOfTwoDirection = costOfTwoDirection;
        }

    }
}
