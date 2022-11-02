namespace FiguresLibrary
{
    public interface IFigure
    {
        public double GetArea();
    }

    public static class DynamicAreaReceiver
    {
        public static double GetArea(IFigure figure) => figure.GetArea();
    }
}