using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator_UnitTests_.Test
{
    public class Calculator_UnitTests_Test
    {
        [Theory]
        [InlineData(8f, 2f, (8f - 2f))]
        [InlineData(14f, 7f, (14f - 7f))]
        [InlineData(12f, 15f, (12f - 15f))]
        public void SubtractNumbers(float a, float b, float expectedResult)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.SubtractNumbers(a, b);

            //Assert
            Assert.True(Math.Abs(expectedResult - result) <= 0.000001f);
        }

        [Theory]
        [InlineData(15f, 7f, (15f + 7f))]
        [InlineData(-5f, -7f, ((-5f) + (-7f)))]
        [InlineData(8.7f, 7.1f, (8.7f + 7.1f))]
        public void SumNumbers(float a, float b, float expectedResult)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.SumNumbers(a, b);

            //Assert
            Assert.True(Math.Abs(expectedResult - result) <= 0.000001f);
        }

        [Theory]
        [InlineData(3f, 7f, (3f * 7f))]
        [InlineData(4.7f, 7.2f, (4.7f * 7.2f))]
        [InlineData(-5f, -7f, (-5f) * (-7f))]
        public void MultiplyNumbers(float a, float b, float expectedResult)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.MultiplyNumbers(a, b);

            //Assert
            Assert.True(Math.Abs(expectedResult - result) <= 0.000001f);
        }

        [Theory]
        [InlineData(3f, 7f, (3f / 7f))]
        [InlineData(49.5f, 4f, (49.5f / 4f))]
        public void DivideNumbers_Positive(float a, float b, float expectedResult)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.DivideNumbers(a, b);

            //Assert
            Assert.True(Math.Abs(expectedResult - result) <= 0.000001f);
        }

        [Fact]
        public void DivideNumbers_ThrowsException()
        {
            //Arrange
            var calculator = new Calculator();
            //Assert
            Assert.Throws<DivideByZeroException>(() => calculator.DivideNumbers(11, 0));
        }
    }
}
