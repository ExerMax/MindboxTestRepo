namespace MindboxTest.Geometry
{
    public class Circle : Figure
    {
        public double Radius { get; }

        private const double P = 3.14D;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * P;
        }
    }
}
