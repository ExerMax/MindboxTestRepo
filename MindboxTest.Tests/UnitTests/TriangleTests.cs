using MindboxTest.Geometry;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MindboxTest.Tests.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void GetAreaWithZeroSides()
        {
            Figure figure = new Triangle(0, 0, 0);

            var res = figure.Area();

            Assert.Equal(0, res);
        }

        [Fact]
        public void GetAreaWithSomeSides()
        {
            uint a = 10;
            uint b = 14;
            uint c = 15;
            double p = (a + b + c) / 2D;
            var expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Figure figure = new Triangle(a, b, c);

            var res = figure.Area();

            Assert.Equal(expected, res);
        }

        [Fact]
        public void GetAreaWithMaxSides()
        {
            uint a = UInt32.MaxValue;
            double p = (double)a * 3 / 2;
            var expected = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            Triangle figure = new Triangle(a, a, a);

            var res = figure.Area();

            Assert.Equal(expected, res);
        }

        [Fact]
        public void IsTriangleRightAngled()
        {
            uint a = 3;
            uint b = 4;
            uint c = 5;
            Triangle figure = new Triangle(a, b, c);

            var res = figure.IsRightAngled();

            Assert.Equal(true, res);
        }

        [Fact]
        public void IsTriangleNotRightAngled()
        {
            uint a = 3;
            uint b = 4;
            uint c = 6;
            Triangle figure = new Triangle(a, b, c);

            var res = figure.IsRightAngled();

            Assert.Equal(false, res);
        }
    }
}
