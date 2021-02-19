using System;
using Xunit;

namespace GitBisectDemo.Tests
{
    public class CalculationTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 5, 6)]
        [InlineData(2, 1, 3)]
        [InlineData(5, 5, 10)]
        [InlineData(-1, 0, -1)]
        [InlineData(-1, -2, -3)]
        public void DoCalculation_ReturnsCorrectValue(int x, int y, float expectedResult)
        {
            // Arrange
            var calculationEngine = new CalculationEngine();

            // Act
            float result = calculationEngine.DoCalculation(x, y);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
