using Figures.Factories;
using Figures.Models;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new FigureFactory();

            var circle = factory.CreateCircle(4.0);
            Console.WriteLine($"Circle area: {circle.GetArea():f2}");

            var triangle = factory.CreateTriangle(3.0, 4.0, -6.0);
            var rightTriangle = factory.CreateTriangle(3.0, 4.0, 5.0);

            Console.WriteLine($"Triangle area: {triangle.GetArea():f2}, is right angled: {((Triangle)triangle).IsRightAngled()}");
            Console.WriteLine($"Triangle area: {rightTriangle.GetArea():f2}, is right angled: {((Triangle)rightTriangle).IsRightAngled()}");
        }
    }
}