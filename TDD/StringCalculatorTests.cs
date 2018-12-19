using System;
using Xunit;
#pragma warning disable CS1701 // Assuming assembly reference matches identity

namespace TDD
{
    public class StringCalculatorTests
    {

        #region Requirement 1: The method can take 0, 1 or 2 numbers separated by comma (,)

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

        #region Requirement 3: Method will return their sum of numbers
        [Fact]
        public void Add_WhenOneNumberIsUsedThenReturnValueIsThatSameNumber()
        {
            // Arrange
            const Int32 expectedResult = 3;
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("3");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Add_WhenTwoNumbersAreUsedThenReturnValueIsTheirSum()
        {
            // Arrange
            const Int32 expectedResult = 3 + 6;
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("3,6");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion Requirement 3: Method will return their sum of numbers

        #region Requirement 4: Allow the Add method to handle an unknown amount of numbers

        [Fact]
        public void Add_WhenAnyNumberOfNumbersIsUsedThenReturnValuesAreTheirSums()
        {
            // Arrange
            const Int32 expectedResult = 33 + 65 + 13 + 58 + 7;
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("33,65,13,58,7");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion Requirement 4: Allow the Add method to handle an unknown amount of numbers

        #region Requirement 5: Allow the Add method to handle new lines between numbers 

        [Fact]
        public void Add_WhenNewLineIsUsedBetweenNumbersThenReturnValuesAreTheirSums()
        {
            // Arrange
            const Int32 expectedResult = 3 + 6 + 5;
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("3,6\n5");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion Requirement 5: Allow the Add method to handle new lines between numbers 

        #region Requirement 6: Support different delimiters

        [Fact]
        public void Add_WhenDelimiterIsSpecifiedThenItIsUsedToSeparateNumbers()
        {
            // Arrange
            const Int32 expectedResult = 3 + 6 + 5;
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("//;\n3;6;5");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion Requirement 6: Support different delimiters

        #region Requirement 7: Negative numbers will throw an exception

        [Fact]
        public void Add_WhenNegativeNumberIsUsedThenRuntimeExceptionIsThrown()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            Action act = () => calc.Add("33,-65,13,58,7");

            // Assert
            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void Add_WhenNegativeNumbersAreUsedThenRuntimeExceptionIsThrown()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            Action act = () => calc.Add("33,-65,13,-58,7");

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Negatives not allowed: [-65, -58]", ex.Message);
        }


        #endregion Requirement 7: Negative numbers will throw an exception

    }
}
#pragma warning restore CS1701 // Assuming assembly reference matches identity
