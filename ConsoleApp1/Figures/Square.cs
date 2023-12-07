using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figures
{
    internal class Square : IFigure
    {
        private double _length;
        private static double _length1;
        public Square(double length)
        {
            _length = length;
        }
        public double GetArea() => _length * 4;
        public static double Test() => _length1 * 4;
    }
}
