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
        public double A { get { return (uint)A; } set { } }
        public double B { get { return (uint)B; } set { } }
        public double C { get { return (uint)C; } set { } }

        public Triangle(uint a, uint b, uint c)
        {
            if(GetHypotenuse(a, b, c) * 2D < ((double)a + (double)b + (double)c))
            {
                A = (double)a;
                B = (double)b;
                C = (double)c;
            }
        }

        public override double Area()
        {
            //Semiperimeter
            double p = (A + B + C) / 2D;

            double sqr = p * (p - A) * (p - B) * (p - C);

            double area = Math.Sqrt(sqr);

            return area;
        }

        public bool IsRightAngled()
        {
            double hypotenuse = GetHypotenuse(A, B, C);

            if ((A*A + B*B + C*C) == (hypotenuse*hypotenuse*2))
            {
                return true;
            }
            else return false;
        }

        private double GetHypotenuse(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
