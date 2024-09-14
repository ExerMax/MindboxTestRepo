using MindboxTest.Geometry;
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
        public void GetAreaWithSomeRadius()
        {
            double someRadius = 1000.12345;
            Figure figure = new Circle(someRadius);
            double area = someRadius * someRadius * 3.14D;

            var res = figure.Area();

            Assert.Equal(area, res);
        }
    }
}
