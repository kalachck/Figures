using Figures.Models.Abstract;

namespace Figures.Models
{
    public class Triangle : IFigure
    {
        private readonly double _a, _b, _c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Triangle sides must be more than zero",
                    string.Join(",", new[] { a, b, c }.Where(x => x <= 0)));
            }

            (_a, _b, _c) = (a, b, c);
        }

        public double GetArea()
        {
            var p = (_a + _b + _c) / 2.0;

            var area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));

            if (double.IsNaN(area) || area == 0)
            {
                throw new ArgumentException("Invalid triangle sides, cannot calculate area");
            }

            return area;
        }

        public bool IsRightAngled()
        {
            var a2 = _a * _a;
            var b2 = _b * _b;
            var c2 = _c * _c;

            return Math.Abs(a2 + b2 - c2) == 0 ||
                Math.Abs(a2 + c2 - b2) == 0 || 
                Math.Abs(b2 + c2 - a2) == 0;
        }
    }
}
