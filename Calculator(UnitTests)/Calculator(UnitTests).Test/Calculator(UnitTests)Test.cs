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
        [InlineData(8, 2, (8 - 2))]
        [InlineData(14, 7, (14 - 7))]
        [InlineData(12, 15, (12 - 15))]
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
        [InlineData(15, 7, (15 + 7))]
        [InlineData(-5, -7, ((-5) + (-7)))]
        [InlineData(8.7, 7.1, (8.7 + 7.1))]
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
        [InlineData(3, 7, (3 * 7))]
        [InlineData(4.7, 7.2, (4.7 * 7.2))]
        [InlineData(-5, -7, (-5) * (-7))]
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
        [InlineData(3, 7, (3 / 7))]
        [InlineData(49.5, 4, (49.5 / 4))]
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
            Assert.ThrowsAsync<DivideByZeroException>(() => calculator.DivideNumbers(11, 0));
        }
    }
}
