using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Geometry
{
    public class Circle : Figure
    {
        private uint Radius { get; }
        private const double P = 3.14d;

        public Circle(uint radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double area = Radius * Radius * P;

            return area;
        }
    }
}
