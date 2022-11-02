using System.Threading.Channels;
using FiguresLibrary;

namespace TestTaskForMindbox
{
    public sealed class Program
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);

            Console.WriteLine(triangle.GetArea());

            var r = double.Parse(Console.ReadLine());

            Circle circle = new Circle(r);

            Console.WriteLine(circle.GetArea());

            Console.WriteLine(DynamicAreaReceiver.GetArea(circle));
            Console.WriteLine(DynamicAreaReceiver.GetArea(triangle));
        }
    }
}