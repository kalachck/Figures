using Figures.Models;
using Figures.Models.Abstract;

namespace Figures.Factories
{
    public class FigureFactory
    {
        public IFigure CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public IFigure CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}
