namespace FiguresLibrary
{
    public sealed class Triangle : IFigure
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentException("Error: Side can not be less than 0!\n");
            if (firstSide > (secondSide + thirdSide) || secondSide > (firstSide + thirdSide) ||
                thirdSide > (firstSide + secondSide))
                throw new ArgumentException("Error: Side can not be more more than 2 other sides!\n");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        public double GetArea()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }

        public bool IsSquarenessTriangle() => (FirstSide * FirstSide + SecondSide * SecondSide) == (ThirdSide * ThirdSide);
    }
}
