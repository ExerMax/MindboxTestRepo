using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Geometry
{
    internal class Triangle : Figure
    {
        private uint A { get; }
        private uint B { get; }
        private uint C { get; }

        public Triangle(uint a, uint b, uint c)
        {
            if(GetHypotenuse(a, b, c) * 2 < (a + b + c))
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public override double Area()
        {
            //Semiperimeter
            double p = (A + B + C) / 2;

            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }

        public bool IsRightAngled()
        {
            uint hypotenuse = GetHypotenuse(A, B, C);

            if ((A*A + B*B + C*C) == (hypotenuse*hypotenuse*2))
            {
                return true;
            }
            else return false;
        }

        private uint GetHypotenuse(uint a, uint b, uint c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
