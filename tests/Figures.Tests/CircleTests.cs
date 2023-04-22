using Figures.Models;
using FluentAssertions;

namespace Figures.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, Math.PI * 4)]
        [InlineData(10, Math.PI * 100)]
        public void GetArea_ShouldRetunCorrectValue(double radius, double expectedResult)
        {
            //Arrange
            var circle = new Circle(radius);

            //Act
            double area = circle.GetArea();

            //Assert
            area.Should().Be(expectedResult);
        }
    }
}
