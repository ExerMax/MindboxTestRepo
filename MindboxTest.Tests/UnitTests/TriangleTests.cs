using MindboxTest.Geometry;
using Xunit;

namespace MindboxTest.Tests.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void CreateTriangleWithZeroSides()
        {
            Exception? res = null;
            try
            {
                Figure figure = new Triangle(0, 0, 0);
            }
            catch(Exception ex)
            {
                res = ex;
            }

            Assert.NotNull(res);
        }

        [Fact]
        public void GetAreaWithSomeSides()
        {
            double a = 10;
            double b = 14;
            double c = 15;
            double p = (a + b + c) / 2D;
            var expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Figure figure = new Triangle(a, b, c);

            var res = figure.Area();

            Assert.Equal(expected, res);
        }

        [Fact]
        public void IsTriangleRightAngled()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle figure = new Triangle(a, b, c);

            var res = figure.IsRightAngled();

            Assert.Equal(true, res);
        }

        [Fact]
        public void IsTriangleNotRightAngled()
        {
            double a = 3;
            double b = 4;
            double c = 6;
            Triangle figure = new Triangle(a, b, c);

            var res = figure.IsRightAngled();

            Assert.Equal(false, res);
        }
    }
}
