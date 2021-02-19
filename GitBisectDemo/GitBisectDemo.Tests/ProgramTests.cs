using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GitBisectDemo.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void ProgramRuns_ReturnsCorrectValue()
        {
            // Arrange            
            var calculationEngine = new CalculationEngine();
            var uiEngine = Substitute.For<IUIEngine>();
            uiEngine.GetIntValue("x").Returns(5);
            uiEngine.GetIntValue("y").Returns(5);

            // Act
            Program.RunCalculation(calculationEngine, uiEngine);

            // Assert
            uiEngine.Received(1).OutputValue("Answer is 10");
        }
    }
}
