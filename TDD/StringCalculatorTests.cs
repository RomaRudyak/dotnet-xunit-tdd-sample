using System;
using Xunit;
#pragma warning disable CS1701 // Assuming assembly reference matches identity

namespace TDD
{
    public class StringCalculatorTests
    {

        #region Requirement 1: The method can take 0, 1 or 2 numbers separated by comma (,)
        [Fact]
        public void Add_WhenMoreThan2NumbersAreUsedThenExceptionIsThrown()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            Action act = () => calc.Add("1,2,3");

            // Assert
            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void Add_When2NumbersAreUsedThenNoExceptionIsThrown()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            calc.Add("1,2");
        }

        [Fact]
        public void Add_WhenNonNumberIsUsedThenExceptionIsThrown()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            Action act = () => calc.Add("1,x");

            // Assert
            Assert.Throws<FormatException>(act);
        }
        #endregion Requirement 1: The method can take 0, 1 or 2 numbers separated by comma (,)

        #region Requirement 2: For an empty string the method will return 0
        [Fact]
        public void Add_WhenEmptyStringIsUsedThenReturnValueIs0()
        {
            // Arrange
            const Int32 expectedResult = 0;
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("");

            // Assert
            Assert.Equal(expectedResult, result);
        }
        #endregion Requirement 2: For an empty string the method will return 0

    }
}
#pragma warning restore CS1701 // Assuming assembly reference matches identity
