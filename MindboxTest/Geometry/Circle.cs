namespace MindboxTest.Geometry
{
    public class Circle : Figure
    {
        public double Radius { get; }

        private const double P = 3.14D;

        public Circle(double radius)
        {
            if(radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new ArgumentException($"Circle with radius {radius} is not possible");
            }
        }

        public override double Area()
        {
            return Radius * Radius * P;
        }
    }
}
