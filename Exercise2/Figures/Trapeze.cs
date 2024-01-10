using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figures
{
    internal class Trapeze : IFigure
    {
        private double _lenght1;
        private double _lenght2;
        private double _lenght3;
        private double _lenght4;
        public Trapeze (double lenght1, double lenght2, double lenght3, double lenght4)
        {
            _lenght1 = lenght1;
            _lenght2 = lenght2;
            _lenght3 = lenght3;
            _lenght4 = lenght4;
        }
        public double GetArea() => _lenght1 + _lenght2 + _lenght3 + _lenght4;
    }
}
