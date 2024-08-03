using MindboxTest.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MindboxTest.Tests.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void GetAreaWithZeroRadius()
        {
            Figure figure = new Circle(0);

            var res = figure.Area();

            Assert.Equal(0, res);
        }

        [Fact]
        public void GetAreaWithMaxRadius()
        {
            Figure figure = new Circle(UInt32.MaxValue);
            double area = (double)UInt32.MaxValue * UInt32.MaxValue * 3.14D;

            var res = figure.Area();

            Assert.Equal(area, res);
        }

        [Fact]
        public void GetAreaWithSomeRadius()
        {
            uint someRadius = 1000;
            Figure figure = new Circle(someRadius);
            double area = someRadius * someRadius * 3.14D;

            var res = figure.Area();

            Assert.Equal(area, res);
        }
    }
}
