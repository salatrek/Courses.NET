using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TenthLesson_UnitTests_.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void GetSum_2_Plus_5_Eq_7()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.GetSum(2, 5);

            //Assert
            Assert.Equal(7, result);
        }
        [Fact]
        public void GetSub_5_Plus_2_Eq_3()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.GetSub(5, 2);

            //Assert
            Assert.Equal(3, result);
        }
    }
}
