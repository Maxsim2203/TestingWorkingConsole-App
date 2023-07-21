namespace MindBoxTask.Lib
{
    public class Circle : Calc
    {
        public double Radius { get; set; }

        public Circle(double radius) => Radius = radius;

        public override double CalcArea() => Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
    }
}
