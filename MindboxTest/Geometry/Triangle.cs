using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Geometry
{
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        public uint A { get { return Convert.ToUInt32(_a); } }
        public uint B { get { return Convert.ToUInt32(_b); } }
        public uint C { get { return Convert.ToUInt32(_c); } }

        public Triangle(uint a, uint b, uint c)
        {
            if(GetHypotenuse(a, b, c) * 2D < ((double)a + (double)b + (double)c))
            {
                _a = (double)a;
                _b = (double)b;
                _c = (double)c;
            }
        }

        public override double Area()
        {
            //Semiperimeter
            double p = (_a + _b + _c) / 2D;

            double sqr = p * (p - _a) * (p - _b) * (p - _c);

            double area = Math.Sqrt(sqr);

            return area;
        }

        public bool IsRightAngled()
        {
            double hypotenuse = GetHypotenuse();

            if ((_a * _a + _b * _b + _c * _c) == (hypotenuse*hypotenuse*2))
            {
                return true;
            }
            else return false;
        }

        private double GetHypotenuse(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        private double GetHypotenuse()
        {
            return Math.Max(Math.Max(_a, _b), _c);
        }
    }
}
