namespace MindboxTest.Geometry
{
    public class Triangle : Figure
    {
        #region Properties and Constructors
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (IsValid(a, b, c))
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException($"Triangle with sides ( {a}, {b}, {c} ) is not possible");
            }
        }
        #endregion

        #region Public
        public override double Area()
        {
            //Heron's formula
            //Semiperimeter
            double p = (A + B + C) / 2D;

            //Main expression
            double sqr = p * (p - A) * (p - B) * (p - C);

            double area = Math.Sqrt(sqr);

            return area;
        }

        public bool IsRightAngled()
        {
            double hypotenuse = GetHypotenuse();

            return (A * A + B * B + C * C) == (hypotenuse * hypotenuse * 2) ? true : false;
        }
        #endregion

        #region Private
        private bool IsValid(double a, double b, double c)
        {
            return GetHypotenuse(a, b, c) * 2D < (a + b + c);
        }

        private double GetHypotenuse(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        private double GetHypotenuse()
        {
            return GetHypotenuse(A, B, C);
        }
        #endregion
    }
}
