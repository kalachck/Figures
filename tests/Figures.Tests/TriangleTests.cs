using Figures.Models;
using FluentAssertions;

namespace Figures.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetAreay_ShouldReturnCorrecctValue()
        {
            //Arrange
            double a = 3, b = 4, c = 5;

            double expectedArea = 6;

            //Act
            var triangle = new Triangle(a, b, c);

            var actualResult = triangle.GetArea();

            //Assert
            actualResult.Should().Be(expectedArea);
        }

        [Fact]
        public void GetAreay_ShouldThrowArgumentException()
        {
            //Arrange
            double a = 1, b = 1, c = 3;

            //Act
            Triangle triangle = new Triangle(a, b, c);

            var act = () => triangle.GetArea();

            //Assert
            
            act.Should().Throw<ArgumentException>("Invalid triangle sides, cannot calculate area");
        }

        [Fact]
        public void IsRightAngled_ShouldReturnTrue()
        {
            // Arrange
            double a = 3, b = 4, c = 5;

            // Act
            Triangle triangle = new Triangle(a, b, c);
            bool actualResult = triangle.IsRightAngled();

            // Assert
            actualResult.Should().BeTrue();
        }

        [Fact]
        public void IsRightAngled_ShouldReturnFalse()
        {
            // Arrange
            double a = 3, b = 4, c = 6;

            // Act
            Triangle triangle = new Triangle(a, b, c);
            bool actualResult = triangle.IsRightAngled();

            // Assert
            actualResult.Should().BeFalse();
        }
    }
}
