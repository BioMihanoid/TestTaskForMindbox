namespace FiguresLibrary
{
    public sealed class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Error: Radius can not be less than 0!\n");
            Radius = radius;
        }
        public double GetArea() => Math.PI * Radius * Radius;
    }
}
