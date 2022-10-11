using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            //Arrange
            var calc = new Calculator();
            //Act
            var actual = calc.Add(num1, num2, num3);
            //Assert
            actual.Equals(expected);
        }

        [Theory]
        [InlineData(2, 1, 1)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            //Arrange
            var calc = new Calculator();
            //Act
            var actual = calc.Subtract(minuend, subtrhend);
            //Assert
            actual.Equals(expected);
        }

        [Theory]
        [InlineData(2, 2, 4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            //Arrange
            var calc = new Calculator();
            //Act
            var actual = calc.multiply(num1, num2);
            //Assert
            actual.Equals(expected);
        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var actual = calc.Divide(num1, num2);
            //Assert
            actual.Equals(expected);
        }
    }
}
