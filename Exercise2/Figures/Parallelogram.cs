using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figures
{
    internal class Parallelogram : IFigure
    {
        private readonly double _lengthFirstSide;
        private readonly double _lengthSecondSide;
        public Parallelogram(double lengthFirstSide, double lengthSecondSide)
        {
            _lengthFirstSide = lengthFirstSide;
            _lengthSecondSide = lengthSecondSide;
        }
        public double GetArea() => 2*(_lengthFirstSide + _lengthSecondSide);
    }
}   
