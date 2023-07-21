namespace MindBoxTask.Lib
{
    public class Triangle : Calc
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalcArea()
        {
            double p = (A + B + C) / 2;
            double s = Math.Round(Math.Sqrt(p * (p - A) * (p - B * (p - C))), 3);

            return s;
        }
    }
}
