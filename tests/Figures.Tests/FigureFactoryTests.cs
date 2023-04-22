using Figures.Factories;
using Figures.Models;
using FluentAssertions;

namespace Figures.Tests
{
    public class FigureFactoryTests
    {
        [Fact]
        public void CreateCircle_ShouldReturnNewCircle()
        {
            //Arrange
            var radius = 4.0;

            //Act
            var factory = new FigureFactory();

            var circle = factory.CreateCircle(radius);

            //Assert
            circle.Should().NotBeNull().And.BeOfType<Circle>();
        }

        [Fact]
        public void CreateCircle_ShouldThrowArgumentException()
        {

            //Arrange
            var radius = -4.0;

            //Act
            var factory = new FigureFactory();

            var act = () => factory.CreateCircle(radius);

            //Assert
            act.Should().Throw<ArgumentException>("Radius cannot be negative");
        }

        [Fact]
        public void CreateTriangle_ShouldReturnNewTriangle()
        {
            //Arrange
            double a = 3, b = 4, c = 5;

            //Act
            var factory = new FigureFactory();

            var triangle = factory.CreateTriangle(a, b, c);

            //Assert
            triangle.Should().NotBeNull().And.BeOfType<Triangle>();
        }

        [Fact]
        public void CreateTriangle_ShouldThrowArgumentException()
        {
            //Arrange
            double a = 3, b = 4, c = -5;

            //Act
            var factory = new FigureFactory();

            var act = () => factory.CreateTriangle(a, b, c);

            //Assert
            act.Should().Throw<ArgumentException>("Triangle sides must be more than zero");
        }
    }
}
